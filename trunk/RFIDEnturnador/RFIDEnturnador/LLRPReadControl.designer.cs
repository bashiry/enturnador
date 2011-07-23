namespace RFIDEnturnador.llrp
{
    partial class LLRPReadControl
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTags = new System.Windows.Forms.DataGridView();
            this.tagReportDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAntennaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEpcDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ipReaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butClear = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTags
            // 
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagReportDataDataGridViewTextBoxColumn,
            this.idAntennaDataGridViewTextBoxColumn,
            this.isEpcDataGridViewCheckBoxColumn,
            this.ipReaderDataGridViewTextBoxColumn,
            this.epcDataGridViewTextBoxColumn});
            this.dgvTags.Location = new System.Drawing.Point(18, 17);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.Size = new System.Drawing.Size(615, 396);
            this.dgvTags.TabIndex = 0;
            // 
            // tagReportDataDataGridViewTextBoxColumn
            // 
            this.tagReportDataDataGridViewTextBoxColumn.DataPropertyName = "TagReportData";
            this.tagReportDataDataGridViewTextBoxColumn.HeaderText = "TagReportData";
            this.tagReportDataDataGridViewTextBoxColumn.Name = "tagReportDataDataGridViewTextBoxColumn";
            // 
            // idAntennaDataGridViewTextBoxColumn
            // 
            this.idAntennaDataGridViewTextBoxColumn.DataPropertyName = "IdAntenna";
            this.idAntennaDataGridViewTextBoxColumn.HeaderText = "IdAntenna";
            this.idAntennaDataGridViewTextBoxColumn.Name = "idAntennaDataGridViewTextBoxColumn";
            // 
            // isEpcDataGridViewCheckBoxColumn
            // 
            this.isEpcDataGridViewCheckBoxColumn.DataPropertyName = "IsEpc";
            this.isEpcDataGridViewCheckBoxColumn.HeaderText = "IsEpc";
            this.isEpcDataGridViewCheckBoxColumn.Name = "isEpcDataGridViewCheckBoxColumn";
            // 
            // ipReaderDataGridViewTextBoxColumn
            // 
            this.ipReaderDataGridViewTextBoxColumn.DataPropertyName = "IpReader";
            this.ipReaderDataGridViewTextBoxColumn.HeaderText = "IpReader";
            this.ipReaderDataGridViewTextBoxColumn.Name = "ipReaderDataGridViewTextBoxColumn";
            // 
            // epcDataGridViewTextBoxColumn
            // 
            this.epcDataGridViewTextBoxColumn.DataPropertyName = "Epc";
            this.epcDataGridViewTextBoxColumn.HeaderText = "Epc";
            this.epcDataGridViewTextBoxColumn.Name = "epcDataGridViewTextBoxColumn";
            // 
            // butClear
            // 
            this.butClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(163, 432);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(456, 31);
            this.butClear.TabIndex = 2;
            this.butClear.Text = "L I M P I A R";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(18, 416);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(69, 73);
            this.lblcount.TabIndex = 1;
            this.lblcount.Text = "0";
            // 
            // LLRPReadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTags);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.butClear);
            this.Name = "LLRPReadControl";
            this.Size = new System.Drawing.Size(642, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagReportDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAntennaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEpcDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipReaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Label lblcount;
    }
}
