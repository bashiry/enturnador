namespace RFIDEnturnador.reportes
{
    partial class ReporteTrazabilidad
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListo = new System.Windows.Forms.Button();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTipoCargue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numMinutosFinal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numHoraFinal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numMinutosInicial = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numHoraInicial = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCARGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutosFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutosInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInicial)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 85);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDEnturnador.Properties.Resources.trazabilidad;
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
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reporte de trazabilidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListo);
            this.groupBox1.Controls.Add(this.txtPlacas);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboTipoCargue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numMinutosFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numHoraFinal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateFechaFinal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numMinutosInicial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numHoraInicial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateFechaInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de búsqueda";
            // 
            // btnListo
            // 
            this.btnListo.Image = global::RFIDEnturnador.Properties.Resources.chulo;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(602, 168);
            this.btnListo.Margin = new System.Windows.Forms.Padding(4);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(100, 28);
            this.btnListo.TabIndex = 31;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(222, 139);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(469, 22);
            this.txtPlacas.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Placas (separadas por coma):";
            // 
            // cboTipoCargue
            // 
            this.cboTipoCargue.FormattingEnabled = true;
            this.cboTipoCargue.Location = new System.Drawing.Point(132, 103);
            this.cboTipoCargue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoCargue.Name = "cboTipoCargue";
            this.cboTipoCargue.Size = new System.Drawing.Size(264, 24);
            this.cboTipoCargue.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tipo de cargue:";
            // 
            // numMinutosFinal
            // 
            this.numMinutosFinal.Location = new System.Drawing.Point(620, 70);
            this.numMinutosFinal.Margin = new System.Windows.Forms.Padding(4);
            this.numMinutosFinal.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutosFinal.Name = "numMinutosFinal";
            this.numMinutosFinal.Size = new System.Drawing.Size(71, 22);
            this.numMinutosFinal.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = ":";
            // 
            // numHoraFinal
            // 
            this.numHoraFinal.Location = new System.Drawing.Point(521, 69);
            this.numHoraFinal.Margin = new System.Windows.Forms.Padding(4);
            this.numHoraFinal.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoraFinal.Name = "numHoraFinal";
            this.numHoraFinal.Size = new System.Drawing.Size(71, 22);
            this.numHoraFinal.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hora final:";
            // 
            // dateFechaFinal
            // 
            this.dateFechaFinal.Location = new System.Drawing.Point(132, 70);
            this.dateFechaFinal.Name = "dateFechaFinal";
            this.dateFechaFinal.Size = new System.Drawing.Size(264, 22);
            this.dateFechaFinal.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha final:";
            // 
            // numMinutosInicial
            // 
            this.numMinutosInicial.Location = new System.Drawing.Point(620, 35);
            this.numMinutosInicial.Margin = new System.Windows.Forms.Padding(4);
            this.numMinutosInicial.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutosInicial.Name = "numMinutosInicial";
            this.numMinutosInicial.Size = new System.Drawing.Size(71, 22);
            this.numMinutosInicial.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = ":";
            // 
            // numHoraInicial
            // 
            this.numHoraInicial.Location = new System.Drawing.Point(521, 34);
            this.numHoraInicial.Margin = new System.Windows.Forms.Padding(4);
            this.numHoraInicial.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoraInicial.Name = "numHoraInicial";
            this.numHoraInicial.Size = new System.Drawing.Size(71, 22);
            this.numHoraInicial.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hora inicial:";
            // 
            // dateFechaInicial
            // 
            this.dateFechaInicial.Location = new System.Drawing.Point(132, 32);
            this.dateFechaInicial.Name = "dateFechaInicial";
            this.dateFechaInicial.Size = new System.Drawing.Size(264, 22);
            this.dateFechaInicial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha inicial:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grd);
            this.groupBox2.Controls.Add(this.btnExportar);
            this.groupBox2.Location = new System.Drawing.Point(14, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 431);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PLACA,
            this.TIPOCARGUE,
            this.FECHA,
            this.PUERTA});
            this.grd.Location = new System.Drawing.Point(21, 58);
            this.grd.Margin = new System.Windows.Forms.Padding(4);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd.RowHeadersVisible = false;
            this.grd.RowHeadersWidth = 20;
            this.grd.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grd.RowTemplate.Height = 24;
            this.grd.Size = new System.Drawing.Size(681, 357);
            this.grd.TabIndex = 33;
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::RFIDEnturnador.Properties.Resources.Excel_icon;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(602, 22);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 28);
            this.btnExportar.TabIndex = 32;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // PLACA
            // 
            this.PLACA.DataPropertyName = "placa";
            this.PLACA.FillWeight = 45.16006F;
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            this.PLACA.ReadOnly = true;
            // 
            // TIPOCARGUE
            // 
            this.TIPOCARGUE.DataPropertyName = "tipoCargue";
            this.TIPOCARGUE.FillWeight = 115.8913F;
            this.TIPOCARGUE.HeaderText = "TIPO DE CARGUE";
            this.TIPOCARGUE.Name = "TIPOCARGUE";
            this.TIPOCARGUE.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "hora";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // PUERTA
            // 
            this.PUERTA.DataPropertyName = "puerta";
            this.PUERTA.HeaderText = "PTO. SENSADO";
            this.PUERTA.Name = "PUERTA";
            this.PUERTA.ReadOnly = true;
            // 
            // ReporteTrazabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 766);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReporteTrazabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Trazabilidad";
            this.Load += new System.EventHandler(this.ReporteTrazabilidad_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutosFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutosInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInicial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMinutosFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHoraFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFechaFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMinutosInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numHoraInicial;
        private System.Windows.Forms.ComboBox cboTipoCargue;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnExportar;
        internal System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCARGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUERTA;
    }
}