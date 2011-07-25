using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnturnadorLIB;

namespace RFIDEnturnador.admin
{
    public partial class Configuracion : Form
    {
        EnturnadorLIB.Enturnador.Configuracion objConfig;

        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            this.objConfig = new EnturnadorLIB.Enturnador.Configuracion();

            //se obtienen los valores actuales
            this.numCantidad.Value = Convert.ToInt32(this.objConfig.GetValorConfig(CGlobal.CANTIDAD_LISTA));
            this.numTiempo.Value = Convert.ToInt32(this.objConfig.GetValorConfig(CGlobal.TIEMPO_LISTA));
        }

        #region "Métodos privados"

        private bool Validar()
        {
            return true;
        }

        private void Guardar()
        {
            try
            {
                this.objConfig.Actualizar(CGlobal.CANTIDAD_LISTA, this.numCantidad.Value.ToString());
                this.objConfig.Actualizar(CGlobal.TIEMPO_LISTA, this.numTiempo.Value.ToString());
                MessageBox.Show("Los valores han sido actualizados. Si la ventana que muestra las colas está abierta en este momento, debe cerrarla y abrirla de nuevo para que los cambios se apliquen", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar los valores de configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                EnturnadorLIB.Enturnador.Util objUtil = new EnturnadorLIB.Enturnador.Util();
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;
                objUtil.LogError("Camiones", "Guardar", ex.Message, inner, CGlobal.IdUsuario);                
            }
        }

        #endregion

        #region "Eventos"

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (this.Validar())
                this.Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
