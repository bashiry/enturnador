namespace RFIDEnturnador.admin
{
    partial class TurnoManual
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.rbtnEnturnar = new System.Windows.Forms.RadioButton();
            this.rbtnDesenturnar = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(455, 70);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDEnturnador.Properties.Resources.enturnar;
            this.pictureBox1.Location = new System.Drawing.Point(9, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enturnar / Desenturnar manualmente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(154, 224);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(184, 80);
            this.txtObservaciones.TabIndex = 13;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(154, 143);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(184, 20);
            this.txtPlaca.TabIndex = 14;
            // 
            // numHora
            // 
            this.numHora.Location = new System.Drawing.Point(154, 183);
            this.numHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(53, 20);
            this.numHora.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Minutos:";
            // 
            // numMinutos
            // 
            this.numMinutos.Location = new System.Drawing.Point(286, 183);
            this.numMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(53, 20);
            this.numMinutos.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RFIDEnturnador.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(263, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListo
            // 
            this.btnListo.Image = global::RFIDEnturnador.Properties.Resources.chulo;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(182, 320);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(75, 23);
            this.btnListo.TabIndex = 20;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // rbtnEnturnar
            // 
            this.rbtnEnturnar.AutoSize = true;
            this.rbtnEnturnar.Checked = true;
            this.rbtnEnturnar.Location = new System.Drawing.Point(154, 84);
            this.rbtnEnturnar.Name = "rbtnEnturnar";
            this.rbtnEnturnar.Size = new System.Drawing.Size(65, 17);
            this.rbtnEnturnar.TabIndex = 22;
            this.rbtnEnturnar.TabStop = true;
            this.rbtnEnturnar.Text = "Enturnar";
            this.rbtnEnturnar.UseVisualStyleBackColor = true;
            // 
            // rbtnDesenturnar
            // 
            this.rbtnDesenturnar.AutoSize = true;
            this.rbtnDesenturnar.Location = new System.Drawing.Point(154, 110);
            this.rbtnDesenturnar.Name = "rbtnDesenturnar";
            this.rbtnDesenturnar.Size = new System.Drawing.Size(83, 17);
            this.rbtnDesenturnar.TabIndex = 23;
            this.rbtnDesenturnar.Text = "Desenturnar";
            this.rbtnDesenturnar.UseVisualStyleBackColor = true;
            // 
            // TurnoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 366);
            this.Controls.Add(this.rbtnDesenturnar);
            this.Controls.Add(this.rbtnEnturnar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.numMinutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numHora);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TurnoManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enturnar / Desenturnar";
            this.Load += new System.EventHandler(this.TurnoManual_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.NumericUpDown numHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMinutos;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.RadioButton rbtnEnturnar;
        private System.Windows.Forms.RadioButton rbtnDesenturnar;
    }
}