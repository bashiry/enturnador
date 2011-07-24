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


namespace RFIDEnturnador.reportes
{
    public partial class ReporteTrazabilidad : Form
    {
        public ReporteTrazabilidad()
        {
            InitializeComponent();
        }

        private void ReporteTrazabilidad_Load(object sender, EventArgs e)
        {
            this.LlenarComboTipoCargue();
        }

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

    }
}
