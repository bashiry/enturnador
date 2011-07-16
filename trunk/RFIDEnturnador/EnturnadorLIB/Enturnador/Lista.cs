﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnturnadorDAO;

namespace EnturnadorLIB.Enturnador
{
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

    }
}