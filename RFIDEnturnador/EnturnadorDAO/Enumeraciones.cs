using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnturnadorDAO
{
    /// <summary>
    /// Enumeraciones
    /// </summary>
    public static class Enumeraciones
    {
        /// <summary>
        /// Enumeración de las entidades
        /// </summary>
        public enum Entidad
        {
            CAMION = 0,
            COLA,
            LOG_AUTOMATICO,
            LOG_ERROR,
            LOG_MANUAL,
            NOTICIA,
            READER,
            ROL,
            TIPO_CARGUE,
            USUARIO,
            CONFIGURACION
        }

        /// <summary>
        /// Enumeración de las acciones realizadas sobre una entidad
        /// </summary>
        public enum Accion
        {
            INSERT = 0,
            UPDATE,
            DELETE
        }

        /// <summary>
        /// Enumeracion de los tipos de usuarios que existen en la aplicacion
        /// </summary>
        public enum Roles
        {
            ADMINISTRADOR = 0,
            AUXILIAR,
            TYCO
        }


    }

}
