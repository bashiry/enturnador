using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration;
using System.Collections;

namespace ADT_ServicioRFIDEnturnador
{
    partial class ServicioRFIDEnturnador : ServiceBase
    {
        LLRPReadControl ctrl = new LLRPReadControl();
        private const string LLAVE_PUERTA_E1 = "ID_PUERTA_E1";  //Llave que se busca en la base de datos apra obtener el id de la puerta que enturna
        private const string LLAVE_PUERTA_E2 = "ID_PUERTA_E2";  //Llave que se busca en la base de datos apra obtener el id de la puerta que desenturna        

        public ServicioRFIDEnturnador()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.IniciarLectura();
        }

        protected override void OnStop()
        {
            //Se detienen las lecturas
            this.ctrl.Detener();
        }

        private void IniciarLectura()
        {
            //Se obtienen los ids de las puertas que enturnan y desenturnan
            //EnturnadorLIB.Enturnador.Configuracion objConfig = new EnturnadorLIB.Enturnador.Configuracion();
            System.Diagnostics.EventLog ev = new System.Diagnostics.EventLog();
            ev.Source = "Servicio RFID";
            ev.WriteEntry("1");

            //Se obtienen del archivo de configuracion los ids de las puertas que enturnan y las que desenturnan                        
            string[] arregloEnturnan = ADT_ServicioRFIDEnturnador.Properties.Settings.Default.PuertasEnturnan.Split(',');
            string[] arregloDesenturnan = ADT_ServicioRFIDEnturnador.Properties.Settings.Default.PuertasDesenturnan.Split(',');

            ArrayList arrayEnturnan = new ArrayList();
            ArrayList arrayDesenturnan = new ArrayList();

            ev.WriteEntry("2");
            for (int i = 0; i < arregloEnturnan.Length; i++)
            {
                if (arregloEnturnan[i].ToString().Length > 0)
                    arrayEnturnan.Add(arregloEnturnan[i]);
            }
            for (int i = 0; i < arregloDesenturnan.Length; i++)
            {
                if (arregloDesenturnan[i].ToString().Length > 0)
                    arrayDesenturnan.Add(arregloDesenturnan[i]);
            }
            ev.WriteEntry("3");

            CGlobal.ID_PUERTAS_ENTURNAN = arrayEnturnan;
            CGlobal.ID_PUERTAS_DESENTURNAN = arrayDesenturnan;
            ev.WriteEntry("4");
            
            

            string rutaConfig = ADT_ServicioRFIDEnturnador.Properties.Settings.Default.PathDevicesXml;
            this.ctrl.Iniciar(ADT_ServicioRFIDEnturnador.Properties.Settings.Default.TiempoVerificacion, rutaConfig);
            ev.WriteEntry("5");
        }

    }
}
