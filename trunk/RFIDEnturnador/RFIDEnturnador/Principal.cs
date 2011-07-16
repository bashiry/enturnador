using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFIDEnturnador
{
    public partial class Principal : Form
    {        
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {            
            this.Controls[this.Controls.Count - 1].BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void btnAdminCamiones_Click(object sender, EventArgs e)
        {
            Form form = new admin.Camiones();
            form.Show();
        }

        private void btnAdminNoticia_Click(object sender, EventArgs e)
        {
            Form form = new admin.Camiones();
            form.Show();
        }
    }
}
