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
    public class Cola
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.DAO objDAO;
        private EnturnadorLIB.Enturnador.Camion objCamion;
        private EnturnadorDAO.DAO.ColaDAO objCola;
        private EnturnadorDAO.DAO.AntenaDAO objAntena;

        public Cola()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();
            this.objCamion = new EnturnadorLIB.Enturnador.Camion();
            this.objCola = new EnturnadorDAO.DAO.ColaDAO();
            this.objAntena = new EnturnadorDAO.DAO.AntenaDAO();
        }

        /// <summary>
        /// Enturna un camion. Si todo sale OK se retorna una cadena vacía, de lo contrario se retorna un mensaje indicando porqué no se enturnó
        /// </summary>
        /// <param name="idPuerta">Id de la puerta por donde pasa el camion</param>
        /// <param name="placa">Placa del camion a enturnar</param>
        /// <param name="hora">Hora en la que se enturna</param>
        /// <returns></returns>
        public string EnturnarManual(int idPuerta, string placa, DateTime hora, int idUsuario)
        {
            string resultado = "";

            //Se obtiene el camion
            CAMION camion = this.objCamion.GetCamionByPlaca(placa);

            if (camion == null)
            {
                resultado = "No se encontró el camión con placa '" + placa + "'";
                return resultado;
            }
                        
            //Si el camion esta en alguna cola no puede enturnar
            List<COLA> listaCola = this.objCola.GetColaByPlaca(placa);
            if (listaCola.Count > 0)
            {
                if (listaCola.First().idPuerta == idPuerta)
                    resultado = "No se puede enturnar el camión porque ya está en la cola";                
            }

            //Si todas las validacines estan OK
            if (resultado.Length == 0)
            {
                COLA objCola = new COLA();
                objCola.idPuerta = idPuerta;
                objCola.idTipoCargue = camion.idTipoCargue;
                objCola.placa = placa;
                objCola.hora = hora;                

                this.objDAO.Crear(Enumeraciones.Entidad.COLA, objCola);

                //Guarda log
                this.RegistrarLogManual(camion.idTipoCargue, camion.id, idUsuario, DateTime.Now, idPuerta);
            }

            return resultado;
        }

        /// <summary>
        /// Enturna un cámión cuando se hace de forma automática
        /// </summary>
        /// <param name="camion">camion a enturnar</param>
        /// <param name="idPuerta">id de la puerta donde se detectó el camión</param>
        private void EnturnarAutomatico(CAMION camion, int idPuerta)
        {
            //Si el camion esta en la cola no puede enturnar
            List<COLA> listaCola = this.objCola.GetColaByPlaca(camion.placa);
            if (listaCola.Count > 0)
            {
                if (listaCola.First().idPuerta == idPuerta)
                    return;
            }
            
            COLA objCola = new COLA();
            objCola.idPuerta = idPuerta;
            objCola.idTipoCargue = camion.idTipoCargue;
            objCola.placa = camion.placa;
            objCola.hora = DateTime.Now;

            this.objDAO.Crear(Enumeraciones.Entidad.COLA, objCola);
            
        }

        /// <summary>
        /// Desenturna un camion
        /// </summary>        
        /// <param name="idPuertaDesenturna">id de la puerta por donde pasa un camion</param>
        /// <param name="placa">Placa del camion a desenturnar</param>
        /// <param name="hora">Hora en la que se desenturna</param>
        /// <returns></returns>
        public string DesenturnarManual(int idPuertaDesenturna, string placa, DateTime hora, int idUsuario)
        {
            string resultado = "";

            //Se obtiene el camion
            CAMION camion = this.objCamion.GetCamionByPlaca(placa);

            if (camion == null)
            {
                resultado = "No se encontró el camión con placa '" + placa + "'";
                return resultado;
            }

            //el camion debe estar en la cola para que pueda ser desenturnado
            List<COLA> listaCola = this.objCola.GetColaByPlaca(placa);
            if (listaCola.Count == 0)
                resultado = "No se puede desenturnar el camión porque no está en la cola";
            

            //Si todas las validacines estan OK, se elimina el registro de la cola
            if (resultado.Length == 0)
            {
                this.objCola.EliminarRegistro(placa);
                //Guarda log
                this.RegistrarLogManual(camion.idTipoCargue, camion.id, idUsuario, DateTime.Now, idPuertaDesenturna);
            }

            return resultado;        
        }

        /// <summary>
        /// Desenturna de forma automática un camión
        /// </summary>
        /// <param name="camion">Camión que se desenturna</param>
        /// <param name="idPuerta">Id de la puerta donde se detecta el camión</param>
        private void DesenturnarAutomatico(CAMION camion, int idPuerta)
        {
            //el camion debe estar en la cola para que pueda ser desenturnado
            List<COLA> listaCola = this.objCola.GetColaByPlaca(camion.placa);
            if (listaCola.Count == 0)
                return;

            this.objCola.EliminarRegistro(camion.placa);
        }

        /// <summary>
        /// Registra las lectura automáticas
        /// </summary>
        /// <param name="idAntena">Id de la antena donde se hizo la lectura</param>
        /// <param name="ipReader">Ip del reader que hizo la lectura</param>
        /// <param name="epc">EPC leído</param>
        public void RegistrarLectura(string idAntena, string ipReader, string epc, int idPuertaEnturna, int idPuertaDesenturna)
        { 
            //Se obtiene el camion correspondiente al epc leído. 
            CAMION camion = this.objCamion.GetCamionByRFID(epc);

            //Si no se encuentra camión no se hace nada
            if (camion == null)
                return;

            //Se obtiene la antena
            ANTENA antena = this.objAntena.GetAntena(ipReader, idAntena);
            //Si no se encuentra la antena no se hace nada
            if (antena == null)
                return;

            //Se guarda log de la lectura realizada
            this.RegistrarLogAutomatico(antena.id, camion.idTipoCargue, camion.id, antena.PUERTA.puerta1, epc, DateTime.Now);

            //Se determina si se enturna, se desenturna o no se hace nada
            if (antena.idPuerta == idPuertaEnturna)
            { 
                //Se enturna
                this.EnturnarAutomatico(camion, antena.idPuerta);
            }
            else if (antena.idPuerta == idPuertaDesenturna)
            { 
                //Se desenturna
                this.DesenturnarAutomatico(camion, antena.idPuerta);
            }

        }

        /// <summary>
        /// Guarda log de las lectura automáticas
        /// </summary>
        /// <param name="idAntena">Id de la antena que realiza la lectura</param>
        /// <param name="idTipoCargue">id dle tipo de cargue del camión detectado</param>
        /// <param name="idCamion">id el camión detectado</param>
        /// <param name="puerta">Puerta en la que se detectó</param>
        /// <param name="codigoRFID">Código RFID leído</param>
        /// <param name="hora">Hora en la que se hace la lectura</param>
        public void RegistrarLogAutomatico(int idAntena, int idTipoCargue, int idCamion, string puerta, string codigoRFID, DateTime hora)
        {
            LOG_AUTOMATICO objLog = new LOG_AUTOMATICO();
            objLog.idAntena = idAntena;
            objLog.idTipoCargue = idTipoCargue;
            objLog.idCamion = idCamion;
            objLog.puerta = puerta;
            objLog.codigoRFID = codigoRFID;
            objLog.hora = hora;

            this.objDAO.Crear(Enumeraciones.Entidad.LOG_AUTOMATICO, objLog);
        }

        /// <summary>
        /// Guarda log de las enturnaciones/desenturnaciones manuales
        /// </summary>
        /// <param name="idTipoCargue">id del tipo de cargue</param>
        /// <param name="idCamion">id del camion</param>
        /// <param name="idUsuario">id del usuario que realiza la operación</param>
        /// <param name="hora">hora en la que se enturna/desenturna el camion</param>
        /// <param name="idPuerta">id de la puerta donde se realiza la operacio</param>
        public void RegistrarLogManual(int idTipoCargue, int idCamion, int idUsuario, DateTime hora, int idPuerta)
        {
            LOG_MANUAL objLog = new LOG_MANUAL();
            objLog.idTipoCargue = idTipoCargue;
            objLog.idCamion = idCamion;
            objLog.idUsuario = idUsuario;
            objLog.hora = hora;
            objLog.idPuerta = idPuerta;
        }

    }
}
