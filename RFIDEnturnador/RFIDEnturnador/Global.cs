﻿using System;
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
        /// Declaracion de constantes
        /// </summary>
        public const string ID_PUERTA_E1 = "ID_PUERTA_E1";
        public const string ID_PUERTA_E2 = "ID_PUERTA_E2";

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
            READERS,
            ENTURNAR,
            VER_COLA
        }

    }
}
