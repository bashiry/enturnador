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

        private void Guardar()
        {
            if (this.idNoticia == 0)
            {

            }
            else
            { 
                
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
            this.Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        #endregion


    }
}
