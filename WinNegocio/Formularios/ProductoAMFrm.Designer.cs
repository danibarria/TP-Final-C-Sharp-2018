namespace WinNegocio.Formularios
{
    partial class ProductoAMFrm
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
            this.IdMsk = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProveedorTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdCategoriaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrecioUnitarioTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExistenciaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(129, 43);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(106, 20);
            this.IdMsk.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // IdProveedorTxt
            // 
            this.IdProveedorTxt.Location = new System.Drawing.Point(129, 82);
            this.IdProveedorTxt.Name = "IdProveedorTxt";
            this.IdProveedorTxt.Size = new System.Drawing.Size(143, 20);
            this.IdProveedorTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id Proveedor";
            // 
            // IdCategoriaTxt
            // 
            this.IdCategoriaTxt.Location = new System.Drawing.Point(129, 131);
            this.IdCategoriaTxt.Name = "IdCategoriaTxt";
            this.IdCategoriaTxt.Size = new System.Drawing.Size(143, 20);
            this.IdCategoriaTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Categoria";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(129, 180);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(143, 20);
            this.DescripcionTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            // 
            // PrecioUnitarioTxt
            // 
            this.PrecioUnitarioTxt.Location = new System.Drawing.Point(129, 226);
            this.PrecioUnitarioTxt.Name = "PrecioUnitarioTxt";
            this.PrecioUnitarioTxt.Size = new System.Drawing.Size(143, 20);
            this.PrecioUnitarioTxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio Unitario:";
            // 
            // ExistenciaTxt
            // 
            this.ExistenciaTxt.Location = new System.Drawing.Point(130, 277);
            this.ExistenciaTxt.Name = "ExistenciaTxt";
            this.ExistenciaTxt.Size = new System.Drawing.Size(143, 20);
            this.ExistenciaTxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Existencia:";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(57, 353);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(83, 31);
            this.AceptarBtn.TabIndex = 17;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(200, 353);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(83, 31);
            this.CancelarBtn.TabIndex = 18;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ProductoAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 407);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.ExistenciaTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrecioUnitarioTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdCategoriaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdProveedorTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.label1);
            this.Name = "ProductoAMFrm";
            this.Text = "ProductoAMFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdProveedorTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdCategoriaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecioUnitarioTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExistenciaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}