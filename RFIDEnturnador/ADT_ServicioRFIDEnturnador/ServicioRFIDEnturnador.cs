using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

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
            EnturnadorLIB.Enturnador.Configuracion objConfig = new EnturnadorLIB.Enturnador.Configuracion();
            CGlobal.ID_PUERTA_E1 = Convert.ToInt32(objConfig.GetValorConfig(LLAVE_PUERTA_E1));
            CGlobal.ID_PUERTA_E2 = Convert.ToInt32(objConfig.GetValorConfig(LLAVE_PUERTA_E2));

            string rutaConfig = ADT_ServicioRFIDEnturnador.Properties.Settings.Default.PathDevicesXml;
            this.ctrl.Iniciar(ADT_ServicioRFIDEnturnador.Properties.Settings.Default.TiempoVerificacion, rutaConfig);
        }

    }
}
