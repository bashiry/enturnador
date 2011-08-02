using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using EnturnadorDAO;
using EnturnadorLIB;

namespace RFIDEnturnador
{
    public partial class Login : Form
    {
        private USUARIO usu;

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

                    EnturnadorLIB.Seguridad.Usuario objUsuario = new EnturnadorLIB.Seguridad.Usuario();

                    this.usu = objUsuario.GetByLoginPassword(this.txtUsuario.Text.Trim(), this.txtClave.Text.Trim());

                    //Si el usuario escribio login o password y no se encontró el usuario
                    if ((usu == null) && ((this.txtUsuario.Text.Trim().Length > 0) || (this.txtClave.Text.Trim().Length > 0)))
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Usuario o clave inválida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Thread th1 = new Thread(new ThreadStart(Run));
                    th1.Start();
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
            /****No es necesario validar eata info porque los usuarios pueden ingresar son loguearse****/

            //string mensaje = "";

            //if (this.txtUsuario.Text.Trim().Length == 0)
            //    mensaje += "- Debe escribir el usuario\n";

            //if (this.txtClave.Text.Trim().Length == 0)
            //    mensaje += "- Debe escribir la clave\n";

            //if (mensaje.Length > 0)
            //{
            //    MessageBox.Show(mensaje, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            return true;        
        }

        private void Run()
        { 
            Application.Run(new Principal(this.usu));
        }

        private void Login_Load(object sender, EventArgs e)
        {            
            //Screen scr = Screen.FromControl(this);
            //MessageBox.Show(scr.WorkingArea.Height.ToString());
            //MessageBox.Show(scr.WorkingArea.Width.ToString());
        }


    }
}
