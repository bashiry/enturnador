using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFIDEnturnador
{
    /// <summary>
    /// Clase estatica que guarda variables utilizadas en toda la aplicacion
    /// </summary>
    public static class CGlobal
    {
        public static int IdUsuario;


        /// <summary>
        /// Variables estáticas que son visibles en toda la aplicación
        /// </summary>
        public static int ID_PUERTA_E1;
        public static int ID_PUERTA_E2;



        public enum Roles
        { 
            ADMINISTRADOR,
            AUXILIAR,
            ADT
        }

        /// <summary>
        /// Enumeracion de los formularios de la app
        /// </summary>
        public enum Formularios
        { 
            USUARIOS = 0,
            CAMIONES,
            NOTICIAS,
            CONFIGURACION,
            ENTURNAR,            
            REPORTE_TRAZABILIDAD,
            REPORTE_MANUALES,
            MONITOR
        }

    }
}
