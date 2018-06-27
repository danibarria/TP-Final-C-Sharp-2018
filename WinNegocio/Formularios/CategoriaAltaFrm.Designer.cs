namespace WinNegocio.Formularios
{
    partial class CategoriaAltaFrm
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
            this.agregarCategoria = new System.Windows.Forms.Label();
            this.AltaCategoria = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarCategoria
            // 
            this.agregarCategoria.AutoSize = true;
            this.agregarCategoria.Location = new System.Drawing.Point(116, 48);
            this.agregarCategoria.Name = "agregarCategoria";
            this.agregarCategoria.Size = new System.Drawing.Size(143, 17);
            this.agregarCategoria.TabIndex = 0;
            this.agregarCategoria.Text = "Nombre de Categoria";
            this.agregarCategoria.Click += new System.EventHandler(this.agregarCategoria_Click);
            // 
            // AltaCategoria
            // 
            this.AltaCategoria.Location = new System.Drawing.Point(66, 77);
            this.AltaCategoria.Name = "AltaCategoria";
            this.AltaCategoria.Size = new System.Drawing.Size(262, 22);
            this.AltaCategoria.TabIndex = 1;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(146, 113);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(79, 23);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click_1);
            // 
            // CategoriaAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 198);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.AltaCategoria);
            this.Controls.Add(this.agregarCategoria);
            this.Name = "CategoriaAMFrm";
            this.Text = "Alta Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label agregarCategoria;
        private System.Windows.Forms.TextBox AltaCategoria;
        private System.Windows.Forms.Button Guardar;
    }
}