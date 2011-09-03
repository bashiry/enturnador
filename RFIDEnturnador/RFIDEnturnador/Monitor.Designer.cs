namespace RFIDEnturnador
{
    partial class Monitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoCargue = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGrillas = new System.Windows.Forms.Panel();
            this.lblPag2 = new System.Windows.Forms.Label();
            this.lblPag1 = new System.Windows.Forms.Label();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNoticias = new System.Windows.Forms.Panel();
            this.txtNoticias = new System.Windows.Forms.TextBox();
            this.panelInfoSuperior = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLista = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGrillas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            this.panelNoticias.SuspendLayout();
            this.panelInfoSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 118);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(309, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turnos de entrada";
            // 
            // lblTipoCargue
            // 
            this.lblTipoCargue.AutoSize = true;
            this.lblTipoCargue.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCargue.Location = new System.Drawing.Point(33, 14);
            this.lblTipoCargue.Name = "lblTipoCargue";
            this.lblTipoCargue.Size = new System.Drawing.Size(320, 46);
            this.lblTipoCargue.TabIndex = 8;
            this.lblTipoCargue.Text = "Tipo de Cargue:";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(713, 14);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(125, 46);
            this.lblHoraActual.TabIndex = 9;
            this.lblHoraActual.Text = "Hora:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelGrillas);
            this.panel1.Controls.Add(this.panelNoticias);
            this.panel1.Controls.Add(this.panelInfoSuperior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 763);
            this.panel1.TabIndex = 8;
            // 
            // panelGrillas
            // 
            this.panelGrillas.Controls.Add(this.lblPag2);
            this.panelGrillas.Controls.Add(this.lblPag1);
            this.panelGrillas.Controls.Add(this.grd1);
            this.panelGrillas.Controls.Add(this.grd2);
            this.panelGrillas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrillas.Location = new System.Drawing.Point(0, 70);
            this.panelGrillas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGrillas.Name = "panelGrillas";
            this.panelGrillas.Size = new System.Drawing.Size(1181, 577);
            this.panelGrillas.TabIndex = 23;
            // 
            // lblPag2
            // 
            this.lblPag2.AutoSize = true;
            this.lblPag2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag2.Location = new System.Drawing.Point(585, 4);
            this.lblPag2.Name = "lblPag2";
            this.lblPag2.Size = new System.Drawing.Size(93, 46);
            this.lblPag2.TabIndex = 21;
            this.lblPag2.Text = "Pág";
            // 
            // lblPag1
            // 
            this.lblPag1.AutoSize = true;
            this.lblPag1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag1.Location = new System.Drawing.Point(33, 4);
            this.lblPag1.Name = "lblPag1";
            this.lblPag1.Size = new System.Drawing.Size(93, 46);
            this.lblPag1.TabIndex = 20;
            this.lblPag1.Text = "Pág";
            // 
            // grd1
            // 
            this.grd1.AllowUserToAddRows = false;
            this.grd1.AllowUserToDeleteRows = false;
            this.grd1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.PLACA,
            this.HORA});
            this.grd1.Location = new System.Drawing.Point(43, 92);
            this.grd1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grd1.Name = "grd1";
            this.grd1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd1.RowHeadersVisible = false;
            this.grd1.RowHeadersWidth = 20;
            this.grd1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FloralWhite;
            this.grd1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd1.RowTemplate.Height = 42;
            this.grd1.Size = new System.Drawing.Size(500, 450);
            this.grd1.TabIndex = 18;
            // 
            // NO
            // 
            this.NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NO.DataPropertyName = "no";
            this.NO.FillWeight = 37.33403F;
            this.NO.HeaderText = "No.";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            // 
            // PLACA
            // 
            this.PLACA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLACA.DataPropertyName = "placa";
            this.PLACA.FillWeight = 110.6567F;
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            this.PLACA.ReadOnly = true;
            // 
            // HORA
            // 
            this.HORA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HORA.DataPropertyName = "hora";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.HORA.DefaultCellStyle = dataGridViewCellStyle2;
            this.HORA.FillWeight = 97.16941F;
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            this.HORA.ReadOnly = true;
            // 
            // grd2
            // 
            this.grd2.AllowUserToAddRows = false;
            this.grd2.AllowUserToDeleteRows = false;
            this.grd2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.grd2.Location = new System.Drawing.Point(595, 92);
            this.grd2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grd2.Name = "grd2";
            this.grd2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grd2.RowHeadersVisible = false;
            this.grd2.RowHeadersWidth = 20;
            this.grd2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FloralWhite;
            this.grd2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd2.RowTemplate.Height = 42;
            this.grd2.Size = new System.Drawing.Size(500, 450);
            this.grd2.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no";
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "placa";
            this.dataGridViewTextBoxColumn2.FillWeight = 45.16006F;
            this.dataGridViewTextBoxColumn2.HeaderText = "PLACA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hora";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "t";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "HORA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // panelNoticias
            // 
            this.panelNoticias.Controls.Add(this.txtNoticias);
            this.panelNoticias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNoticias.Location = new System.Drawing.Point(0, 647);
            this.panelNoticias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNoticias.Name = "panelNoticias";
            this.panelNoticias.Size = new System.Drawing.Size(1181, 116);
            this.panelNoticias.TabIndex = 22;
            // 
            // txtNoticias
            // 
            this.txtNoticias.BackColor = System.Drawing.Color.White;
            this.txtNoticias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoticias.Font = new System.Drawing.Font("Arial", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoticias.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtNoticias.Location = new System.Drawing.Point(0, 0);
            this.txtNoticias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoticias.Name = "txtNoticias";
            this.txtNoticias.ReadOnly = true;
            this.txtNoticias.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNoticias.Size = new System.Drawing.Size(1181, 92);
            this.txtNoticias.TabIndex = 20;
            // 
            // panelInfoSuperior
            // 
            this.panelInfoSuperior.Controls.Add(this.lblTipoCargue);
            this.panelInfoSuperior.Controls.Add(this.lblHoraActual);
            this.panelInfoSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelInfoSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfoSuperior.Name = "panelInfoSuperior";
            this.panelInfoSuperior.Size = new System.Drawing.Size(1181, 70);
            this.panelInfoSuperior.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLista
            // 
            this.timerLista.Tick += new System.EventHandler(this.timerLista_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RFIDEnturnador.Properties.Resources.camionCisterna;
            this.pictureBox2.Location = new System.Drawing.Point(167, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDEnturnador.Properties.Resources.camionCisterna;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de ingreso";
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGrillas.ResumeLayout(false);
            this.panelGrillas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            this.panelNoticias.ResumeLayout(false);
            this.panelNoticias.PerformLayout();
            this.panelInfoSuperior.ResumeLayout(false);
            this.panelInfoSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTipoCargue;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView grd2;
        internal System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.TextBox txtNoticias;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerLista;
        private System.Windows.Forms.Panel panelNoticias;
        private System.Windows.Forms.Panel panelInfoSuperior;
        private System.Windows.Forms.Panel panelGrillas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblPag2;
        private System.Windows.Forms.Label lblPag1;
    }
}