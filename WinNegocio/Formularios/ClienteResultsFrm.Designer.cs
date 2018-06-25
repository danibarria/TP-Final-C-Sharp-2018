namespace WinNegocio.Formularios
{
    partial class ClientesResultsFrm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.CedulaRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CedulaRuc,
            this.NombreCia,
            this.Columna});
            this.gridClientes.Location = new System.Drawing.Point(2, 12);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(625, 316);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick_1);
            this.gridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellDoubleClick);
            this.gridClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridClientes_DataBindingComplete_1);
            // 
            // CedulaRuc
            // 
            this.CedulaRuc.DataPropertyName = "CedulaRuc";
            this.CedulaRuc.HeaderText = "Cedula";
            this.CedulaRuc.Name = "CedulaRuc";
            this.CedulaRuc.ReadOnly = true;
            // 
            // NombreCia
            // 
            this.NombreCia.DataPropertyName = "NombreCia";
            this.NombreCia.HeaderText = "Nombre Cia";
            this.NombreCia.Name = "NombreCia";
            this.NombreCia.ReadOnly = true;
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(498, 367);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(84, 27);
            this.CerrarBtn.TabIndex = 14;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // ClientesResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 406);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.gridClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesResultsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ClientesResultsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
    }
}