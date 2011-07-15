using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EnturnadorDAO;

namespace EnturnadorLIB.Enturnador
{
    public class Camion
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.DAO objDAO;

        public Camion()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();
        }

        /// <summary>
        /// Crea un camion
        /// </summary>
        /// <param name="camion">Objeto a insertar</param>
        /// <param name="idUsuario">id del usuario logueado</param>
        /// <returns></returns>
        public int Crear(EnturnadorDAO.CAMION camion, int idUsuario)
        {                        
            if (camion == null)
                throw new Exception("El camión no puede ser null");

            camion.idModificador = idUsuario;
            camion.fechaModificacion = DateTime.Now;
            camion.activo = true;            
            return this.objDAO.Crear(Enumeraciones.Entidad.CAMION, camion);        
        }

        /// <summary>
        /// Actualiza un camión
        /// </summary>
        /// <param name="comercio">Comercio a actualizar</param>
        /// <param name="idUsuario">Id del usuario que realiza la operacion</param>
        public void Actualizar(CAMION camion, int idUsuario)
        {
            if (camion == null)
                throw new Exception("El camión no puede ser null");

            camion.idModificador = idUsuario;
            camion.fechaModificacion = DateTime.Now;
            this.objDAO.Actualizar(Enumeraciones.Entidad.CAMION, camion, camion.id, idUsuario);
        }

        /// <summary>
        /// Inactiva el camión en la base de datos
        /// </summary>
        /// <param name="idRegistro">Id del registro a eliminar</param>
        /// <param name="idUsuario">Id del usuario logueado que realiza la operación</param>
        public void Eliminar(int idRegistro, int idUsuario)
        {
            CAMION camion = (CAMION)this.objDAO.GetEntidadById(Enumeraciones.Entidad.CAMION, idRegistro);
            camion.activo = false;
            camion.fechaModificacion = DateTime.Now;
            camion.idModificador = idUsuario;

            this.objDAO.Actualizar(Enumeraciones.Entidad.CAMION, camion, camion.id, idUsuario);
        }

    }
}
