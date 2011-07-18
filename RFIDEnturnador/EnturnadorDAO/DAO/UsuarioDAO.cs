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

            DataTable dt = Utilidades.DAOUtil.ToDataTable(q);

            DataView dw = dt.DefaultView;
            string filtro = "";

            //Si llegan criterios para filtrar
            if (hashCriterios != null)
            {
                if (hashCriterios.ContainsKey("nombre"))
                    filtro += "nombre LIKE '%" + hashCriterios["nombre"].ToString() + "%' AND ";
                if (hashCriterios.ContainsKey("login"))
                    filtro += "login LIKE '%" + hashCriterios["login"].ToString() + "%' AND ";
                if (hashCriterios.ContainsKey("idRol"))
                    filtro += "idRol = " + Convert.ToInt32(hashCriterios["idRol"].ToString());                    
            }

            if (filtro.EndsWith("AND "))
                filtro = filtro.Substring(0, filtro.Length - 4);

            dw.RowFilter = filtro;

            return dw.ToTable();
        }

        /// <summary>
        /// Retorna un usuario dado su id
        /// </summary>
        /// <param name="login">login a buscar</param>
        /// <returns></returns>
        public USUARIO GetUsuarioByLogin(string login)
        {
            var q = (from u in this._ent.USUARIO
                     where u.activo == true && u.login == login
                     select u).SingleOrDefault();

            return q;

        }

        /// <summary>
        /// Retorna un usuario dado su login y su password
        /// </summary>
        /// <param name="login">login a buscar</param>
        /// <returns></returns>
        public USUARIO GetUsuarioByLoginPassword(string login, string clave)
        {
            var q = (from u in this._ent.USUARIO
                     where u.activo == true && u.login == login && u.clave == clave
                     select u).SingleOrDefault();

            return q;

        }

    }
}
