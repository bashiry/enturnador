using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnturnadorDAO.DAO
{
    public class AntenaDAO
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
        public AntenaDAO()
        {
            this._ent = new ENTURNADOREntities();
        }

        /// <summary>
        /// Retorna una antena, dado el id de antena que se lee desde el reader
        /// </summary>
        /// <param name="idAntena">Id de la antena que se lee desde el reader. OJO: Este id no es el mismo id primary key de la base de datos</param>
        /// <returns></returns>
        public ANTENA GetAntena(string ip, string idAntena)
        {
            var q = (from a in this._ent.ANTENA
                     where a.idAntena == idAntena && a.ip == ip && a.activo == true
                     select a).SingleOrDefault();

            return q;
        }

    }
}
