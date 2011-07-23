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
        private EnturnadorDAO.DAO.CamionDAO objCamionDAO;        

        public Camion()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();
            this.objCamionDAO = new EnturnadorDAO.DAO.CamionDAO();
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
            if (this.GetCamionByPlaca(camion.placa) != null)
                validacion += "- Ya existe un camión con la placa '" + camion.placa + "'\n";
            if (camion.codigoRFID.Length > 0)
            {
                if (this.GetCamionByRFID(camion.codigoRFID) != null)
                    validacion += "- Ya existe un camión con el mismo código RFID \n";            
            }

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
            
            CAMION cam1 = this.objCamionDAO.GetCamionByPlaca(camion.placa);
            CAMION cam2 = this.objCamionDAO.GetCamionByRFID(camion.codigoRFID);

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
        /// Retorna una camión dado su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CAMION GetById(int id)
        {
            return (CAMION)this.objDAO.GetEntidadById(Enumeraciones.Entidad.CAMION, id);
        }

        /// <summary>
        /// Retorna una lista de todos los camiones activos
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll()
        {
            return this.objCamionDAO.GetCamiones();
        }

        /// <summary>
        /// Retorna camiones que contienen en la placa el string que se recibe como parametro
        /// </summary>
        /// <returns></returns>
        public DataTable GetCamionesByPlaca(string placa)
        {
            return this.objCamionDAO.GetCamionesByPlaca(placa);
        }

        /// <summary>
        /// Retorna un camión dada una placa
        /// </summary>
        /// <param name="placa">Placa a consultar</param>
        /// <returns></returns>
        public CAMION GetCamionByPlaca(string placa)
        {
            return this.objCamionDAO.GetCamionByPlaca(placa);
        }

        /// <summary>
        /// Retorna un camión dado un codigo rfid
        /// </summary>
        /// <param name="codigoRFID">cODIGO a consultar</param>
        /// <returns></returns>
        public CAMION GetCamionByRFID(string codigoRFID)
        {            
            return this.objCamionDAO.GetCamionByRFID(codigoRFID);
        }


    }
}
