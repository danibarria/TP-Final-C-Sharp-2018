namespace WinNegocio.Formularios
{
    partial class OrdenResultsFrm
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
            this.gridOrden = new System.Windows.Forms.DataGridView();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrden
            // 
            this.gridOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden,
            this.Empleado,
            this.Cliente,
            this.FechaOrden,
            this.Descuento});
            this.gridOrden.Location = new System.Drawing.Point(16, 15);
            this.gridOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridOrden.Name = "gridOrden";
            this.gridOrden.ReadOnly = true;
            this.gridOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrden.Size = new System.Drawing.Size(731, 389);
            this.gridOrden.TabIndex = 0;
            this.gridOrden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrden_CellDoubleClick);
            this.gridOrden.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridOrden_DataBindingComplete);
            // 
            // Orden
            // 
            this.Orden.DataPropertyName = "OrdenId";
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // FechaOrden
            // 
            this.FechaOrden.DataPropertyName = "FechaOrden";
            this.FechaOrden.HeaderText = "Fecha";
            this.FechaOrden.Name = "FechaOrden";
            this.FechaOrden.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(635, 452);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(112, 33);
            this.CerrarBtn.TabIndex = 15;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // OrdenResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 500);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.gridOrden);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdenResultsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenResultsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrden;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
    }
}