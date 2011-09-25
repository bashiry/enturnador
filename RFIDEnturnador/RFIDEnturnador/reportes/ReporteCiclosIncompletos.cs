using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using EnturnadorDAO;
using EnturnadorLIB;

namespace RFIDEnturnador.reportes
{
    public partial class ReporteCiclosIncompletos : Form
    {
        private EnturnadorLIB.Reportes.Reportes objReporte;
        DataTable dt;

        public ReporteCiclosIncompletos()
        {
            InitializeComponent();
        }

        private void ReporteCiclosIncompletos_Load(object sender, EventArgs e)
        {
            this.objReporte = new EnturnadorLIB.Reportes.Reportes();
            this.LlenarComboTipoCargue();

            //La hora final por defecto son las 24
            this.numHoraFinal.Value = 23;
            this.numMinutosFinal.Value = 59;
        }

        #region "Métodos privados"

        private void LlenarComboTipoCargue()
        {
            EnturnadorLIB.Enturnador.Lista objLista = new EnturnadorLIB.Enturnador.Lista();
            List<TIPO_CARGUE> listaTipoCargue = objLista.GetListaTipoCargue();

            //Se inserta item de "seleccione" a la lista
            TIPO_CARGUE sel = new TIPO_CARGUE();
            sel.id = 0;
            sel.tipoCargue = "Todos...";
            listaTipoCargue.Insert(0, sel);

            this.cboTipoCargue.DataSource = listaTipoCargue;
            this.cboTipoCargue.DisplayMember = "tipoCargue";
            this.cboTipoCargue.ValueMember = "id";
        }

        private bool Validar()
        {
            string mensaje = string.Empty;

            //Se construyen las fecha con los valores seleccionados en los controles numericupDown
            DateTime fecha1 = new DateTime(this.dateFechaInicial.Value.Year, this.dateFechaInicial.Value.Month, this.dateFechaInicial.Value.Day, Convert.ToInt32(this.numHoraInicial.Value), Convert.ToInt32(this.numMinutosInicial.Value), 0);
            DateTime fecha2 = new DateTime(this.dateFechaFinal.Value.Year, this.dateFechaFinal.Value.Month, this.dateFechaFinal.Value.Day, Convert.ToInt32(this.numHoraFinal.Value), Convert.ToInt32(this.numMinutosFinal.Value), 0);

            if (fecha2 <= fecha1)
                mensaje += "La fecha final debe ser anterior a la fecha inicial";

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void GenerarReporte()
        {
            //Se crean los filtros
            Hashtable filtros = new Hashtable();

            DateTime fecha1 = new DateTime(this.dateFechaInicial.Value.Year, this.dateFechaInicial.Value.Month, this.dateFechaInicial.Value.Day, Convert.ToInt32(this.numHoraInicial.Value), Convert.ToInt32(this.numMinutosInicial.Value), 0);
            DateTime fecha2 = new DateTime(this.dateFechaFinal.Value.Year, this.dateFechaFinal.Value.Month, this.dateFechaFinal.Value.Day, Convert.ToInt32(this.numHoraFinal.Value), Convert.ToInt32(this.numMinutosFinal.Value), 0);

            filtros.Add("fechaInicial", fecha1);
            filtros.Add("fechaFinal", fecha2);

            if (this.cboTipoCargue.SelectedIndex > 0)
                filtros.Add("idTipoCargue", this.cboTipoCargue.SelectedValue);
            if (this.txtPlacas.Text.Trim().Length > 0)
                filtros.Add("placas", this.txtPlacas.Text.Trim());

            this.dt = this.objReporte.GetReporteCiclosIncompletos(filtros);
            this.grd.AutoGenerateColumns = false;
            this.grd.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("No se encontraron registros con los criterios seleccionados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Exportar()
        {
            if (this.dt == null)
            {
                MessageBox.Show("No hay resultados para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                StringBuilder rep = new StringBuilder();
                rep.Append("<table border='1'>");

                //Agrega fila con los títulos de las columnas
                rep.Append("<tr>");
                rep.Append("<td align='center'><strong>PLACA</strong></td>");
                rep.Append("<td align='center'><strong>TIPO DE CARGUE</strong></td>");
                rep.Append("<td align='center'><strong>FECHA</strong></td>");
                rep.Append("<td align='center'><strong>PTO. SENSADO</strong></td>");
                rep.Append("</tr>");

                //Recorre el datatable y construye taba html con los resultados
                for (int i = 0; i < this.dt.Rows.Count; i++)
                {
                    rep.Append("<tr>");
                    rep.Append("<td>" + dt.Rows[i]["placa"].ToString() + "</td>");
                    rep.Append("<td>" + dt.Rows[i]["tipoCargue"].ToString() + "</td>");
                    rep.Append("<td>" + dt.Rows[i]["hora"].ToString() + "</td>");
                    rep.Append("<td>" + dt.Rows[i]["puerta"].ToString() + "</td>");
                    rep.Append("</tr>");
                }

                rep.Append("</table>");

                //Nombre del archivo            
                //24/07/2011 11:27:24 a.m.
                string strHora = DateTime.Now.ToString();
                strHora = strHora.Replace("/", "");
                strHora = strHora.Replace(":", "_");
                strHora = strHora.Replace(".", "");
                string nombre = "ReporteCiclosIncompletos_" + strHora + ".xls";

                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombre);

                StreamWriter sw = new StreamWriter(ruta);
                sw.WriteLine(rep.ToString());
                sw.Close();

                MessageBox.Show("El archivo se ha creado en el escritorio, con el siguiente nombre: '" + nombre + "'", "Archivo creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al crear el archivo, por favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Se guarda log del error
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;

                EnturnadorLIB.Enturnador.Util objUtil = new EnturnadorLIB.Enturnador.Util();
                objUtil.LogError("ReporteCiclosIncompletos", "Exportar", ex.Message, inner, CGlobal.IdUsuario);
            }
        }

        #endregion

        #region "Eventos"

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (this.Validar())
                this.GenerarReporte();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            this.Exportar();
        }

        #endregion

    }
}
