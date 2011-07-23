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

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(USUARIO objUsuario)
        {
            InitializeComponent();
            this.usuario = objUsuario;
            CGlobal.IdUsuario = this.usuario.id;
            this.lblUsuario.Text = "Usuario: " + this.usuario.nombre;
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
                case CGlobal.Formularios.READERS:
                    if ((this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString())) || (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADT.ToString())))
                        retorno = true;
                    break;
                case CGlobal.Formularios.USUARIOS:
                    if (this.usuario.ROL.rol1.Equals(CGlobal.Roles.ADMINISTRADOR.ToString()))
                        retorno = true;
                    break;
                case CGlobal.Formularios.VER_COLA:                    
                        retorno = true;
                    break;
            }


            return retorno;
        }

        
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

        private void IniciarLectura()
        {
            
        }

    }
}
