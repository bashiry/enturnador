using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnturnadorDAO;

namespace EnturnadorLIB.Enturnador
{
    public class Util
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.DAO objDAO;

        public Util()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();            
        }

        /// <summary>
        /// Guarda log de los errores que se presentan
        /// </summary>
        /// <param name="clase">Página en la que se produjo el erro</param>
        /// <param name="metodo">Método por el que se produjo el error insert, update, delete, select</param>
        /// <param name="excepcion">Mensaje de error lanzado por la excepción</param>
        /// <param name="innerExcepcion">Mensaje propio lanzado según la acción realizada</param>
        /// <param name="idUsuario">Usuario logueado y que raliza la acción, si no se requiere usuario se puede recibir null</param>
        public void LogError(string clase, string metodo, string excepcion, string innerExcepcion, int idUsuario)
        {
            this.objDAO.LogError(clase, metodo, excepcion, innerExcepcion, idUsuario);
        }

    }
}
