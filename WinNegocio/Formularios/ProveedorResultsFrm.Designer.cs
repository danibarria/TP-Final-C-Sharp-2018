namespace WinNegocio.Formularios
{
    partial class ProveedorResultsFrm
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
            this.gridProveedor = new System.Windows.Forms.DataGridView();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactoProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CeluProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FijoProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProveedor
            // 
            this.gridProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProv,
            this.ContactoProv,
            this.CeluProv,
            this.FijoProv});
            this.gridProveedor.Location = new System.Drawing.Point(3, 15);
            this.gridProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridProveedor.Name = "gridProveedor";
            this.gridProveedor.ReadOnly = true;
            this.gridProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProveedor.Size = new System.Drawing.Size(833, 389);
            this.gridProveedor.TabIndex = 0;
            this.gridProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProveedor_CellContentClick);
            this.gridProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProveedor_CellDoubleClick);
            this.gridProveedor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridProveedor_DataBindingComplete);
            // 
            // NombreProv
            // 
            this.NombreProv.DataPropertyName = "NombreProveedor";
            this.NombreProv.HeaderText = "Nombre";
            this.NombreProv.Name = "NombreProv";
            this.NombreProv.ReadOnly = true;
            // 
            // ContactoProv
            // 
            this.ContactoProv.DataPropertyName = "ContactoProveedor";
            this.ContactoProv.HeaderText = "Contacto";
            this.ContactoProv.Name = "ContactoProv";
            this.ContactoProv.ReadOnly = true;
            // 
            // CeluProv
            // 
            this.CeluProv.DataPropertyName = "CeluProveedor";
            this.CeluProv.HeaderText = "Celular";
            this.CeluProv.Name = "CeluProv";
            this.CeluProv.ReadOnly = true;
            // 
            // FijoProv
            // 
            this.FijoProv.DataPropertyName = "FijoProveedor";
            this.FijoProv.HeaderText = "Fijo";
            this.FijoProv.Name = "FijoProv";
            this.FijoProv.ReadOnly = true;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(664, 452);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(112, 33);
            this.CerrarBtn.TabIndex = 15;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // ProveedorResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 500);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.gridProveedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProveedorResultsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProveedorResultsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProveedor;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactoProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CeluProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn FijoProv;
    }
}