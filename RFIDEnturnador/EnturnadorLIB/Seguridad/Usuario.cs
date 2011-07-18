using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Collections;
using EnturnadorDAO;

namespace EnturnadorLIB.Seguridad
{
    public class Usuario
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.DAO objDAO;
        private EnturnadorDAO.DAO.UsuarioDAO objUsuarioDAO;

        public Usuario()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();
            this.objUsuarioDAO = new EnturnadorDAO.DAO.UsuarioDAO();
        }

        /// <summary>
        /// Crea un usuario
        /// </summary>
        /// <param name="usuario">Objeto usuario a crear</param>
        /// <param name="idUsuario">id del usuario logueado que realia la operacion</param>
        /// <returns></returns>
        public int Crear(EnturnadorDAO.USUARIO usuario, int idUsuario)
        {
            if (usuario == null)
                throw new Exception("El usuario no puede ser null");

            //Se valida que no exista un usuario con el mismo login
            USUARIO usu = this.GetByLogin(usuario.login);
            if (usu != null)
                throw new Exception("Ya existe un usuario con el mismo login");

            usuario.idModificador = idUsuario;
            usuario.fechaModificacion = DateTime.Now;
            usuario.activo = true;
            return this.objDAO.Crear(Enumeraciones.Entidad.USUARIO, usuario);
        }

        /// <summary>
        /// Actualiza una usuario
        /// </summary>
        /// <param name="usuario">Objeto usuario a actualizar</param>
        /// <param name="idUsuario">Id del usuario que realiza la operacion</param>
        public void Actualizar(USUARIO usuario, int idUsuario)
        {
            if (usuario == null)
                throw new Exception("El usuario no puede ser null");

            USUARIO usu = this.GetByLogin(usuario.login);
            if (usu != null)
            { 
                if (usu.id != usuario.id)
                    throw new Exception("Ya existe un usuario con el mismo login");
            }
                

            usuario.idModificador = idUsuario;
            usuario.fechaModificacion = DateTime.Now;
            usuario.activo = true;
            this.objDAO.Actualizar(Enumeraciones.Entidad.USUARIO, usuario, usuario.id, idUsuario);
        }

        /// <summary>
        /// Inactiva la usuario en la base de datos
        /// </summary>
        /// <param name="idRegistro">Id del registro a eliminar</param>
        /// <param name="idUsuario">Id del usuario logueado que realiza la operación</param>
        public void Eliminar(int idRegistro, int idUsuario)
        {
            USUARIO usuario = (USUARIO)this.objDAO.GetEntidadById(Enumeraciones.Entidad.USUARIO, idRegistro);
            usuario.activo = false;
            usuario.fechaModificacion = DateTime.Now;
            usuario.idModificador = idUsuario;

            this.objDAO.Actualizar(Enumeraciones.Entidad.USUARIO, usuario, usuario.id, idUsuario);
        }

        /// <summary>
        /// Retorna una usuario dado su id
        /// </summary>
        /// <param name="id">Id del registro a retornar</param>
        /// <returns></returns>
        public USUARIO GetById(int id)
        {
            return (USUARIO)this.objDAO.GetEntidadById(Enumeraciones.Entidad.USUARIO, id);
        }

        /// <summary>
        /// Retorna una usuario dado su login
        /// </summary>
        /// <param name="login">login del usuario a retornar</param>
        /// <returns></returns>
        public USUARIO GetByLogin(string login)
        {
            return (USUARIO)this.objUsuarioDAO.GetUsuarioByLogin(login);
        }

        /// <summary>
        /// Retorna datatable con los usuarios que cumplen los criterios de busqueda
        /// </summary>
        /// <returns></returns>
        public DataTable GetUsuarios(Hashtable hashCriterios)
        {
            return this.objUsuarioDAO.GetUsuarios(hashCriterios);
        }

        

    }
}
