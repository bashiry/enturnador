namespace RFIDEnturnador.admin
{
    partial class Noticias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoticia = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdNoticias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTICIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNoticias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 70);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestión de noticias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDEnturnador.Properties.Resources.News;
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNoticia);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 188);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear/Editar noticia";
            // 
            // txtNoticia
            // 
            this.txtNoticia.Location = new System.Drawing.Point(16, 28);
            this.txtNoticia.Multiline = true;
            this.txtNoticia.Name = "txtNoticia";
            this.txtNoticia.Size = new System.Drawing.Size(476, 118);
            this.txtNoticia.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::RFIDEnturnador.Properties.Resources.icon_save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(272, 151);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 25);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdNoticias);
            this.groupBox2.Location = new System.Drawing.Point(11, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Noticias actuales";
            // 
            // grdNoticias
            // 
            this.grdNoticias.AllowUserToAddRows = false;
            this.grdNoticias.AllowUserToDeleteRows = false;
            this.grdNoticias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNoticias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNoticias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNoticias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOTICIA,
            this.EDITAR,
            this.ELIMINAR});
            this.grdNoticias.Location = new System.Drawing.Point(17, 19);
            this.grdNoticias.Name = "grdNoticias";
            this.grdNoticias.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNoticias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdNoticias.RowHeadersVisible = false;
            this.grdNoticias.RowHeadersWidth = 20;
            this.grdNoticias.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grdNoticias.RowTemplate.Height = 24;
            this.grdNoticias.Size = new System.Drawing.Size(476, 230);
            this.grdNoticias.TabIndex = 18;
            this.grdNoticias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNoticias_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NOTICIA
            // 
            this.NOTICIA.DataPropertyName = "noticia";
            this.NOTICIA.FillWeight = 45.16006F;
            this.NOTICIA.HeaderText = "NOTICIA";
            this.NOTICIA.Name = "NOTICIA";
            this.NOTICIA.ReadOnly = true;
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
            // btnCancelar
            // 
            this.btnCancelar.Image = global::RFIDEnturnador.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(384, 151);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 25);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Noticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Noticias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noticias";
            this.Load += new System.EventHandler(this.Noticias_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNoticias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNoticia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView grdNoticias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTICIA;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.Button btnCancelar;
    }
}