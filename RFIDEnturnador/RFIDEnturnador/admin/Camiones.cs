using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnturnadorDAO;
using EnturnadorLIB;


namespace RFIDEnturnador.admin
{
    public partial class Camiones : Form
    {
        private EnturnadorLIB.Enturnador.Camion objCamion;
        private int idCamion;

        private enum Vista
        { 
            LISTA = 0,
            NUEVO
        }

        public Camiones()
        {
            InitializeComponent();
        }

        private void Camiones_Load(object sender, EventArgs e)
        {
            this.objCamion = new EnturnadorLIB.Enturnador.Camion();

            this.CambiarVista(Vista.LISTA);
            
            this.GetCamiones();
            this.LlenarComboTipoCargue();
        }

        #region "Métodos privados"

        private void GetCamiones()
        {
            this.grdCamiones.AutoGenerateColumns = false;
            DataTable dtCamiones = this.objCamion.GetAll();
            this.grdCamiones.DataSource = dtCamiones;

            this.grdCamiones.Columns["PLACA"].Width = 130;
            this.grdCamiones.Columns["TIPOCARGUE"].Width = 250;
            this.grdCamiones.Columns["EDITAR"].Width = 95;
            this.grdCamiones.Columns["ELIMINAR"].Width = 95;
        }

        private void LlenarComboTipoCargue()
        {
            EnturnadorLIB.Enturnador.Lista objLista = new EnturnadorLIB.Enturnador.Lista();
            List<TIPO_CARGUE> lista = objLista.GetListaTipoCargue();

            //Se inserta item de "seleccione" a la lista
            TIPO_CARGUE sel = new TIPO_CARGUE();
            sel.id = 0;
            sel.tipoCargue = "Seleccione...";
            lista.Insert(0, sel);            

            this.cboTipoCargue.DataSource = lista;
            this.cboTipoCargue.DisplayMember = "tipoCargue";
            this.cboTipoCargue.ValueMember = "id";            
        }


        private void CambiarVista(Vista vista)
        {
            if (vista == Vista.LISTA)
            {
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel2Collapsed = true;
                this.idCamion = 0;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = false;
            }
        }

        private void Limpiar()
        {
            this.idCamion = 0;
            this.txtPlaca.Text = "";
            this.cboTipoCargue.SelectedIndex = 0;
            this.txtCodigoRFID.Text = "";
        }

        private void Editar()
        {
            this.CambiarVista(Vista.NUEVO);

            //Se obtienen los datos actuales
            CAMION obj = this.objCamion.GetById(this.idCamion);

            if (obj == null)
            {
                MessageBox.Show("No se encontró la información del camión seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.txtPlaca.Text = obj.placa;
            this.cboTipoCargue.SelectedValue = obj.idTipoCargue;
            this.txtCodigoRFID.Text = obj.codigoRFID;            
        }

        private void Eliminar()
        { 
        
        }

        private bool Validar()
        {
            return true;
        }

        private void Guardar()
        { 
        
        }

        #endregion

        #region "Eventos"


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.CambiarVista(Vista.NUEVO);
        }


        private void grdCamiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idCamion = Convert.ToInt32(this.grdCamiones.Rows[e.RowIndex].Cells["ID"].Value);

            switch (this.grdCamiones.Columns[e.ColumnIndex].Name)
            { 
                case "EDITAR":
                    this.Editar();
                    break;
                case "ELIMINAR":
                    this.Eliminar();
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();            
            this.CambiarVista(Vista.LISTA);
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (this.Validar())
                this.Guardar();
        }

        #endregion


    }
}
