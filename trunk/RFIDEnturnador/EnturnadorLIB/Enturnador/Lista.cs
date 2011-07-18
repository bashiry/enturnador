using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnturnadorDAO;

namespace EnturnadorLIB.Enturnador
{
    /// <summary>
    /// Clase que retorna listas
    /// </summary>
    public class Lista
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.DAO objDAO;

        public Lista()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();            
        }

        /// <summary>
        /// Retorna lista de tipos de cargue
        /// </summary>
        /// <returns></returns>
        public List<TIPO_CARGUE> GetListaTipoCargue()
        {
            return this.objDAO.GetListaTipoCargue();
        }

        /// <summary>
        /// Retorna lista de roles
        /// </summary>
        /// <returns></returns>
        public List<ROL> GetListaRoles()
        {
            return this.objDAO.GetRoles();
        }

        /// <summary>
        /// Retorna lista de noticias
        /// </summary>
        /// <returns></returns>
        public List<NOTICIA> GetListaNoticias()
        {
            return this.objDAO.GetNoticias();
        }

        /// <summary>
        /// Retorna lista de puertas que generan turno
        /// </summary>
        /// <returns></returns>
        public List<PUERTA> GetPuertasTurno()
        {
            return this.objDAO.GetPuertasTurno();
        }


    }
}
