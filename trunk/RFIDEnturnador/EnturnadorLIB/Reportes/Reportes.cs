using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using EnturnadorDAO;

namespace EnturnadorLIB.Reportes
{
    public class Reportes
    {
        /// <summary>
        /// Objeto que provee el acceso a datos generico
        /// </summary>
        private EnturnadorDAO.DAO.ReporteDAO objReporteDAO;

        public Reportes()
        {
            this.objReporteDAO = new EnturnadorDAO.DAO.ReporteDAO();            
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de trazabilidad
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteTrazabilidad(Hashtable hashFiltros)
        {
            DataTable dt = this.objReporteDAO.GetReporteTrazabilidad(hashFiltros);            

            //La consulta llega ordenada por camion y hora. Se eliminan entonces los registros repetidos en la misma puerta para
            //el mismo camión

            //Se recorre la tabla y se obtienen los ids que se deben eliminar
            string idsEliminar = string.Empty;
            string placaAnterior = "";
            string puertaAnterior = "";
            if (dt.Rows.Count > 0)
            {
                placaAnterior = dt.Rows[0]["placa"].ToString();
                puertaAnterior = dt.Rows[0]["puerta"].ToString();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //Si el registro actual es igual en placa y puerta al anterior se debe eliminar
                    if ((placaAnterior == dt.Rows[i]["placa"].ToString()) && (puertaAnterior == dt.Rows[i]["puerta"].ToString()) && (i > 0))
                        idsEliminar += dt.Rows[i]["id"].ToString() + ",";

                    placaAnterior = dt.Rows[i]["placa"].ToString();
                    puertaAnterior = dt.Rows[i]["puerta"].ToString();    
                }            
            }

            if (idsEliminar.Length > 0)
            {
                if (idsEliminar.EndsWith(","))
                    idsEliminar.Substring(0, idsEliminar.Length - 1);

                DataView dw = dt.DefaultView;
                dw.RowFilter = "id NOT IN(" + idsEliminar + ")";
                dt = dw.ToTable();
            }

            return dt;
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de enturnamientos/desenturnamientos manuales
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteManuales(Hashtable hashFiltros, int idPuertaEnturna, int idPuertaDesenturna)
        {
            DataTable dt = this.objReporteDAO.GetReporteManuales(hashFiltros);
            dt.Columns.Add("tipoProceso");

            //Recorre la tabla y asigna el tipo de proceso (enturnado o desenturnado)
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["idPuerta"].ToString() == idPuertaEnturna.ToString())
                    dt.Rows[i]["tipoProceso"] = "ENTURNADO";
                else
                    dt.Rows[i]["tipoProceso"] = "DESENTURNADO";
            }

            return dt;
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de ciclos incompletos
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteCiclosIncompletos(Hashtable hashFiltros)
        {
            DataTable dt = this.objReporteDAO.GetReporteCiclosIncompletos(hashFiltros);

            //La consulta llega ordenada por camion y hora. Se eliminan entonces los registros repetidos en la misma puerta para
            //el mismo camión

            //Se recorre la tabla y se obtienen los ids que se deben eliminar
            string idsEliminar = string.Empty;
            string placaAnterior = "";
            string puertaAnterior = "";
            if (dt.Rows.Count > 0)
            {
                placaAnterior = dt.Rows[0]["placa"].ToString();
                puertaAnterior = dt.Rows[0]["puerta"].ToString();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //Si el registro actual es igual en placa y puerta al anterior se debe eliminar
                    if ((placaAnterior == dt.Rows[i]["placa"].ToString()) && (puertaAnterior == dt.Rows[i]["puerta"].ToString()) && (i > 0))
                        idsEliminar += dt.Rows[i]["id"].ToString() + ",";

                    placaAnterior = dt.Rows[i]["placa"].ToString();
                    puertaAnterior = dt.Rows[i]["puerta"].ToString();
                }
            }

            if (idsEliminar.Length > 0)
            {
                if (idsEliminar.EndsWith(","))
                    idsEliminar.Substring(0, idsEliminar.Length - 1);

                DataView dw = dt.DefaultView;
                dw.RowFilter = "id NOT IN(" + idsEliminar + ")";
                dt = dw.ToTable();
            }

            //Se recorre la tabla. Se eliminan los registros de los camiones que hicieron el ciclo completo (idAntenas:1,2,3,4)
            idsEliminar = "";
            string placa = "";
            string p1 = "";
            string p2 = "";
            string p3 = "";
            string p4 = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {                
                placa = dt.Rows[i]["placa"].ToString();
                p1 = dt.Rows[i]["idAntena"].ToString();

                //Los sgtes 4 registros deben ser de la misma placa para que el ciclo esté completo
                if (((i + 3) < dt.Rows.Count) && (p1 == "1"))
                {
                    if ((placa == dt.Rows[i + 1]["placa"].ToString()) && (placa == dt.Rows[i + 2]["placa"].ToString()) && (placa == dt.Rows[i + 3]["placa"].ToString()))
                    {
                        //Que las puertas estén completas y en orden
                        p2 = dt.Rows[i + 1]["idAntena"].ToString();
                        p3 = dt.Rows[i + 2]["idAntena"].ToString();
                        p4 = dt.Rows[i + 3]["idAntena"].ToString();

                        if ((p2 == "2") && (p3 == "3") && (p4 == "4"))
                            idsEliminar += dt.Rows[i]["id"].ToString() + "," + dt.Rows[i + 1]["id"].ToString() + "," + dt.Rows[i + 2]["id"].ToString() + "," + dt.Rows[i + 3]["id"].ToString() + ",";                        
                    }
                }                                    
            }

            if (idsEliminar.Length > 0)
            {
                if (idsEliminar.EndsWith(","))
                    idsEliminar.Substring(0, idsEliminar.Length - 1);

                DataView dw = dt.DefaultView;
                dw.RowFilter = "id NOT IN(" + idsEliminar + ")";
                dt = dw.ToTable();
            }


            return dt;
        }


        /// <summary>
        /// Retorna datatable con los resultados del reporte de tiempos en planta
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteTiemposEnPlanta(Hashtable hashFiltros)
        {
            DataTable dt = this.objReporteDAO.GetReporteTiemposEnPlanta(hashFiltros);

            //La consulta llega ordenada por camion y hora. Se eliminan entonces los registros repetidos en la misma puerta para
            //el mismo camión

            //Se recorre la tabla y se obtienen los ids que se deben eliminar
            string idsEliminar = string.Empty;
            string placaAnterior = "";
            string puertaAnterior = "";
            if (dt.Rows.Count > 0)
            {
                placaAnterior = dt.Rows[0]["placa"].ToString();
                puertaAnterior = dt.Rows[0]["puerta"].ToString();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //Si el registro actual es igual en placa y puerta al anterior, o si es de las puertas 2 o 3 se debe eliminar
                    if (((placaAnterior == dt.Rows[i]["placa"].ToString()) && (puertaAnterior == dt.Rows[i]["puerta"].ToString()) && (i > 0)) || ((dt.Rows[i]["idAntena"].ToString() == "2") || (dt.Rows[i]["idAntena"].ToString() == "3")))
                        idsEliminar += dt.Rows[i]["id"].ToString() + ",";

                    //se eliminana los registros de las peurtas 2 y 3
                    if ((dt.Rows[i]["idAntena"].ToString() == "2") || (dt.Rows[i]["idAntena"].ToString() == "3"))
                        idsEliminar += dt.Rows[i]["id"].ToString() + ",";

                    placaAnterior = dt.Rows[i]["placa"].ToString();
                    puertaAnterior = dt.Rows[i]["puerta"].ToString();
                }
            }

            if (idsEliminar.Length > 0)
            {
                if (idsEliminar.EndsWith(","))
                    idsEliminar.Substring(0, idsEliminar.Length - 1);

                DataView dw = dt.DefaultView;
                dw.RowFilter = "id NOT IN(" + idsEliminar + ")";
                dt = dw.ToTable();
            }

            //Nueva tabla para acomodar los resultados de un camion en una sola fila
            DataTable dtTiempo = new DataTable();
            dtTiempo.Columns.Add("placa");
            dtTiempo.Columns.Add("tipoCargue");
            dtTiempo.Columns.Add("horaInicial");
            dtTiempo.Columns.Add("horaFinal");
            dtTiempo.Columns.Add("tiempo");            
            string horaInicial = "";
            string idAntenaAnterior = "";
            DataRow dr;
            TimeSpan tiempo;
            if (dt.Rows.Count > 0)
            {
                placaAnterior = dt.Rows[0]["placa"].ToString();
                puertaAnterior = dt.Rows[0]["puerta"].ToString();                
                horaInicial = dt.Rows[0]["hora"].ToString();
                idAntenaAnterior = dt.Rows[0]["idAntena"].ToString();

                //OJO: empieza en 1 el for
                for (int i = 1; i < dt.Rows.Count; i++)
                {                    
                    //Si la placa del registro anterior es igual
                    if ((dt.Rows[i]["placa"].ToString() == placaAnterior) && (idAntenaAnterior == "1") && (dt.Rows[i]["idAntena"].ToString() == "4"))
                    {
                        dr = dtTiempo.NewRow();
                        dr["placa"] = placaAnterior;
                        dr["tipoCargue"] = dt.Rows[i]["tipoCargue"].ToString();
                        dr["horaInicial"] = horaInicial;
                        dr["horaFinal"] = dt.Rows[i]["hora"].ToString();

                        if (dt.Rows[i]["hora"].ToString().Length > 0)
                        {
                            tiempo = Convert.ToDateTime(dt.Rows[i]["hora"].ToString()).Subtract(Convert.ToDateTime(horaInicial));
                            dr["tiempo"] = tiempo;
                        }
                        else
                        {
                            tiempo = DateTime.Now.Subtract(Convert.ToDateTime(horaInicial));
                            dr["tiempo"] = tiempo;
                        }

                        dtTiempo.Rows.Add(dr);
                        
                    }

                    placaAnterior = dt.Rows[i]["placa"].ToString();
                    puertaAnterior = dt.Rows[i]["puerta"].ToString();                    
                    horaInicial = dt.Rows[i]["hora"].ToString();
                    idAntenaAnterior = dt.Rows[i]["idAntena"].ToString();
                }
            }

            return dtTiempo;
        }

        /// <summary>
        /// Retorna datatable con los resultados del reporte de tiempos por ciclo
        /// </summary>
        /// <param name="hashFiltros">Hashtable con los filtros que se deben aplicar</param>
        /// <returns></returns>
        public DataTable GetReporteTiemposPorCiclo(Hashtable hashFiltros)
        {
            DataTable dt = this.objReporteDAO.GetReporteTiemposPorCiclo(hashFiltros);

            //La consulta llega ordenada por camion y hora. Se eliminan entonces los registros repetidos en la misma puerta para
            //el mismo camión

            //Se recorre la tabla y se obtienen los ids que se deben eliminar
            string idsEliminar = string.Empty;
            string placaAnterior = "";
            string puertaAnterior = "";
            if (dt.Rows.Count > 0)
            {
                placaAnterior = dt.Rows[0]["placa"].ToString();
                puertaAnterior = dt.Rows[0]["puerta"].ToString();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //Si el registro actual es igual en placa y puerta al anterior se debe eliminar
                    if ((placaAnterior == dt.Rows[i]["placa"].ToString()) && (puertaAnterior == dt.Rows[i]["puerta"].ToString()) && (i > 0))
                        idsEliminar += dt.Rows[i]["id"].ToString() + ",";

                    placaAnterior = dt.Rows[i]["placa"].ToString();
                    puertaAnterior = dt.Rows[i]["puerta"].ToString();
                }
            }

            if (idsEliminar.Length > 0)
            {
                if (idsEliminar.EndsWith(","))
                    idsEliminar.Substring(0, idsEliminar.Length - 1);

                DataView dw = dt.DefaultView;
                dw.RowFilter = "id NOT IN(" + idsEliminar + ")";
                dt = dw.ToTable();
            }

            //Nueva tabla para acomodar los resultados de un camion en una sola fila
            string p1 = "";
            string p2 = "";
            string p3 = "";
            string p4 = "";
            DataTable dtTiempo = new DataTable();
            dtTiempo.Columns.Add("placa");
            dtTiempo.Columns.Add("tipoCargue");
            dtTiempo.Columns.Add("horaInicial");
            dtTiempo.Columns.Add("horaFinal");
            dtTiempo.Columns.Add("tiempo");
            string horaInicial = "";
            string placa = "";
            DataRow dr;
            TimeSpan tiempo;
                        
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                placa = dt.Rows[i]["placa"].ToString();
                p1 = dt.Rows[i]["idAntena"].ToString();

                //Los sgtes 4 registros deben ser de la misma placa y haber pasado por las 4 puertas
                if (((i + 3) < dt.Rows.Count) && (p1 == "1"))
                {
                    if ((placa == dt.Rows[i + 1]["placa"].ToString()) && (placa == dt.Rows[i + 2]["placa"].ToString()) && (placa == dt.Rows[i + 3]["placa"].ToString()))
                    {
                        //Que las puertas estén completas y en orden
                        p2 = dt.Rows[i + 1]["idAntena"].ToString();
                        p3 = dt.Rows[i + 2]["idAntena"].ToString();
                        p4 = dt.Rows[i + 3]["idAntena"].ToString();

                        //Puertas completas y en orden, se guardan los tiempos en la nueva tabla
                        if ((p2 == "2") && (p3 == "3") && (p4 == "4"))
                        {
                            dr = dtTiempo.NewRow();
                            dr["placa"] = placa;
                            dr["tipoCargue"] = dt.Rows[i]["tipoCargue"].ToString();
                            dr["horaInicial"] = dt.Rows[i]["hora"].ToString();
                            dr["horaFinal"] = dt.Rows[i + 3]["hora"].ToString();

                            tiempo = Convert.ToDateTime(dr["horaFinal"].ToString()).Subtract(Convert.ToDateTime(dr["horaInicial"]));
                            dr["tiempo"] = tiempo;

                            dtTiempo.Rows.Add(dr);
                        }
                    }
                }
            }
        
            return dtTiempo;
        }


    }
}
