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
        private EnturnadorLIB.Enturnador.Cola objCola;
        private EnturnadorLIB.Enturnador.Noticia objNoticia;

        private string noticias;        
        private int contadorCaracteres;
        
        List<TIPO_CARGUE> listaTipoCargue;
        private int indiceLista;        
        private int cantidadLista;
        private int paginaActual;
        private DataTable dtCola = new DataTable();
        private DataTable dtCopia = new DataTable();
        DataView dw1;
        DataView dw2;

        public Monitor()
        {
            InitializeComponent();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {                        
            //WindowState = FormWindowState.Maximized;

            //Se obtiene la lista de tipos de cargue
            EnturnadorLIB.Enturnador.Lista objLista = new EnturnadorLIB.Enturnador.Lista();
            this.listaTipoCargue = objLista.GetListaTipoCargue();

            //Se inicia en 0 el indice del tipo de lista
            this.indiceLista = 0;

            //Se obtienen valores de configuracion inicial
            EnturnadorLIB.Enturnador.Configuracion objConfig = new EnturnadorLIB.Enturnador.Configuracion();
            this.cantidadLista = Convert.ToInt32(objConfig.GetValorConfig(CGlobal.CANTIDAD_LISTA));
            int tiempoLista = Convert.ToInt32(objConfig.GetValorConfig(CGlobal.TIEMPO_LISTA));
            this.paginaActual = 1;


            this.objCola = new EnturnadorLIB.Enturnador.Cola();
            this.ProcesarTickLista();
            this.timerLista.Interval = tiempoLista * 1000;
            this.timerLista.Enabled = true;                           
            //this.ProcesarTickLista();

            
            //Se cargan las noticias
            this.objNoticia = new EnturnadorLIB.Enturnador.Noticia();
            this.GetNoticias();
            this.timer1.Enabled = true;

        }

        #region "Métodos privados"

        private void GetCola()
        { 
        
        }

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

            //Se agregan unos espacios en blanco para que alcance a salir completa la ultima noticia
            this.noticias += "               ";
            this.contadorCaracteres = 0;
        }

        private void ProcesarTickLista()
        {
            //Se obtiene la cola del indice actual
            this.dtCola = this.objCola.GetCola(this.listaTipoCargue[this.indiceLista].id);
            this.dtCopia = dtCola.Copy();

            this.CargarGrillas();

            int cantidadPaginas = 1;
            if (this.dtCola.Rows.Count > 0)
            {
                //Cuántas páginas tiene la lista y cuál se está mostrando?
                if (this.dtCola.Rows.Count > this.cantidadLista)
                    cantidadPaginas = (this.dtCola.Rows.Count / this.cantidadLista) + 1;
                else
                    cantidadPaginas = 1;

                //Si la cantidad de paginas es mayor a la página que se está msotrando actualmente, se avanzan dos páginas
                if (cantidadPaginas > this.paginaActual + 1)
                {
                    this.paginaActual += 2;
                }
                else
                {
                    //la pagina actual es mayor a la cantidad de paginas, quiere decir que ya se mostraron todas las
                    //páginas del tipo de cargue actual
                    this.paginaActual = 1;
                    this.SumarIndiceLista();
                }

            }
            else
            {
                //No hay registros para esta cola, se pasa a la siguiente y se reinicia el contador de las paginas
                this.SumarIndiceLista();
                this.paginaActual = 1;
            }        
        }

        private void SumarIndiceLista()
        {
            if (this.indiceLista == this.listaTipoCargue.Count - 1)
                this.indiceLista = 0;
            else
                this.indiceLista += 1;
        }

        /// <summary>
        /// Carga las grillas de las colas, de acuerdo al datatable actual con los datos y a la pagina que se debe mostrar
        /// </summary>
        private void CargarGrillas()
        {
            this.lblTipoCargue.Text = "Cola para: " + this.listaTipoCargue[this.indiceLista].tipoCargue;
            this.lblHoraActual.Text = "Hora: " + DateTime.Now.ToShortTimeString();

            //Se construye un dataview para cada grilla
            int registroInicial = (this.cantidadLista * (this.paginaActual - 1)) + 1;

            if (this.dtCola.Rows.Count == 0)
            {
                this.grd1.DataSource = this.dtCola;
                this.grd2.DataSource = this.dtCopia;
                return;
            }

            this.dw1 = this.dtCola.DefaultView;
            this.dw2 = this.dtCopia.DefaultView;

            dw1.RowFilter = "no >= " + registroInicial.ToString() + " AND no <= " + (registroInicial + 4).ToString();
            dw2.RowFilter = "no >= " + (registroInicial + 5).ToString() + " AND no <= " + (registroInicial + 9).ToString();

            this.grd1.DataSource = dw1.ToTable();
            this.grd2.DataSource = dw2.ToTable();

            //Se cambia el color de las filas impares
            for (int i = 0; i < this.grd1.Rows.Count; i++)
            {
                if ((i % 2) == 0)
                    this.grd1.Rows[i].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            }
            for (int i = 0; i < this.grd2.Rows.Count; i++)
            {
                if ((i % 2) == 0)
                    this.grd2.Rows[i].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            }

            this.FormatearGrillas();
        }

        private void FormatearGrillas()
        {
            this.grd1.Columns[0].HeaderText = "No.";
            this.grd1.Columns[1].HeaderText = "PLACA";
            this.grd1.Columns[2].HeaderText = "HORA";
            this.grd1.Columns[2].DefaultCellStyle.Format = "t";
            this.grd1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.grd2.Columns[0].HeaderText = "No.";
            this.grd2.Columns[1].HeaderText = "PLACA";
            this.grd2.Columns[2].HeaderText = "HORA";
            this.grd2.Columns[2].DefaultCellStyle.Format = "t";
            this.grd2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.grd1.Columns[0].Width = 90;
            this.grd1.Columns[1].Width = 180;
            this.grd1.Columns[2].Width = 280;
            this.grd2.Columns[0].Width = 90;
            this.grd2.Columns[1].Width = 180;
            this.grd2.Columns[2].Width = 280;
        }

        #endregion

        #region "Eventos"

        /// <summary>
        /// Timer para mostrar las noticias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Si ya se recorrieron todas la noticias se reinicia
            if (this.contadorCaracteres >= this.noticias.Length - 1)
            {
                this.GetNoticias();
                return;
            }            
            
            string texto = this.noticias.Substring(0, this.contadorCaracteres);
            this.contadorCaracteres += 1;

            this.txtNoticias.Text = texto;
        }

        /// <summary>
        /// Timer para mostrar las colas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLista_Tick(object sender, EventArgs e)
        {
            this.ProcesarTickLista();
        }

        #endregion


    }
}
