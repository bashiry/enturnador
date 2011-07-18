using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using EnturnadorDAO;
using EnturnadorLIB;

namespace RFIDEnturnador.seguridad
{
    public partial class Usuarios : Form
    {
        private EnturnadorLIB.Seguridad.Usuario objUsuario;
        private int idUsuario;
        List<ROL> listaRoles;

        private enum Vista
        {
            LISTA = 0,
            NUEVO,            
        }

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.objUsuario = new EnturnadorLIB.Seguridad.Usuario();

            this.CambiarVista(Vista.LISTA);

            this.GetUsuarios();
            this.LlenarRoles();

        }

        #region "Métodos privados"

        private void GetUsuarios()
        {
            //Se construye el hashtable con los criterios
            Hashtable hashCriterios = new Hashtable();

            if (this.txtBuscarNombre.Text.Trim().Length > 0)
                hashCriterios.Add("nombre", this.txtBuscarNombre.Text);

            if (this.txtBuscarLogin.Text.Trim().Length > 0)
                hashCriterios.Add("login", this.txtBuscarLogin.Text);

            if (this.cboBuscarRol.SelectedIndex > 0)
                hashCriterios.Add("idRol", this.cboBuscarRol.SelectedValue);

            this.grdUsuarios.AutoGenerateColumns = false;
            DataTable dt = this.objUsuario.GetUsuarios(hashCriterios);
            this.grdUsuarios.DataSource = dt;

            this.grdUsuarios.Columns["NOMBRE"].Width = 130;
            this.grdUsuarios.Columns["LOGIN"].Width = 90;
            this.grdUsuarios.Columns["ROL"].Width = 130;
            this.grdUsuarios.Columns["EDITAR"].Width = 75;
            this.grdUsuarios.Columns["ELIMINAR"].Width = 75;            
        }

        private void LlenarRoles()
        {
            EnturnadorLIB.Enturnador.Lista objLista = new EnturnadorLIB.Enturnador.Lista();
            this.listaRoles = objLista.GetListaRoles();

            List<ROL> listaCopia = new List<ROL>(this.listaRoles.Count);
            foreach (ROL usu in this.listaRoles)
            {
                listaCopia.Add(usu);
            }

            //Se inserta item de "seleccione" a la lista
            ROL rol = new ROL();
            rol.id = 0;
            rol.rol1 = "Seleccione...";
            listaRoles.Insert(0, rol);

            //Se inserta item de "seleccione" a la lista
            ROL rol2 = new ROL();
            rol2.id = 0;
            rol2.rol1 = "Todos...";
            listaCopia.Insert(0, rol2);

            this.cboBuscarRol.DataSource = listaCopia;
            this.cboBuscarRol.DisplayMember = "rol1";
            this.cboBuscarRol.ValueMember = "id";

            this.cboRol.DataSource = listaRoles;
            this.cboRol.DisplayMember = "rol1";
            this.cboRol.ValueMember = "id";
        }


        private void CambiarVista(Vista vista)
        {
            if (vista == Vista.LISTA)
            {
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel2Collapsed = true;
                this.idUsuario = 0;                
            }
            else if (vista == Vista.NUEVO)
            {
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = false;                
            }
        }

        private void Limpiar()
        {
            this.idUsuario = 0;
            this.txtNombre.Text = "";
            this.cboRol.SelectedIndex = 0;
            this.txtIdentificacion.Text = "";
            this.txtLogin.Text = "";
            this.txtClave.Text = "";
            this.txtNotas.Text = "";            
        }

        private void Editar()
        {
            this.CambiarVista(Vista.NUEVO);

            //Se obtienen los datos actuales
            USUARIO obj = this.objUsuario.GetById(this.idUsuario);

            if (obj == null)
            {
                MessageBox.Show("No se encontró la información del usuario seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.txtNombre.Text = obj.nombre;
            this.cboRol.SelectedIndex = obj.idRol;
            this.txtIdentificacion.Text = obj.identificacion;
            this.txtLogin.Text = obj.login;
            this.txtClave.Text = obj.clave;
            this.txtNotas.Text = "";
        }

        private void Eliminar()
        {
            if (MessageBox.Show("¿Realmente desea eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.objUsuario.Eliminar(this.idUsuario, RFIDEnturnador.CGlobal.IdUsuario);
                this.GetUsuarios();
            }
        }

        /// <summary>
        /// Valida los datos para la creacion de un usuario
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            string mensaje = string.Empty;

            if (this.txtNombre.Text.Trim().Length == 0)
                mensaje += "- El nombre no puede quedar vacío\n";

            if (this.cboRol.SelectedIndex == 0)
                mensaje += "- Debe seleccionar el rol\n";

            if (this.txtIdentificacion.Text.Trim().Length == 0)
                mensaje += "- La identificación no puede quedar vacía\n";

            if (this.txtLogin.Text.Trim().Length == 0)
                mensaje += "- El login no puede quedar vacío\n";

            if (this.txtClave.Text.Trim().Length == 0)
                mensaje += "- La clave no puede quedar vacía\n";

            if (mensaje.Length > 0)
            {
                MessageBox.Show("Por favor complete la siguiente información: \n" + mensaje, "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void Guardar()
        {
            try
            {
                USUARIO usu = new USUARIO();
                usu.nombre = this.txtNombre.Text;
                usu.idRol = Convert.ToInt32(this.cboRol.SelectedValue);
                usu.identificacion = this.txtIdentificacion.Text;
                usu.login = this.txtLogin.Text;
                usu.clave = this.txtClave.Text;
                usu.notas = this.txtNotas.Text;
                usu.activo = true;

                //Si se esta creando
                if (this.idUsuario == 0)
                {
                    this.objUsuario.Crear(usu, RFIDEnturnador.CGlobal.IdUsuario);
                    MessageBox.Show("El usuario ha sido creado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    usu.id = this.idUsuario;
                    this.objUsuario.Actualizar(usu, RFIDEnturnador.CGlobal.IdUsuario);
                    MessageBox.Show("El usuario se ha actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.GetUsuarios();
                this.Limpiar();
                this.CambiarVista(Vista.LISTA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el usuario: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        #endregion


        #region "Eventos"

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.CambiarVista(Vista.NUEVO);
        }

        private void grdUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idUsuario = Convert.ToInt32(this.grdUsuarios.Rows[e.RowIndex].Cells["ID"].Value);

            switch (this.grdUsuarios.Columns[e.ColumnIndex].Name)
            {
                case "EDITAR":
                    this.Editar();
                    break;
                case "ELIMINAR":
                    this.Eliminar();
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.CambiarVista(Vista.LISTA);
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (this.Validar())
                this.Guardar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {            
            this.GetUsuarios();
        }


        #endregion

    }
}
