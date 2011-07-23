﻿namespace RFIDEnturnador
{
    partial class Principal
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnEnturnar = new System.Windows.Forms.Button();
            this.btnAdminReaders = new System.Windows.Forms.Button();
            this.btnAdminUsuarios = new System.Windows.Forms.Button();
            this.btnAdminNoticia = new System.Windows.Forms.Button();
            this.btnAdminCamiones = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPrincipal.Controls.Add(this.lblUsuario);
            this.panelPrincipal.Controls.Add(this.pictureBox4);
            this.panelPrincipal.Controls.Add(this.btnMonitor);
            this.panelPrincipal.Controls.Add(this.btnEnturnar);
            this.panelPrincipal.Controls.Add(this.btnAdminReaders);
            this.panelPrincipal.Controls.Add(this.btnAdminUsuarios);
            this.panelPrincipal.Controls.Add(this.btnAdminNoticia);
            this.panelPrincipal.Controls.Add(this.btnAdminCamiones);
            this.panelPrincipal.Controls.Add(this.panelLeft);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1085, 558);
            this.panelPrincipal.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(537, 7);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 20);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RFIDEnturnador.Properties.Resources.workerS;
            this.pictureBox4.Location = new System.Drawing.Point(497, 1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btnMonitor
            // 
            this.btnMonitor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor.Image = global::RFIDEnturnador.Properties.Resources.monitor;
            this.btnMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitor.Location = new System.Drawing.Point(776, 239);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(261, 68);
            this.btnMonitor.TabIndex = 6;
            this.btnMonitor.Text = "  Ver colas";
            this.btnMonitor.UseVisualStyleBackColor = true;
            // 
            // btnEnturnar
            // 
            this.btnEnturnar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnturnar.Image = global::RFIDEnturnador.Properties.Resources.enturnar;
            this.btnEnturnar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnturnar.Location = new System.Drawing.Point(497, 239);
            this.btnEnturnar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnturnar.Name = "btnEnturnar";
            this.btnEnturnar.Size = new System.Drawing.Size(261, 68);
            this.btnEnturnar.TabIndex = 5;
            this.btnEnturnar.Text = "Enturnar/Desenturnar";
            this.btnEnturnar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnturnar.UseVisualStyleBackColor = true;
            this.btnEnturnar.Click += new System.EventHandler(this.btnEnturnar_Click);
            // 
            // btnAdminReaders
            // 
            this.btnAdminReaders.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReaders.Image = global::RFIDEnturnador.Properties.Resources.antenna;
            this.btnAdminReaders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminReaders.Location = new System.Drawing.Point(776, 151);
            this.btnAdminReaders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminReaders.Name = "btnAdminReaders";
            this.btnAdminReaders.Size = new System.Drawing.Size(261, 68);
            this.btnAdminReaders.TabIndex = 4;
            this.btnAdminReaders.Text = "Readers";
            this.btnAdminReaders.UseVisualStyleBackColor = true;
            // 
            // btnAdminUsuarios
            // 
            this.btnAdminUsuarios.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuarios.Image = global::RFIDEnturnador.Properties.Resources.Login_Manager;
            this.btnAdminUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUsuarios.Location = new System.Drawing.Point(497, 64);
            this.btnAdminUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUsuarios.Name = "btnAdminUsuarios";
            this.btnAdminUsuarios.Size = new System.Drawing.Size(261, 68);
            this.btnAdminUsuarios.TabIndex = 3;
            this.btnAdminUsuarios.Text = "Usuarios";
            this.btnAdminUsuarios.UseVisualStyleBackColor = true;
            this.btnAdminUsuarios.Click += new System.EventHandler(this.btnAdminUsuarios_Click);
            // 
            // btnAdminNoticia
            // 
            this.btnAdminNoticia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminNoticia.Image = global::RFIDEnturnador.Properties.Resources.News;
            this.btnAdminNoticia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminNoticia.Location = new System.Drawing.Point(497, 151);
            this.btnAdminNoticia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminNoticia.Name = "btnAdminNoticia";
            this.btnAdminNoticia.Size = new System.Drawing.Size(261, 68);
            this.btnAdminNoticia.TabIndex = 2;
            this.btnAdminNoticia.Text = "Noticias";
            this.btnAdminNoticia.UseVisualStyleBackColor = true;
            this.btnAdminNoticia.Click += new System.EventHandler(this.btnAdminNoticia_Click);
            // 
            // btnAdminCamiones
            // 
            this.btnAdminCamiones.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCamiones.Image = global::RFIDEnturnador.Properties.Resources.camion6;
            this.btnAdminCamiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminCamiones.Location = new System.Drawing.Point(776, 64);
            this.btnAdminCamiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminCamiones.Name = "btnAdminCamiones";
            this.btnAdminCamiones.Size = new System.Drawing.Size(261, 68);
            this.btnAdminCamiones.TabIndex = 1;
            this.btnAdminCamiones.Text = "                Camiones";
            this.btnAdminCamiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminCamiones.UseVisualStyleBackColor = true;
            this.btnAdminCamiones.Click += new System.EventHandler(this.btnAdminCamiones_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.pictureBox3);
            this.panelLeft.Controls.Add(this.pictureBox2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(440, 558);
            this.panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enturnador de camiones RFID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDEnturnador.Properties.Resources.logoExxon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 512);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RFIDEnturnador.Properties.Resources.Principal;
            this.pictureBox3.Location = new System.Drawing.Point(19, 68);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(391, 334);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RFIDEnturnador.Properties.Resources.logoADT;
            this.pictureBox2.Location = new System.Drawing.Point(19, 423);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1085, 558);
            this.Controls.Add(this.panelPrincipal);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID Enturnador de camiones";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminCamiones;
        private System.Windows.Forms.Button btnAdminNoticia;
        private System.Windows.Forms.Button btnAdminReaders;
        private System.Windows.Forms.Button btnAdminUsuarios;
        private System.Windows.Forms.Button btnEnturnar;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblUsuario;
    }
}