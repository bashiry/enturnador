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


namespace RFIDEnturnador
{
    public partial class Monitor : Form
    {
        private EnturnadorLIB.Enturnador.Noticia objNoticia;
        private string noticias;
        private int cantidadCaracteres;
        private int contadorCaracteres;
        private const int CARACTERES_VISIBLES_NOTICIA = 50;

        public Monitor()
        {
            InitializeComponent();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            this.objNoticia = new EnturnadorLIB.Enturnador.Noticia();
            this.GetNoticias();
            this.timer1.Enabled = true;
        }

        #region "Métodos privados"

        /// <summary>
        /// Obtiene las noticias activas en el momento
        /// </summary>
        private void GetNoticias()
        {
            List<NOTICIA> listaNoticias = this.objNoticia.GetAll();

            //Construye el string con las noticias
            this.noticias = "";
            foreach (NOTICIA noti in listaNoticias)
            {
                noticias += noti.noticia1 + " - ";
            }

            //Se quita el ultimo guion
            if (this.noticias.Length > 0)
                this.noticias = this.noticias.Substring(0, this.noticias.Length - 2);

            //Suma algunos caracteres de mas para que alcance a salir la última noticia completa
            this.cantidadCaracteres = this.noticias.Length + 15;
            this.contadorCaracteres = 0;
        }

        #endregion

        #region "Eventos"

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Si ya se recorrieron todas la noticias se reinicia
            if (this.contadorCaracteres >= this.cantidadCaracteres)
                this.GetNoticias();

            //Mueve el texto que sale en las noticias, muestra siempre la misma cantidad de caracteres
            string texto = this.noticias.Substring(this.contadorCaracteres, CARACTERES_VISIBLES_NOTICIA);
            this.contadorCaracteres += 1;

            this.txtNoticias.Text = texto;
        }

        #endregion
    }
}
