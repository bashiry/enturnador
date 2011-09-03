using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ADT_ServicioRFIDEnturnador.Properties;
using LLRP.src.core.server;
using LLRP.src.util;
using LLRP_Middleware.src.core.taginfo;


namespace ADT_ServicioRFIDEnturnador
{
    internal class LLRPReadControl : IObserverTag, IObserverLLRP
    {
        private IServerLLRP myServer;
        private int state = 0;
        public Hashtable tags;
        private EnturnadorLIB.Enturnador.Cola obJCola;
        private EnturnadorLIB.Enturnador.Util objUtil;


        public LLRPReadControl()
        {
            tags = new Hashtable();
            this.obJCola = new EnturnadorLIB.Enturnador.Cola();
            this.objUtil = new EnturnadorLIB.Enturnador.Util();
        }

        /// <summary>
        /// Inicia la comunicación con los readers
        /// </summary>
        /// <param name="time">Tiempo de verificación de la comunicación con un reader (sg)</param>
        /// <param name="pathXmlReaders">Xml con la configuración de los readers</param>
        public void Iniciar(double time, String pathXmlReaders)
        {
            Console.WriteLine("******************************************Iniciar");
            if (state == 0)
            {
                if (myServer == null)
                {
                    Console.WriteLine("new ServerLLRP");
                    myServer = new ServerLLRP(time, pathXmlReaders, Settings.Default.SecondsToReport);
                    myServer.AddObserverLLRP(this);
                    myServer.AddObserverTag(this);
                    Console.WriteLine("******************************************Termino de iniciar");
                }

                myServer.Start();
                state = 1;
                Console.WriteLine("******************************************myServer.Start");
            }
        }

        /// <summary>
        /// Detiene la comunicación con los readers
        /// </summary>
        public void Detener()
        {
            if (state != 0)
            {
                if (myServer != null)
                {
                    myServer.Stop();
                    Console.WriteLine("******************************************myServer.Stop");
                }
                state = 0;
            }
        }

        delegate void UpdateTagCallback(Tag tag);

        /// <summary>
        /// Inserta el tag recibido en el dgvTags
        /// </summary>
        /// <param name="tag">tag recibido</param>
        private void UpdateTags(Tag tag)
        {
            try
            {
                //object[] row = new object[5];
                //row[0] = tag.TagReportData;
                //row[1] = tag.IdAntenna;
                //row[2] = tag.IsEpc;
                //row[3] = tag.IpReader;
                //row[4] = tag.Epc;

                this.obJCola.RegistrarLectura(tag.IdAntenna, tag.IpReader, tag.Epc, CGlobal.ID_PUERTAS_ENTURNAN, CGlobal.ID_PUERTAS_DESENTURNAN);
                //if (!tags.ContainsKey(tag.Epc))
                //{                    
                //    tags.Add(tag.Epc, tag);                    
                //}
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                //Registra el error
                string inner = "";
                if (exc.InnerException != null)
                    inner = exc.InnerException.Message;
                this.objUtil.LogError("LLRPReadControl", "UpdateTags", exc.Message, inner, 1);
            }

        }

        #region Miembros de IObserverTag

        /// <summary>
        /// Método que se ejecuta cuando es leído un tag desde un reader.
        /// </summary>
        /// <param name="tag"></param>
        public void UpdateTag(LLRP_Middleware.src.core.taginfo.Tag tag)
        {
            ///Adicionarlo en el dgvtags
            UpdateTags(tag);
        }

        #endregion

        #region Miembros de IObserverLLRP

        /// <summary>
        /// Método que se ejecuta cuando se pierde comunicación con un reader.
        /// </summary>
        /// <param name="connection">Conexion que se ha desconectado</param>
        public void updateOnLine(LLRP.src.core.llrp.IConnection connection)
        {
            Console.WriteLine("La reader con IP " + connection.Ip + " se ha CONECTADO!!!");
            //MessageBox.Show("La reader con IP " + connection.Ip + " se ha CONECTADO!!!");
        }

        /// <summary>
        /// Método que se ejecuta cuando se conecta un reader.
        /// </summary>
        /// <param name="connection">Conexion que se ha conectado</param>
        public void updateOffLine(LLRP.src.core.llrp.IConnection connection)
        {
            Console.WriteLine("La reader con IP " + connection.Ip + " se ha DESCONECTADO!!!");
            //MessageBox.Show("La reader con IP " + connection.Ip + " se ha DESCONECTADO!!!");
        }

        #endregion

        public void Limpiar()
        {
            tags.Clear();
        }


    }
}
