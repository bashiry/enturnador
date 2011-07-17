using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using EnturnadorDAO;

namespace EnturnadorLIB.Enturnador
{
    public class Noticia
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.DAO objDAO;

        public Noticia()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();            
        }

        /// <summary>
        /// Crea una noticia
        /// </summary>
        /// <param name="noticia">Objeto noticia a crear</param>
        /// <param name="idUsuario">id del usuario logueado que realia la operacion</param>
        /// <returns></returns>
        public int Crear(EnturnadorDAO.NOTICIA noticia, int idUsuario)
        {
            if (noticia == null)
                throw new Exception("La noticia no puede ser null");

            noticia.idModifcador = idUsuario;
            noticia.fechaModificacion = DateTime.Now;
            noticia.activo = true;
            return this.objDAO.Crear(Enumeraciones.Entidad.NOTICIA, noticia);
        }

        /// <summary>
        /// Actualiza una noticia
        /// </summary>
        /// <param name="noticia">Objeto noticia a actualizar</param>
        /// <param name="idUsuario">Id del usuario que realiza la operacion</param>
        public void Actualizar(NOTICIA noticia, int idUsuario)
        {
            if (noticia == null)
                throw new Exception("La noticia no puede ser null");

            noticia.idModifcador = idUsuario;
            noticia.fechaModificacion = DateTime.Now;
            noticia.activo = true;
            this.objDAO.Actualizar(Enumeraciones.Entidad.NOTICIA, noticia, noticia.id, idUsuario);
        }

        /// <summary>
        /// Inactiva la noticia en la base de datos
        /// </summary>
        /// <param name="idRegistro">Id del registro a eliminar</param>
        /// <param name="idUsuario">Id del usuario logueado que realiza la operación</param>
        public void Eliminar(int idRegistro, int idUsuario)
        {
            NOTICIA noticia = (NOTICIA)this.objDAO.GetEntidadById(Enumeraciones.Entidad.NOTICIA, idRegistro);
            noticia.activo = false;
            noticia.fechaModificacion = DateTime.Now;
            noticia.idModifcador = idUsuario;

            this.objDAO.Actualizar(Enumeraciones.Entidad.NOTICIA, noticia, noticia.id, idUsuario);
        }

        /// <summary>
        /// Retorna una noticia dado su id
        /// </summary>
        /// <param name="id">Id del registro a retornar</param>
        /// <returns></returns>
        public NOTICIA GetById(int id)
        {
            return (NOTICIA)this.objDAO.GetEntidadById(Enumeraciones.Entidad.NOTICIA, id);
        }

        /// <summary>
        /// Retorna una lista de todos los noticiaes activos
        /// </summary>
        /// <returns></returns>
        public List<NOTICIA> GetAll()
        {
            return this.objDAO.GetNoticias();
        }

    }
}
