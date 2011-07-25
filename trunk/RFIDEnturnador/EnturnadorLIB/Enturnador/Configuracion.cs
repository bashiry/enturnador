using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnturnadorLIB.Enturnador
{
    public class Configuracion
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.DAO objDAO;

        public Configuracion()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();
        }

        /// <summary>
        /// Retorna valor de configuracion de una llave
        /// </summary>
        /// <param name="llave"></param>
        /// <returns></returns>
        public string GetValorConfig(string llave)
        {
            return this.objDAO.GetValorConfig(llave);
        }

        /// <summary>
        /// Actualiza un registro de configuracion
        /// </summary>
        /// <param name="llave">Llave a actualizar</param>
        /// <param name="valor">Nuevo valor de la llave</param>
        public void Actualizar(string llave, string valor)
        {
            this.objDAO.ActualizarValorConfig(llave, valor);
        }


    }
}
