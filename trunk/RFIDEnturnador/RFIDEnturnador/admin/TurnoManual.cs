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
    public partial class TurnoManual : Form
    {
        private EnturnadorLIB.Enturnador.Cola objCola;
        private int idPuertaEnturnar;
        private int idPuertaDesenturnar;

        public TurnoManual()
        {
            InitializeComponent();
        }

        private void TurnoManual_Load(object sender, EventArgs e)
        {
            this.objCola = new EnturnadorLIB.Enturnador.Cola();            

            //Obtiene el id de la puerta para enturnar y para desenturnar
            EnturnadorLIB.Enturnador.Configuracion objConfig = new EnturnadorLIB.Enturnador.Configuracion();
            this.idPuertaEnturnar = Convert.ToInt32(objConfig.GetValorConfig(CGlobal.ID_PUERTA_E1));
            this.idPuertaDesenturnar = Convert.ToInt32(objConfig.GetValorConfig(CGlobal.ID_PUERTA_E2));
        }

        #region "Metodos privados"

        private void Limpiar()
        {
            this.txtPlaca.Text = "";
            this.txtObservaciones.Text = "";
        }

        private bool Validar()
        {
            string mensaje = string.Empty;

            if (this.txtPlaca.Text.Trim().Length == 0)
                mensaje += "- La placa no puede quedar vacía\n";
            else
            {
                if (this.txtPlaca.Text.Length != 6)
                    mensaje += "- La placa no puede tener espacios y debe tener 6 caracteres\n";
            }

            if (mensaje.Length > 0)
            {
                MessageBox.Show("Por favor complete la siguiente información: \n" + mensaje, "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;                     
        }

        private void Enturnar()
        {
            try
            {
                //Se construye la hora de los valores seleccionados en los controles numericupDown
                DateTime hora = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(this.numHora.Value), Convert.ToInt32(this.numMinutos.Value), 0);
                string resultado = this.objCola.Enturnar(this.idPuertaEnturnar, this.txtPlaca.Text.Trim(), hora);

                if (resultado.Length == 0)
                {
                    MessageBox.Show("El camión se ha ingresado a la cola", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpiar();
                }                
                else
                    MessageBox.Show("No se pudo ingresar el camión a la cola: " + resultado, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enturnar el camion: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }    
        }

        private void Desenturnar()
        {
            try
            {
                //Se construye la hora de los valores seleccionados en los controles numericupDown
                DateTime hora = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(this.numHora.Value), Convert.ToInt32(this.numMinutos.Value), 0);
                string resultado = this.objCola.Desenturnar(this.idPuertaDesenturnar, this.txtPlaca.Text.Trim(), hora);

                if (resultado.Length == 0)
                {
                    MessageBox.Show("El camión se ha desenturnado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpiar();
                }
                else
                    MessageBox.Show(resultado, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo desenturnar el camion: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        #endregion

        #region "Eventos"

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                if (this.rbtnEnturnar.Checked)
                    this.Enturnar();
                else
                    this.Desenturnar();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        #endregion




    }
}
