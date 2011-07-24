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

    }
}
