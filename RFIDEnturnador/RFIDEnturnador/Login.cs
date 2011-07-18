using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RFIDEnturnador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    Thread th1 = new Thread(new ThreadStart(Run));
                    th1.Start();

                    Cursor = Cursors.Default;
                    this.Close();                    
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }            
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            string mensaje = "";

            if (this.txtUsuario.Text.Trim().Length == 0)
                mensaje += "- Debe escribir el usuario\n";

            if (this.txtClave.Text.Trim().Length == 0)
                mensaje += "- Debe escribir la clave\n";

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;        
        }

        private void Run()
        { 
            Application.Run(new Principal());
        }


    }
}
