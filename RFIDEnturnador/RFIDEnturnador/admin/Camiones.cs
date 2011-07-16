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
            NUEVO,
            CARGUE
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
            this.grdCamiones.Columns["TIPOCARGUE"].Width = 200;
            this.grdCamiones.Columns["EDITAR"].Width = 95;
            this.grdCamiones.Columns["ELIMINAR"].Width = 95;
            this.grdCamiones.Columns["TIPOCARGUE"].HeaderText = "TIPO CARGUE";
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
                this.panelCargueMasivo.Visible = false;
            }
            else if(vista == Vista.NUEVO)
            {
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = false;
                this.panelCargueMasivo.Visible = false;
            }
            else if (vista == Vista.CARGUE)
            {
                this.panelCargueMasivo.Visible = true;
                this.panelCargueMasivo.Height = 390;
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
            if (MessageBox.Show("¿Realmente desea eliminar este camión?", "Eliminar camión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.objCamion.Eliminar(this.idCamion, RFIDEnturnador.CGlobal.IdUsuario);
                this.GetCamiones();
            }
        }

        /// <summary>
        /// Valida los datos para la creacion de un camion
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            string mensaje = string.Empty;

            if (this.txtPlaca.Text.Trim().Length == 0)
                mensaje += "- La placa no puede quedar vacía\n";
            else
            { 
                if(this.txtPlaca.Text.Length != 6)
                    mensaje += "- La placa no puede tener espacios y debe tener 6 caracteres\n";
            }

            if (this.cboTipoCargue.SelectedIndex == 0)
                mensaje += "- Debe seleccionar el tipo de cargue\n";

            if (mensaje.Length > 0)
            {
                MessageBox.Show("Por favor complete la siguiente información: \n" + mensaje, "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }            

            return true;
        }

        private void Guardar()
        {
            try
            {
                CAMION cam = new CAMION();
                cam.codigoRFID = "";
                cam.idTipoCargue = Convert.ToInt32(this.cboTipoCargue.SelectedValue);
                cam.placa = this.txtPlaca.Text;
                cam.codigoRFID = this.txtCodigoRFID.Text;
                cam.activo = true;

                //Si se esta creando el camion
                if (this.idCamion == 0)
                {
                    this.objCamion.Crear(cam, RFIDEnturnador.CGlobal.IdUsuario);
                    MessageBox.Show("El camión ha sido creado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cam.id = this.idCamion;
                    this.objCamion.Actualizar(cam, RFIDEnturnador.CGlobal.IdUsuario);
                    MessageBox.Show("El camión se ha actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.GetCamiones();
                this.Limpiar();
                this.CambiarVista(Vista.LISTA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el camión: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.grdCamiones.AutoGenerateColumns = false;
            DataTable dtCamiones = this.objCamion.GetCamionesByPlaca(this.txtBuscarPlaca.Text);
            this.grdCamiones.DataSource = dtCamiones;

            if (dtCamiones.Rows.Count == 0)
                MessageBox.Show("No se encontraron camiones", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.grdCamiones.Columns["PLACA"].Width = 130;
            this.grdCamiones.Columns["TIPOCARGUE"].Width = 200;
            this.grdCamiones.Columns["EDITAR"].Width = 95;
            this.grdCamiones.Columns["ELIMINAR"].Width = 95;
            this.grdCamiones.Columns["TIPOCARGUE"].HeaderText = "TIPO CARGUE";
        }

        private void btnVerCargue_Click(object sender, EventArgs e)
        {
            this.CambiarVista(Vista.CARGUE);
        }

        /// <summary>
        /// Estando en el panel de carga masiva se presiona cancelar: se vuelve a mostrar la lista de camiones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarCarga_Click(object sender, EventArgs e)
        {
            this.CambiarVista(Vista.LISTA);
        }


        #endregion





    }
}
