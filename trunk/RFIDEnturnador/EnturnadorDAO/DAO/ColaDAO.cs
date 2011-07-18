using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnturnadorDAO.DAO
{
    public class ColaDAO
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
        public ColaDAO()
        {
            this._ent = new ENTURNADOREntities();
        }

        /// <summary>
        /// Elimina un registro de la cola
        /// </summary>
        public void EliminarRegistro(string placa)
        {
            var q = (from c in this._ent.COLA
                     where c.placa == placa
                     select c).SingleOrDefault();

            //Si no se encuentra el registro, no se hace nada porque ya esta eliminado
            if (q == null)
                return;

            this._ent.DeleteObject(q);
            this._ent.SaveChanges();
        }

        /// <summary>
        /// Retorna los registros que encuentra en la cola para una placa
        /// </summary>
        /// <param name="placa">Placa a buscar en la cola</param>
        /// <returns></returns>
        public List<COLA> GetColaByPlaca(string placa)
        {
            var q = from c in this._ent.COLA
                    where c.placa == placa
                    select c;

            return q.ToList();
        }

    }
}
