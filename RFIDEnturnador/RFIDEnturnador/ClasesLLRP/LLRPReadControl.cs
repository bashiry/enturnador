using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using RFIDEnturnador.Properties;
using LLRP.src.core.server;
using LLRP.src.util;
using LLRP_Middleware.src.core.taginfo;



namespace RFIDEnturnador.ClasesLLRP
{
    public class LLRPReadControl : IObserverTag, IObserverLLRP
    {
        private IServerLLRP myServer;
        private int state = 0;
        public Hashtable tags;

        public LLRPReadControl()
        {
            tags = new Hashtable();
        }

        /// <summary>
        /// Inicia la comunicación con los readers
        /// </summary>
        /// <param name="time">Tiempo de verificación de la comunicación con un reader (sg)</param>
        /// <param name="pathXmlReaders">Xml con la configuración de los readers</param>
        public void Iniciar(double time, String pathXmlReaders)
        {
            if (state == 0)
            {
                if (myServer == null)
                {
                    myServer = new ServerLLRP(time, pathXmlReaders, Settings.Default.SecondsToReport);
                    myServer.AddObserverLLRP(this);
                    myServer.AddObserverTag(this);
                }

                myServer.Start();
                state = 1;
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
                object[] row = new object[5];
                row[0] = tag.TagReportData;
                row[1] = tag.IdAntenna;
                row[2] = tag.IsEpc;
                row[3] = tag.IpReader;
                row[4] = tag.Epc;

                if (!tags.ContainsKey(tag.Epc))
                {
                    //this.dgvTags.Rows.Insert(0, row);
                    tags.Add(tag.Epc, tag);
                    //showCount(tags.Count.ToString());
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
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
            MessageBox.Show("La reader con IP " + connection.Ip + " se ha CONECTADO!!!");
        }

        /// <summary>
        /// Método que se ejecuta cuando se conecta un reader.
        /// </summary>
        /// <param name="connection">Conexion que se ha conectado</param>
        public void updateOffLine(LLRP.src.core.llrp.IConnection connection)
        {
            Console.WriteLine("La reader con IP " + connection.Ip + " se ha DESCONECTADO!!!");
            MessageBox.Show("La reader con IP " + connection.Ip + " se ha DESCONECTADO!!!");
        }

        #endregion

        public void Limpiar()
        {
            tags.Clear();
        }


    }
}
