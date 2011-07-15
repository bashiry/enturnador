using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnturnadorDAO.Utilidades;

namespace EnturnadorDAO.DAO
{
    public class CamionDAO
    {
        #region "Atributos"

        /// <summary>
        /// Objeto ENTURNADOREntities que relaciona todas las entidades
        /// </summary>
        private ENTURNADOREntities _ent;
        #endregion

        /// <summary>
        /// constructor de la clase
        /// </summary>
        public CamionDAO()
        {
            this._ent = new ENTURNADOREntities();
        }

        /// <summary>
        /// Retorna un camión dada una placa
        /// </summary>
        /// <param name="placa">Placa a consultar</param>
        /// <returns></returns>
        public CAMION GetCamionByPlaca(string placa)
        {
            var q = (from c in this._ent.CAMION
                    where c.placa == placa && c.activo == true
                    select c).SingleOrDefault();

            return q;
        }

        /// <summary>
        /// Retorna un camión dado un codigo rfid
        /// </summary>
        /// <param name="codigoRFID">cODIGO a consultar</param>
        /// <returns></returns>
        public CAMION GetCamionByRFID(string codigoRFID)
        {
            var q = (from c in this._ent.CAMION
                     where c.codigoRFID == codigoRFID && c.activo == true
                     select c).SingleOrDefault();

            return q;
        }


    }
}
