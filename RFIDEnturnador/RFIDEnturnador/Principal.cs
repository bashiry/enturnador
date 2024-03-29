﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnturnadorDAO;


namespace RFIDEnturnador
{
    public partial class Principal : Form
    {
        private USUARIO usuario;
        //ClasesLLRP.LLRPReadControl ctrl = new ClasesLLRP.LLRPReadControl();
        private const string LLAVE_PUERTA_E1 = "ID_PUERTA_E1";  //Llave que se busca en la base de datos apra obtener el id de la puerta que enturna
        private const string LLAVE_PUERTA_E2 = "ID_PUERTA_E2";  //Llave que se busca en la base de datos apra obtener el id de la puerta que desenturna        

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(USUARIO objUsuario)
        {
            InitializeComponent();

            //Si el usuario llega en null, se inicializa la variable y se ponen valores por defecto
            if (objUsuario == null)
            {
                objUsuario = new USUARIO();
                objUsuario.id = 0;
                objUsuario.nombre = "Sin identificar";
                objUsuario.idRol = 0;

                objUsuario.ROL = new ROL();
                objUsuario.ROL.rol1 = "";
            }

            this.usuario = objUsuario;
            CGlobal.IdUsuario = this.usuario.id;
            this.lblUsuario.Text = "Usuario: " + this.usuario.nombre;

            //Se obtienen los ids de las puertas que enturnan y desenturnan
            EnturnadorLIB.Enturnador.Configuracion objConfig = new EnturnadorLIB.Enturnador.Configuracion();
            CGlobal.ID_PUERTA_E1 = Convert.ToInt32(objConfig.GetValorConfig(LLAVE_PUERTA_E1));
            CGlobal.ID_PUERTA_E2 = Convert.ToInt32(objConfig.GetValorConfig(LLAVE_PUERTA_E2));

            this.cboReporte.SelectedIndex = 0;
        }

        private void Principal_Load(object sender, EventArgs e)
        {            
            this.Controls[this.Controls.Count - 1].BackColor = System.Drawing.Color.WhiteSmoke;

            //Se inicia lectura de los readers
            this.IniciarLectura();
        }

        /// <summary>
        /// Valida si un usuario petenece a un rol
        /// </summary>
        /// <param name="obj">Objeto usuario que se va a validar</param>
        /// <param name="rol">Enumeracion de tipo rol</param>
        /// <returns></returns>
        private bool IsInRole(USUARIO obj, CGlobal.Roles rol)
        {
            bool retorno = false;

            if (obj.ROL.rol1.Equals(rol.ToString()))
                retorno = true;

            return retorno;
        }

        /// <summary>
        /// Retorna true si el usuario logueado tiene permisos para ingresar a un formulario, de acuerdo al rol al que pertenece
        /// </summary>
        /// <param name="formulario">Enumeracion de formularios</param>
        /// <returns></returns>
        private bool ValidarPermiso(CGlobal.Formularios formulario)
        {
            bool retorno = false;

            switch (formulario)
            { 
                case CGlobal.Formularios.CAMIONES:
                    if (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString()))
                        retorno = true;
                    break;
                case CGlobal.Formularios.ENTURNAR:
                    if (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString()))
                        retorno = true;
                    break;
                case CGlobal.Formularios.NOTICIAS:
                    if (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString()))
                        retorno = true;
                    break;
                case CGlobal.Formularios.CONFIGURACION:
                    if (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString()))
                        retorno = true;
                    break;
                case CGlobal.Formularios.USUARIOS:
                    if (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString()))
                        retorno = true;
                    break;
                case CGlobal.Formularios.MONITOR:                    
                        retorno = true;
                    break;
                case CGlobal.Formularios.REPORTES:
                    if (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString()))
                        retorno = true;
                    break;
            }


            return retorno;
        }

        #region "Eventos de los botones"

        private void btnAdminCamiones_Click(object sender, EventArgs e)
        {
            if (this.ValidarPermiso(CGlobal.Formularios.CAMIONES))
            {
                Form form = new admin.Camiones();
                form.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos para ingresar a esta opción", "No tiene permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdminNoticia_Click(object sender, EventArgs e)
        {
            if (this.ValidarPermiso(CGlobal.Formularios.NOTICIAS))
            {
                Form form = new admin.Noticias();
                form.Show();            
            }
            else
            {
                MessageBox.Show("No tiene permisos para ingresar a esta opción", "No tiene permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            if (this.ValidarPermiso(CGlobal.Formularios.USUARIOS))
            {
                Form form = new seguridad.Usuarios();
                form.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos para ingresar a esta opción", "No tiene permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdminConfiguracion_Click(object sender, EventArgs e)
        {
            if (this.ValidarPermiso(CGlobal.Formularios.CONFIGURACION))
            {
                Form form = new admin.Configuracion();
                form.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos para ingresar a esta opción", "No tiene permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (this.ValidarPermiso(CGlobal.Formularios.MONITOR))
            {
                Form form = new Monitor();
                form.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos para ingresar a esta opción", "No tiene permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEnturnar_Click(object sender, EventArgs e)
        {
            if (this.ValidarPermiso(CGlobal.Formularios.ENTURNAR))
            {
                Form form = new admin.TurnoManual();
                form.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos para ingresar a esta opción", "No tiene permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void IniciarLectura()
        {            
            //string rutaConfig = @"configFiles\Devices.xml";
            //string rutaConfig = RFIDEnturnador.Properties.Settings.Default.PathDevicesXml;
            //this.ctrl.Iniciar(RFIDEnturnador.Properties.Settings.Default.TiempoVerificacion, rutaConfig);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.ctrl.Detener();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (this.ValidarPermiso(CGlobal.Formularios.REPORTES))
            {
                if (this.cboReporte.Items[this.cboReporte.SelectedIndex].ToString() == "Trazabilidad")
                {
                    Form form = new reportes.ReporteTrazabilidad();
                    form.Show();                
                }
                else if (this.cboReporte.Items[this.cboReporte.SelectedIndex].ToString() == "Enturnamientos manuales")
                {
                    Form form = new reportes.ReporteManuales();
                    form.Show();
                }
                else if (this.cboReporte.Items[this.cboReporte.SelectedIndex].ToString() == "Ciclos incompletos")
                {
                    Form form = new reportes.ReporteCiclosIncompletos();
                    form.Show();                
                }
                else if (this.cboReporte.Items[this.cboReporte.SelectedIndex].ToString() == "Tiempo en planta")
                {
                    Form form = new reportes.ReporteTiemposEnPlanta();
                    form.Show();                                
                }
                else if (this.cboReporte.Items[this.cboReporte.SelectedIndex].ToString() == "Tiempo por ciclo")
                {
                    Form form = new reportes.ReporteTiemposPorCiclo();
                    form.Show();                                                
                }


            }
            else
            {
                MessageBox.Show("No tiene permisos para ingresar a esta opción", "No tiene permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
