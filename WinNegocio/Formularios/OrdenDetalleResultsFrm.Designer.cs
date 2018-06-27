namespace WinNegocio.Formularios
{
    partial class OrdenDetalleResultsFrm
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
            this.gridDetalleOrden = new System.Windows.Forms.DataGridView();
            this.Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.ModOrdenBtn = new System.Windows.Forms.Button();
            this.AltaDetalleOrdenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDetalleOrden
            // 
            this.gridDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Renglon,
            this.Producto,
            this.Cantidad});
            this.gridDetalleOrden.Location = new System.Drawing.Point(12, 12);
            this.gridDetalleOrden.Name = "gridDetalleOrden";
            this.gridDetalleOrden.ReadOnly = true;
            this.gridDetalleOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalleOrden.Size = new System.Drawing.Size(548, 316);
            this.gridDetalleOrden.TabIndex = 0;
            this.gridDetalleOrden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalleOrden_CellDoubleClick);
            this.gridDetalleOrden.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridOrden_DataBindingComplete);
            // 
            // Renglon
            // 
            this.Renglon.DataPropertyName = "DetalleId";
            this.Renglon.HeaderText = "Renglon";
            this.Renglon.Name = "Renglon";
            this.Renglon.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(476, 367);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(84, 27);
            this.CerrarBtn.TabIndex = 16;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // ModOrdenBtn
            // 
            this.ModOrdenBtn.Location = new System.Drawing.Point(352, 367);
            this.ModOrdenBtn.Name = "ModOrdenBtn";
            this.ModOrdenBtn.Size = new System.Drawing.Size(102, 27);
            this.ModOrdenBtn.TabIndex = 17;
            this.ModOrdenBtn.Text = "ModificarOrden";
            this.ModOrdenBtn.UseVisualStyleBackColor = true;
            this.ModOrdenBtn.Click += new System.EventHandler(this.ModOrdenBtn_Click);
            // 
            // AltaDetalleOrdenBtn
            // 
            this.AltaDetalleOrdenBtn.Location = new System.Drawing.Point(224, 367);
            this.AltaDetalleOrdenBtn.Name = "AltaDetalleOrdenBtn";
            this.AltaDetalleOrdenBtn.Size = new System.Drawing.Size(111, 27);
            this.AltaDetalleOrdenBtn.TabIndex = 18;
            this.AltaDetalleOrdenBtn.Text = "AltaDetalleOrden";
            this.AltaDetalleOrdenBtn.UseVisualStyleBackColor = true;
            this.AltaDetalleOrdenBtn.Click += new System.EventHandler(this.AltaDetalleOrdenBtn_Click);
            // 
            // OrdenDetalleResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 406);
            this.Controls.Add(this.AltaDetalleOrdenBtn);
            this.Controls.Add(this.ModOrdenBtn);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.gridDetalleOrden);
            this.Name = "OrdenDetalleResultsFrm";
            this.Text = "OrdenDetalleResultsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDetalleOrden;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button ModOrdenBtn;
        private System.Windows.Forms.Button AltaDetalleOrdenBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}