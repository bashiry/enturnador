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
    public partial class Noticias : Form
    {
        private EnturnadorLIB.Enturnador.Noticia objNoticia;
        private int idNoticia;

        public Noticias()
        {
            InitializeComponent();
        }

        private void Noticias_Load(object sender, EventArgs e)
        {
            this.objNoticia = new EnturnadorLIB.Enturnador.Noticia();
            this.GetNoticias();
        }

        #region "Metodos privados"

        private void GetNoticias()
        {
            this.grdNoticias.AutoGenerateColumns = false;
            List<NOTICIA> dt = this.objNoticia.GetAll();
            this.grdNoticias.DataSource = dt;

            this.grdNoticias.Columns["NOTICIA"].Width = 300;
            this.grdNoticias.Columns["EDITAR"].Width = 95;
            this.grdNoticias.Columns["ELIMINAR"].Width = 95;
        }

        private void Editar()
        {
            //Se obtienen los datos actuales
            NOTICIA obj = this.objNoticia.GetById(this.idNoticia);

            if (obj == null)
            {
                MessageBox.Show("No se encontró la información de la noticia seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.txtNoticia.Text = obj.noticia1;
        }

        private void Eliminar()
        {
            if (MessageBox.Show("¿Realmente desea eliminar esta noticia?", "Eliminar noticia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.objNoticia.Eliminar(this.idNoticia, RFIDEnturnador.CGlobal.IdUsuario);
                this.GetNoticias();
            }
        }

        private void Limpiar()
        {
            this.txtNoticia.Text = "";
            this.idNoticia = 0;
        }

        private bool Validar()
        {
            string mensaje = string.Empty;

            if (this.txtNoticia.Text.Trim().Length == 0)
                mensaje += "- La noticia no puede quedar vacía\n";
            else
            {
                if (this.txtNoticia.Text.Length > 450)
                    mensaje += "- La noticia no puede tener mas de 450 caracteres\n";
            }

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void Guardar()
        {
            try
            {
                NOTICIA noti = new NOTICIA();
                noti.noticia1 = this.txtNoticia.Text;

                if (this.idNoticia == 0)
                {
                    this.objNoticia.Crear(noti, CGlobal.IdUsuario);
                    MessageBox.Show("La noticia ha sido creada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    noti.id = this.idNoticia;
                    this.objNoticia.Actualizar(noti, CGlobal.IdUsuario);
                    MessageBox.Show("La noticia ha sido actualizada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.GetNoticias();
                this.Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la noticia: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region "Eventos"

        private void grdNoticias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idNoticia = Convert.ToInt32(this.grdNoticias.Rows[e.RowIndex].Cells["ID"].Value);

            switch (this.grdNoticias.Columns[e.ColumnIndex].Name)
            {
                case "EDITAR":
                    this.Editar();
                    break;
                case "ELIMINAR":
                    this.Eliminar();
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
                this.Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        #endregion


    }
}
