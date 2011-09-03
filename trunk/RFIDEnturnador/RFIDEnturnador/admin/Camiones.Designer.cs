namespace RFIDEnturnador.admin
{
    partial class Camiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCargueMasivo = new System.Windows.Forms.Panel();
            this.btnCancelarCarga = new System.Windows.Forms.Button();
            this.lblCantidadError = new System.Windows.Forms.Label();
            this.lblCantidadGuardada = new System.Windows.Forms.Label();
            this.lblCantidadLeida = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grdCargue = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnVerCargue = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarPlaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grdCamiones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTIPOCARGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCARGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureLectora = new System.Windows.Forms.PictureBox();
            this.txtCodigoRFID = new System.Windows.Forms.TextBox();
            this.cboTipoCargue = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelCargueMasivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCargue)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLectora)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelCargueMasivo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 601);
            this.panel1.TabIndex = 0;
            // 
            // panelCargueMasivo
            // 
            this.panelCargueMasivo.Controls.Add(this.btnCancelarCarga);
            this.panelCargueMasivo.Controls.Add(this.lblCantidadError);
            this.panelCargueMasivo.Controls.Add(this.lblCantidadGuardada);
            this.panelCargueMasivo.Controls.Add(this.lblCantidadLeida);
            this.panelCargueMasivo.Controls.Add(this.btnSeleccionar);
            this.panelCargueMasivo.Controls.Add(this.label6);
            this.panelCargueMasivo.Controls.Add(this.grdCargue);
            this.panelCargueMasivo.Location = new System.Drawing.Point(16, 92);
            this.panelCargueMasivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCargueMasivo.Name = "panelCargueMasivo";
            this.panelCargueMasivo.Size = new System.Drawing.Size(599, 33);
            this.panelCargueMasivo.TabIndex = 7;
            this.panelCargueMasivo.Visible = false;
            // 
            // btnCancelarCarga
            // 
            this.btnCancelarCarga.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarCarga.Image = global::RFIDEnturnador.Properties.Resources.back;
            this.btnCancelarCarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCarga.Location = new System.Drawing.Point(437, 11);
            this.btnCancelarCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarCarga.Name = "btnCancelarCarga";
            this.btnCancelarCarga.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarCarga.TabIndex = 24;
            this.btnCancelarCarga.Text = "Volver";
            this.btnCancelarCarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCarga.UseVisualStyleBackColor = true;
            this.btnCancelarCarga.Click += new System.EventHandler(this.btnCancelarCarga_Click);
            // 
            // lblCantidadError
            // 
            this.lblCantidadError.AutoSize = true;
            this.lblCantidadError.Location = new System.Drawing.Point(8, 106);
            this.lblCantidadError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadError.Name = "lblCantidadError";
            this.lblCantidadError.Size = new System.Drawing.Size(134, 17);
            this.lblCantidadError.TabIndex = 23;
            this.lblCantidadError.Text = "Registros con error:";
            // 
            // lblCantidadGuardada
            // 
            this.lblCantidadGuardada.AutoSize = true;
            this.lblCantidadGuardada.Location = new System.Drawing.Point(8, 78);
            this.lblCantidadGuardada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadGuardada.Name = "lblCantidadGuardada";
            this.lblCantidadGuardada.Size = new System.Drawing.Size(231, 17);
            this.lblCantidadGuardada.TabIndex = 22;
            this.lblCantidadGuardada.Text = "Registros guardados exitosamente:";
            // 
            // lblCantidadLeida
            // 
            this.lblCantidadLeida.AutoSize = true;
            this.lblCantidadLeida.Location = new System.Drawing.Point(8, 48);
            this.lblCantidadLeida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadLeida.Name = "lblCantidadLeida";
            this.lblCantidadLeida.Size = new System.Drawing.Size(157, 17);
            this.lblCantidadLeida.TabIndex = 21;
            this.lblCantidadLeida.Text = "Registros en el archivo:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = global::RFIDEnturnador.Properties.Resources.folder;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(253, 11);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(176, 28);
            this.btnSeleccionar.TabIndex = 20;
            this.btnSeleccionar.Text = "Seleccionar archivo";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Seleccione el archivo con los datos:";
            // 
            // grdCargue
            // 
            this.grdCargue.AllowUserToAddRows = false;
            this.grdCargue.AllowUserToDeleteRows = false;
            this.grdCargue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCargue.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCargue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCargue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCargue.Location = new System.Drawing.Point(12, 139);
            this.grdCargue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdCargue.Name = "grdCargue";
            this.grdCargue.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCargue.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCargue.RowHeadersVisible = false;
            this.grdCargue.RowHeadersWidth = 20;
            this.grdCargue.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grdCargue.RowTemplate.Height = 24;
            this.grdCargue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grdCargue.Size = new System.Drawing.Size(571, 325);
            this.grdCargue.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 85);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDEnturnador.Properties.Resources.camion6;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestión de camiones";
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(16, 111);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnVerCargue);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.txtBuscarPlaca);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnNuevo);
            this.splitContainer1.Panel1.Controls.Add(this.grdCamiones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureLectora);
            this.splitContainer1.Panel2.Controls.Add(this.txtCodigoRFID);
            this.splitContainer1.Panel2.Controls.Add(this.cboTipoCargue);
            this.splitContainer1.Panel2.Controls.Add(this.txtPlaca);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnListo);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(600, 476);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnVerCargue
            // 
            this.btnVerCargue.Image = global::RFIDEnturnador.Properties.Resources.folder;
            this.btnVerCargue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCargue.Location = new System.Drawing.Point(172, 12);
            this.btnVerCargue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerCargue.Name = "btnVerCargue";
            this.btnVerCargue.Size = new System.Drawing.Size(140, 36);
            this.btnVerCargue.TabIndex = 22;
            this.btnVerCargue.Text = "    Cargar registro";
            this.btnVerCargue.UseVisualStyleBackColor = true;
            this.btnVerCargue.Click += new System.EventHandler(this.btnVerCargue_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::RFIDEnturnador.Properties.Resources.xpLens;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(277, 62);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 30);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarPlaca
            // 
            this.txtBuscarPlaca.Location = new System.Drawing.Point(137, 62);
            this.txtBuscarPlaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarPlaca.Name = "txtBuscarPlaca";
            this.txtBuscarPlaca.Size = new System.Drawing.Size(132, 22);
            this.txtBuscarPlaca.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Buscar por placa:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RFIDEnturnador.Properties.Resources.NewFolder;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(13, 12);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(144, 36);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "  Nuevo camión";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grdCamiones
            // 
            this.grdCamiones.AllowUserToAddRows = false;
            this.grdCamiones.AllowUserToDeleteRows = false;
            this.grdCamiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCamiones.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCamiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PLACA,
            this.IDTIPOCARGUE,
            this.TIPOCARGUE,
            this.EDITAR,
            this.ELIMINAR});
            this.grdCamiones.Location = new System.Drawing.Point(13, 103);
            this.grdCamiones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdCamiones.Name = "grdCamiones";
            this.grdCamiones.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCamiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCamiones.RowHeadersVisible = false;
            this.grdCamiones.RowHeadersWidth = 20;
            this.grdCamiones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grdCamiones.RowTemplate.Height = 24;
            this.grdCamiones.Size = new System.Drawing.Size(571, 357);
            this.grdCamiones.TabIndex = 17;
            this.grdCamiones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCamiones_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // PLACA
            // 
            this.PLACA.DataPropertyName = "placa";
            this.PLACA.FillWeight = 45.16006F;
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            this.PLACA.ReadOnly = true;
            // 
            // IDTIPOCARGUE
            // 
            this.IDTIPOCARGUE.DataPropertyName = "idTipoCargue";
            this.IDTIPOCARGUE.HeaderText = "IDTIPOCARGUE";
            this.IDTIPOCARGUE.Name = "IDTIPOCARGUE";
            this.IDTIPOCARGUE.ReadOnly = true;
            this.IDTIPOCARGUE.Visible = false;
            // 
            // TIPOCARGUE
            // 
            this.TIPOCARGUE.DataPropertyName = "tipoCargue";
            this.TIPOCARGUE.FillWeight = 115.8913F;
            this.TIPOCARGUE.HeaderText = "TIPO DE CARGUE";
            this.TIPOCARGUE.Name = "TIPOCARGUE";
            this.TIPOCARGUE.ReadOnly = true;
            // 
            // EDITAR
            // 
            this.EDITAR.FillWeight = 96.81666F;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = global::RFIDEnturnador.Properties.Resources.editar;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.FillWeight = 142.132F;
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::RFIDEnturnador.Properties.Resources.eliminar;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // pictureLectora
            // 
            this.pictureLectora.Image = global::RFIDEnturnador.Properties.Resources.Ball_green_32;
            this.pictureLectora.Location = new System.Drawing.Point(469, 153);
            this.pictureLectora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureLectora.Name = "pictureLectora";
            this.pictureLectora.Size = new System.Drawing.Size(32, 32);
            this.pictureLectora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLectora.TabIndex = 23;
            this.pictureLectora.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureLectora, "Click sobre esta imagen para leer el código RFID");
            this.pictureLectora.Click += new System.EventHandler(this.pictureLectora_Click);
            // 
            // txtCodigoRFID
            // 
            this.txtCodigoRFID.Location = new System.Drawing.Point(207, 156);
            this.txtCodigoRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoRFID.Name = "txtCodigoRFID";
            this.txtCodigoRFID.ReadOnly = true;
            this.txtCodigoRFID.Size = new System.Drawing.Size(260, 22);
            this.txtCodigoRFID.TabIndex = 22;
            // 
            // cboTipoCargue
            // 
            this.cboTipoCargue.FormattingEnabled = true;
            this.cboTipoCargue.Location = new System.Drawing.Point(207, 114);
            this.cboTipoCargue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoCargue.Name = "cboTipoCargue";
            this.cboTipoCargue.Size = new System.Drawing.Size(260, 24);
            this.cboTipoCargue.TabIndex = 21;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(207, 71);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(260, 22);
            this.txtPlaca.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RFIDEnturnador.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(367, 199);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListo
            // 
            this.btnListo.Image = global::RFIDEnturnador.Properties.Resources.chulo;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(259, 199);
            this.btnListo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(100, 28);
            this.btnListo.TabIndex = 18;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Código RFID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de cargue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Placa:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Camiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 601);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Camiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camiones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camiones_FormClosing);
            this.Load += new System.EventHandler(this.Camiones_Load);
            this.panel1.ResumeLayout(false);
            this.panelCargueMasivo.ResumeLayout(false);
            this.panelCargueMasivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCargue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLectora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.DataGridView grdCamiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTIPOCARGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCARGUE;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtCodigoRFID;
        private System.Windows.Forms.ComboBox cboTipoCargue;
        private System.Windows.Forms.TextBox txtPlaca;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelCargueMasivo;
        private System.Windows.Forms.Label lblCantidadError;
        private System.Windows.Forms.Label lblCantidadGuardada;
        private System.Windows.Forms.Label lblCantidadLeida;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DataGridView grdCargue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnVerCargue;
        internal System.Windows.Forms.Button btnCancelarCarga;
        private System.Windows.Forms.PictureBox pictureLectora;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}