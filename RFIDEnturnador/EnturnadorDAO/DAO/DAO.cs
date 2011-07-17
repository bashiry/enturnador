using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using EnturnadorDAO.Utilidades;


namespace EnturnadorDAO.DAO
{
    /// <summary>
    /// clase es responsable de implementar metodos de insercion y actualización de forma genérica
    /// </summary>
    public class DAO
    {
        #region "Atributos"

        /// <summary>
        /// Objeto ENTURNADOREntities que relaciona todas las entidades
        /// </summary>
        private ENTURNADOREntities _ent;
        #endregion

        /// <summary>
        /// constructor de la clase DAO
        /// </summary>
        public DAO()
        {
            this._ent = new ENTURNADOREntities();
        }

       
        /// <summary>
        /// Persiste en la base de datos el objeto que le llega y retorna el id del registro recien creado
        /// </summary>
        /// <param name="entidad">Entidad que debe estar relacionada en la clase Enumeraciones</param>
        /// <param name="obj">objeto que se recibe y se inserta en la DB</param>
        /// <param name="idUsuario">Si no se requiere usuario se puede recibir null</param>
        /// <returns>retorno del id delregistro insertado</returns>
        public int Crear(Enumeraciones.Entidad entidad, EntityObject obj)
        {          
            this._ent.AddObject(entidad.ToString(), obj);
            this._ent.SaveChanges();

            if (obj == null)
                throw new Exception("El objeto no puede ser null");

            if (obj.EntityKey.EntityKeyValues.Count() == 1)
                return Convert.ToInt32(obj.EntityKey.EntityKeyValues[0].Value.ToString());
            else
                return 0;            
        }

        /// <summary>
        ///  Persiste en la base de datos las modificaciones al objeto que le llega
        /// </summary>
        /// <param name="entidad">Objeto entidad que se va a insertar</param>
        /// <param name="obj">Objeto que se recibe  y se inserta en la DB</param>
        /// <param name="idRegistro">Corresponde al id del registro que se va actualizar</param>
        /// <param name="idUsuario">Si no se requiere usuario se puede recibir null</param>
        public void Actualizar(Enumeraciones.Entidad entidad, EntityObject obj, int idRegistro, int? idUsuario)
        {
            if (obj == null)
                throw new Exception("El objeto no puede ser null");

            //Agrega el entity key
            if (obj.EntityKey == null)
                obj.EntityKey = this.GetEntityKey(entidad, idRegistro);


            Utilidades.DAOUtil.AttachUpdated(this._ent, obj);
            this._ent.SaveChanges();
        }

        /// <summary>
        /// Retorna el objeto correspondiente al id que recibe
        /// </summary>
        /// <param name="entidad">Tipo de objeto entidad solicitado</param>
        /// <param name="idRegistro">Identificador del registro solicitado</param>
        /// <returns></returns>
        public EntityObject GetEntidadById(Enumeraciones.Entidad entidad, int idRegistro)
        {
            EntityKey llave = this.GetEntityKey(entidad, idRegistro);
            return (EntityObject)this._ent.GetObjectByKey(llave);
        }

        /// <summary>
        /// Retorna el EntityKey correspondiente a la entidad y id que llega.
        /// </summary>
        /// <param name="entidad">Tipo de objeto entidad solicitado</param>
        /// <param name="idRegistro">Identificador del registro solicitado</param>
        /// <returns></returns>
        private EntityKey GetEntityKey(Enumeraciones.Entidad entidad, int idRegistro)
        {
            EntityKey llave = new EntityKey(Constantes.PREFIJOQUALIFIEDENTITYSETNAME + entidad.ToString(), "id", idRegistro);
            return llave;
        }

        /// <summary>
        /// Guarda log de los errores que se presentan
        /// </summary>
        /// <param name="clase">Página en la que se produjo el erro</param>
        /// <param name="metodo">Método por el que se produjo el error insert, update, delete, select</param>
        /// <param name="excepcion">Mensaje de error lanzado por la excepción</param>
        /// <param name="innerExcepcion">Mensaje propio lanzado según la acción realizada</param>
        /// <param name="idUsuario">Usuario logueado y que raliza la acción, si no se requiere usuario se puede recibir null</param>
        public void LogError(string clase, string metodo, string excepcion, string innerExcepcion, int idUsuario)
        {
            if (excepcion == null)
                excepcion = "";
            if (innerExcepcion == null)
                innerExcepcion = "";

            if (excepcion.Length > 2000)
                excepcion = excepcion.Substring(0, 2000);
            if (innerExcepcion.Length > 2000)
                innerExcepcion = innerExcepcion.Substring(0, 2000);

            LOG_ERROR objError = new LOG_ERROR();                        
            objError.mensaje = excepcion;
            objError.innerMensaje = innerExcepcion;
            objError.idUsuario = idUsuario;
            objError.fecha = DateTime.Now;
            objError.clase = clase;
            objError.metodo = metodo;
            this._ent.AddToLOG_ERROR(objError);
            this._ent.SaveChanges();
        }

        #region "Listas"

        /// <summary>
        /// Retorna lista de tipos de cargue
        /// </summary>
        /// <returns></returns>
        public List<TIPO_CARGUE> GetListaTipoCargue()
        {
            var q = from t in this._ent.TIPO_CARGUE
                    where t.activo == true
                    orderby t.tipoCargue
                    select t;

            return q.ToList();
        }

        /// <summary>
        /// Retorna lista de noticias activas
        /// </summary>
        /// <returns></returns>
        public List<NOTICIA> GetNoticias()
        {
            var q = from t in this._ent.NOTICIA
                    where t.activo == true                    
                    select t;

            return q.ToList();            
        }

        /// <summary>
        /// Retorna lista de perfiles activos
        /// </summary>
        /// <returns></returns>
        public List<ROL> GetRoles()
        {
            var q = from t in this._ent.ROL
                    where t.activo == true
                    select t;

            return q.ToList();
        }

        #endregion

    }
}
