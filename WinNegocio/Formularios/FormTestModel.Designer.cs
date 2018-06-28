namespace WinNegocio.Formularios
{
    partial class FormTestModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestModel));
            this.CategoriasCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CargarCategoriasBtn = new System.Windows.Forms.Button();
            this.ObraSocialAddBtn = new System.Windows.Forms.Button();
            this.gridProducto = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCombina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargarGrillaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriasCbo
            // 
            this.CategoriasCbo.FormattingEnabled = true;
            this.CategoriasCbo.Location = new System.Drawing.Point(131, 17);
            this.CategoriasCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriasCbo.Name = "CategoriasCbo";
            this.CategoriasCbo.Size = new System.Drawing.Size(211, 24);
            this.CategoriasCbo.TabIndex = 0;
            this.CategoriasCbo.SelectedIndexChanged += new System.EventHandler(this.CategoriasCbo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorias";
            // 
            // CargarCategoriasBtn
            // 
            this.CargarCategoriasBtn.Location = new System.Drawing.Point(351, 15);
            this.CargarCategoriasBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CargarCategoriasBtn.Name = "CargarCategoriasBtn";
            this.CargarCategoriasBtn.Size = new System.Drawing.Size(97, 30);
            this.CargarCategoriasBtn.TabIndex = 2;
            this.CargarCategoriasBtn.Text = "Cargar";
            this.CargarCategoriasBtn.UseVisualStyleBackColor = true;
            this.CargarCategoriasBtn.Click += new System.EventHandler(this.CargarCategoriasBtn_Click);
            // 
            // ObraSocialAddBtn
            // 
            this.ObraSocialAddBtn.Location = new System.Drawing.Point(16, 90);
            this.ObraSocialAddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ObraSocialAddBtn.Name = "ObraSocialAddBtn";
            this.ObraSocialAddBtn.Size = new System.Drawing.Size(148, 48);
            this.ObraSocialAddBtn.TabIndex = 3;
            this.ObraSocialAddBtn.Text = "Prueba de Ingreso de Obj";
            this.ObraSocialAddBtn.UseVisualStyleBackColor = true;
            this.ObraSocialAddBtn.Click += new System.EventHandler(this.CategoriaAddBtn_Click);
            // 
            // gridProducto
            // 
            this.gridProducto.AllowUserToAddRows = false;
            this.gridProducto.AllowUserToDeleteRows = false;
            this.gridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Descripcion,
            this.Categoria,
            this.Proveedor,
            this.Precio,
            this.Existencia,
            this.ColCombina});
            this.gridProducto.Location = new System.Drawing.Point(172, 128);
            this.gridProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridProducto.Name = "gridProducto";
            this.gridProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducto.Size = new System.Drawing.Size(877, 155);
            this.gridProducto.TabIndex = 4;
            this.gridProducto.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridProducto_DataBindingComplete);
            // 
            // ProductoId
            // 
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "Id";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioUnitario";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 70;
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "Existencia";
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.Width = 70;
            // 
            // ColCombina
            // 
            this.ColCombina.HeaderText = "ColCombina";
            this.ColCombina.Name = "ColCombina";
            // 
            // CargarGrillaBtn
            // 
            this.CargarGrillaBtn.Location = new System.Drawing.Point(660, 75);
            this.CargarGrillaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CargarGrillaBtn.Name = "CargarGrillaBtn";
            this.CargarGrillaBtn.Size = new System.Drawing.Size(160, 46);
            this.CargarGrillaBtn.TabIndex = 5;
            this.CargarGrillaBtn.Text = "Cargar";
            this.CargarGrillaBtn.UseVisualStyleBackColor = true;
            this.CargarGrillaBtn.Click += new System.EventHandler(this.CargarGrillaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grilla de  ejemplo";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(404, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(599, 79);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // FormTestModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CargarGrillaBtn);
            this.Controls.Add(this.gridProducto);
            this.Controls.Add(this.ObraSocialAddBtn);
            this.Controls.Add(this.CargarCategoriasBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriasCbo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTestModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTestModel";
            this.Load += new System.EventHandler(this.FormTestModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriasCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CargarCategoriasBtn;
        private System.Windows.Forms.Button ObraSocialAddBtn;
        private System.Windows.Forms.DataGridView gridProducto;
        private System.Windows.Forms.Button CargarGrillaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCombina;
    }
}