using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using EnturnadorDAO.Utilidades;

namespace EnturnadorDAO.DAO
{
    public class ReporteDAO
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
        public ReporteDAO()
        {
            this._ent = new ENTURNADOREntities();
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de trazabilidad
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteTrazabilidad(Hashtable hashFiltros)
        {
            var q = from l in this._ent.LOG_AUTOMATICO
                    join c in this._ent.CAMION on l.idCamion equals c.id
                    join t in this._ent.TIPO_CARGUE on c.idTipoCargue equals t.id
                    orderby l.idCamion, l.hora
                    select new
                    {
                        id = l.id,
                        placa = c.placa,
                        idTipoCargue = l.idTipoCargue,
                        tipoCargue = t.tipoCargue,
                        puerta = l.puerta,
                        hora = l.hora
                    };

            //Se agregan los filtros que llegan
            if (hashFiltros.ContainsKey("fechaInicial"))
            {
                DateTime fecha1 = Convert.ToDateTime(hashFiltros["fechaInicial"].ToString());
                q = q.Where(l => l.hora >= fecha1);
            }            
            if (hashFiltros.ContainsKey("fechaFinal"))
            {
                DateTime fecha2 = Convert.ToDateTime(hashFiltros["fechaFinal"].ToString());
                q = q.Where(l => l.hora <= fecha2);
            }
            if (hashFiltros.ContainsKey("idTipoCargue"))
            {
                int idTipoCargue = Convert.ToInt32(hashFiltros["idTipoCargue"].ToString());
                q = q.Where(l => l.idTipoCargue == idTipoCargue);
            }
            
            if (hashFiltros.ContainsKey("placas"))
            {
                string[] placas = hashFiltros["placas"].ToString().Split(',');
                q = q.Where(l => placas.Contains(l.placa));
            }

            return Utilidades.DAOUtil.ToDataTable(q);
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de enturnamientos/desenturnamientos manuales
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteManuales(Hashtable hashFiltros)
        {
            var q = from l in this._ent.LOG_MANUAL
                    join c in this._ent.CAMION on l.idCamion equals c.id
                    join t in this._ent.TIPO_CARGUE on c.idTipoCargue equals t.id
                    join p in this._ent.PUERTA on l.idPuerta equals p.id
                    orderby l.idCamion, l.hora
                    select new
                    {
                        id = l.id,
                        placa = c.placa,
                        idTipoCargue = l.idTipoCargue,
                        tipoCargue = t.tipoCargue,
                        puerta = p.puerta1,
                        idPuerta = l.idPuerta,
                        hora = l.hora
                    };

            //Se agregan los filtros que llegan
            if (hashFiltros.ContainsKey("fechaInicial"))
            {
                DateTime fecha1 = Convert.ToDateTime(hashFiltros["fechaInicial"].ToString());
                q = q.Where(l => l.hora >= fecha1);
            }
            if (hashFiltros.ContainsKey("fechaFinal"))
            {
                DateTime fecha2 = Convert.ToDateTime(hashFiltros["fechaFinal"].ToString());
                q = q.Where(l => l.hora <= fecha2);
            }

            if (hashFiltros.ContainsKey("placas"))
            {
                string[] placas = hashFiltros["placas"].ToString().Split(',');
                q = q.Where(l => placas.Contains(l.placa));
            }

            return Utilidades.DAOUtil.ToDataTable(q);        
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de ciclos incompletos
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteCiclosIncompletos(Hashtable hashFiltros)
        {
            var q = from l in this._ent.LOG_AUTOMATICO
                    join c in this._ent.CAMION on l.idCamion equals c.id
                    join t in this._ent.TIPO_CARGUE on c.idTipoCargue equals t.id
                    orderby l.idCamion, l.hora
                    select new
                    {
                        id = l.id,
                        placa = c.placa,
                        idTipoCargue = l.idTipoCargue,
                        tipoCargue = t.tipoCargue,
                        puerta = l.puerta,
                        hora = l.hora,
                        l.idAntena
                    };

            //Se agregan los filtros que llegan
            if (hashFiltros.ContainsKey("fechaInicial"))
            {
                DateTime fecha1 = Convert.ToDateTime(hashFiltros["fechaInicial"].ToString());
                q = q.Where(l => l.hora >= fecha1);
            }
            if (hashFiltros.ContainsKey("fechaFinal"))
            {
                DateTime fecha2 = Convert.ToDateTime(hashFiltros["fechaFinal"].ToString());
                q = q.Where(l => l.hora <= fecha2);
            }
            if (hashFiltros.ContainsKey("idTipoCargue"))
            {
                int idTipoCargue = Convert.ToInt32(hashFiltros["idTipoCargue"].ToString());
                q = q.Where(l => l.idTipoCargue == idTipoCargue);
            }

            if (hashFiltros.ContainsKey("placas"))
            {
                string[] placas = hashFiltros["placas"].ToString().Split(',');
                q = q.Where(l => placas.Contains(l.placa));
            }

            return Utilidades.DAOUtil.ToDataTable(q);
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de ciclos incompletos
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteTiemposEnPlanta(Hashtable hashFiltros)
        {
            var q = from l in this._ent.LOG_AUTOMATICO
                    join c in this._ent.CAMION on l.idCamion equals c.id
                    join t in this._ent.TIPO_CARGUE on c.idTipoCargue equals t.id
                    orderby l.idCamion, l.hora
                    select new
                    {
                        id = l.id,
                        placa = c.placa,
                        idTipoCargue = l.idTipoCargue,
                        tipoCargue = t.tipoCargue,
                        puerta = l.puerta,
                        hora = l.hora,
                        l.idAntena
                    };

            //Se agregan los filtros que llegan
            if (hashFiltros.ContainsKey("fechaInicial"))
            {
                DateTime fecha1 = Convert.ToDateTime(hashFiltros["fechaInicial"].ToString());
                q = q.Where(l => l.hora >= fecha1);
            }
            if (hashFiltros.ContainsKey("fechaFinal"))
            {
                DateTime fecha2 = Convert.ToDateTime(hashFiltros["fechaFinal"].ToString());
                q = q.Where(l => l.hora <= fecha2);
            }
            if (hashFiltros.ContainsKey("idTipoCargue"))
            {
                int idTipoCargue = Convert.ToInt32(hashFiltros["idTipoCargue"].ToString());
                q = q.Where(l => l.idTipoCargue == idTipoCargue);
            }

            if (hashFiltros.ContainsKey("placas"))
            {
                string[] placas = hashFiltros["placas"].ToString().Split(',');
                q = q.Where(l => placas.Contains(l.placa));
            }

            return Utilidades.DAOUtil.ToDataTable(q);
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de tiempos por ciclo
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteTiemposPorCiclo(Hashtable hashFiltros)
        {
            var q = from l in this._ent.LOG_AUTOMATICO
                    join c in this._ent.CAMION on l.idCamion equals c.id
                    join t in this._ent.TIPO_CARGUE on c.idTipoCargue equals t.id
                    orderby l.idCamion, l.hora
                    select new
                    {
                        id = l.id,
                        placa = c.placa,
                        idTipoCargue = l.idTipoCargue,
                        tipoCargue = t.tipoCargue,
                        puerta = l.puerta,
                        hora = l.hora,
                        l.idAntena
                    };

            //Se agregan los filtros que llegan
            if (hashFiltros.ContainsKey("fechaInicial"))
            {
                DateTime fecha1 = Convert.ToDateTime(hashFiltros["fechaInicial"].ToString());
                q = q.Where(l => l.hora >= fecha1);
            }
            if (hashFiltros.ContainsKey("fechaFinal"))
            {
                DateTime fecha2 = Convert.ToDateTime(hashFiltros["fechaFinal"].ToString());
                q = q.Where(l => l.hora <= fecha2);
            }
            if (hashFiltros.ContainsKey("idTipoCargue"))
            {
                int idTipoCargue = Convert.ToInt32(hashFiltros["idTipoCargue"].ToString());
                q = q.Where(l => l.idTipoCargue == idTipoCargue);
            }

            if (hashFiltros.ContainsKey("placas"))
            {
                string[] placas = hashFiltros["placas"].ToString().Split(',');
                q = q.Where(l => placas.Contains(l.placa));
            }

            return Utilidades.DAOUtil.ToDataTable(q);
        }

    }
}
