using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using EnturnadorDAO.Utilidades;

namespace EnturnadorDAO.DAO
{
    public class UsuarioDAO
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
        public UsuarioDAO()
        {
            this._ent = new ENTURNADOREntities();
        }

        /// <summary>
        /// Retorna usuarios activos, filtrados por los criterios que llegan
        /// </summary>
        /// <returns></returns>
        public DataTable GetUsuarios(Hashtable hashCriterios)
        {
            var q = from u in this._ent.USUARIO
                    join r in this._ent.ROL on u.idRol equals r.id
                    where u.activo == true
                    orderby u.nombre
                    select new
                    {
                        id = u.id,
                        idRol = u.idRol,
                        rol = r.rol1,
                        nombre = u.nombre,
                        identificacion = u.identificacion,
                        login = u.login,
                        clave = u.clave,
                        notas = u.notas
                    };

            //Si llegan criterios para filtrar
            if (hashCriterios != null)
            { 
                if (hashCriterios.ContainsKey("nombre"))
                    q = q.Where(u => u.nombre.Contains(hashCriterios["nombre"].ToString()));
                if (hashCriterios.ContainsKey("login"))
                    q = q.Where(u => u.login.Contains(hashCriterios["login"].ToString()));
                if (hashCriterios.ContainsKey("idRol"))
                    q = q.Where(u => u.idRol == Convert.ToInt32(hashCriterios["idRol"].ToString()));
            }

            return Utilidades.DAOUtil.ToDataTable(q);
        }        

    }
}
