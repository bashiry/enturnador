using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using EnturnadorDAO;
using EnturnadorLIB;


namespace RFIDEnturnador.reportes
{
    public partial class ReporteTrazabilidad : Form
    {
        private EnturnadorLIB.Reportes.Reportes objReporte;

        public ReporteTrazabilidad()
        {
            InitializeComponent();
        }

        private void ReporteTrazabilidad_Load(object sender, EventArgs e)
        {
            this.objReporte = new EnturnadorLIB.Reportes.Reportes();
            this.LlenarComboTipoCargue();
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

            DataTable dt = this.objReporte.GetReporteTrazabilidad(filtros);
            this.grd.AutoGenerateColumns = false;
            this.grd.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("No se encontraron registros con los criterios seleccionados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        #endregion

        #region "Eventos"

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (this.Validar())
                this.GenerarReporte();
        }

        #endregion

    }
}
