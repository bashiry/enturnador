namespace RFIDEnturnador
{
    partial class Login
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
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Image = global::RFIDEnturnador.Properties.Resources.cancelar;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(343, 164);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(115, 30);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "   &Cancelar";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Image = global::RFIDEnturnador.Properties.Resources.chulo;
            this.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK.Location = new System.Drawing.Point(220, 164);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(115, 30);
            this.OK.TabIndex = 11;
            this.OK.Text = "   &Ingresar";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(219, 110);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(237, 22);
            this.txtClave.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(219, 39);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 22);
            this.txtUsuario.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(216, 85);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(293, 28);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Clave";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(216, 15);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(293, 28);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Usuario";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::RFIDEnturnador.Properties.Resources._lock;
            this.LogoPictureBox.Location = new System.Drawing.Point(16, 15);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(175, 178);
            this.LogoPictureBox.TabIndex = 7;
            this.LogoPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 229);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
    }
}