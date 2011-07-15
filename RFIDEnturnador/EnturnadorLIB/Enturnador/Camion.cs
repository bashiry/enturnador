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

            //Se valida que no exista ya un camión con la misma placa o codigo rfid
            string validacion = "";
            EnturnadorDAO.DAO.CamionDAO objCamionDAO = new EnturnadorDAO.DAO.CamionDAO();
            if (objCamionDAO.GetCamionByPlaca(camion.placa) != null)
                validacion += "- Ya existe un camión con la placa '" + camion.placa + "'\n";
            if (objCamionDAO.GetCamionByRFID(camion.codigoRFID) != null)
                validacion += "- Ya existe un camión con el código RFID leído\n";

            //No se superaron las validaciones, se lanza error
            if (validacion.Length > 0)            
                throw new Exception(validacion);             

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

            //Se valida que no exista otro camión con la misma placa o codigo rfid
            string validacion = "";
            EnturnadorDAO.DAO.CamionDAO objCamionDAO = new EnturnadorDAO.DAO.CamionDAO();

            CAMION cam1 = objCamionDAO.GetCamionByPlaca(camion.placa);
            CAMION cam2 = objCamionDAO.GetCamionByRFID(camion.codigoRFID);

            if (cam1 != null)
            { 
                if(cam1.id != camion.id)
                    validacion += "- Ya existe un camión con la placa '" + camion.placa + "'\n";
            }
            if (cam2 != null)
            {
                if (cam2.codigoRFID != camion.codigoRFID)
                    validacion += "- Ya existe un camión con el código RFID leído\n";
            }

            //No se superaron las validaciones, se lanza error
            if (validacion.Length > 0)
                throw new Exception(validacion);             

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

        /// <summary>
        /// Retorna una lista de todos los camiones activos
        /// </summary>
        /// <returns></returns>
        public List<CAMION> GetAll()
        {
            return this.objDAO.GetCamiones();            
        }

    }
}
