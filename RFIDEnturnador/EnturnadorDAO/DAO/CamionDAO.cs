using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
        /// Retorna camiones activos
        /// </summary>
        /// <returns></returns>
        public DataTable GetCamiones()
        {
            var q = from c in this._ent.CAMION
                    join t in this._ent.TIPO_CARGUE on c.idTipoCargue equals t.id
                    where c.activo == true
                    orderby c.placa
                    select new
                    {
                        id = c.id,
                        idTipoCargue = c.idTipoCargue,
                        placa = c.placa,
                        codigoRFID = c.codigoRFID,
                        tipoCargue = t.tipoCargue
                    };

            return Utilidades.DAOUtil.ToDataTable(q);
        }

        /// <summary>
        /// Retorna camiones que contienen en la placa el string que se recibe como parametro
        /// </summary>
        /// <param name="placa">String que se va a buscar en la placa</param>
        /// <returns></returns>
        public DataTable GetCamionesByPlaca(string placa)
        {
            var q = from c in this._ent.CAMION
                    join t in this._ent.TIPO_CARGUE on c.idTipoCargue equals t.id
                    where c.activo == true && c.placa.Contains(placa)
                    orderby c.placa
                    select new
                    {
                        id = c.id,
                        idTipoCargue = c.idTipoCargue,
                        placa = c.placa,
                        codigoRFID = c.codigoRFID,
                        tipoCargue = t.tipoCargue
                    };

            return Utilidades.DAOUtil.ToDataTable(q);        
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
