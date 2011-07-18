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

        public Cola()
        {
            this.objDAO = new EnturnadorDAO.DAO.DAO();
            this.objCamion = new EnturnadorLIB.Enturnador.Camion();
            this.objCola = new EnturnadorDAO.DAO.ColaDAO();
        }

        /// <summary>
        /// Enturna un camion. Si todo sale OK se retorna una cadena vacía, de lo contrario se retorna un mensaje indicando porqué no se enturnó
        /// </summary>
        /// <param name="idPuerta">Id de la puerta por donde pasa el camion</param>
        /// <param name="placa">Placa del camion a enturnar</param>
        /// <param name="hora">Hora en la que se enturna</param>
        /// <returns></returns>
        public string Enturnar(int idPuerta, string placa, DateTime hora)
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
            }

            return resultado;
        }

        /// <summary>
        /// Desenturna un camion
        /// </summary>        
        /// <param name="idPuertaDesenturna">id de la puerta por donde pasa un camion</param>
        /// <param name="placa">Placa del camion a desenturnar</param>
        /// <param name="hora">Hora en la que se desenturna</param>
        /// <returns></returns>
        public string Desenturnar(int idPuertaDesenturna, string placa, DateTime hora)
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
            }

            return resultado;        
        }

    }
}
