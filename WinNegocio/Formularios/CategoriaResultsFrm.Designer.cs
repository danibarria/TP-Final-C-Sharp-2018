namespace WinNegocio.Formularios
{
    partial class CategoriaResultsFrm
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
            this.gridCategoria = new System.Windows.Forms.DataGridView();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCategoria
            // 
            this.gridCategoria.AllowUserToDeleteRows = false;
            this.gridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCategoria});
            this.gridCategoria.Location = new System.Drawing.Point(46, 40);
            this.gridCategoria.Name = "gridCategoria";
            this.gridCategoria.RowTemplate.Height = 24;
            this.gridCategoria.Size = new System.Drawing.Size(389, 438);
            this.gridCategoria.TabIndex = 0;
            this.gridCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.DataPropertyName = "NombreCategoria";
            this.NombreCategoria.HeaderText = "Nombre";
            this.NombreCategoria.Name = "NombreCategoria";
            // 
            // CategoriaResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 490);
            this.Controls.Add(this.gridCategoria);
            this.Name = "CategoriaResultsFrm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
    }
}