﻿namespace WinNegocio.Formularios
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
            this.IdProveedor = new System.Windows.Forms.Label();
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
            this.ProveedorCbo = new System.Windows.Forms.ComboBox();
            this.CategoriaCbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(229, 65);
            this.IdMsk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(140, 22);
            this.IdMsk.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // IdProveedorTxt
            // 
            this.IdProveedorTxt.Enabled = false;
            this.IdProveedorTxt.Location = new System.Drawing.Point(229, 124);
            this.IdProveedorTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IdProveedorTxt.Name = "IdProveedorTxt";
            this.IdProveedorTxt.Size = new System.Drawing.Size(189, 22);
            this.IdProveedorTxt.TabIndex = 7;
            // 
            // IdProveedor
            // 
            this.IdProveedor.AutoSize = true;
            this.IdProveedor.Location = new System.Drawing.Point(28, 124);
            this.IdProveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.Size = new System.Drawing.Size(89, 17);
            this.IdProveedor.TabIndex = 6;
            this.IdProveedor.Text = "Id Proveedor";
            // 
            // IdCategoriaTxt
            // 
            this.IdCategoriaTxt.Enabled = false;
            this.IdCategoriaTxt.Location = new System.Drawing.Point(229, 198);
            this.IdCategoriaTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IdCategoriaTxt.Name = "IdCategoriaTxt";
            this.IdCategoriaTxt.Size = new System.Drawing.Size(189, 22);
            this.IdCategoriaTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Categoria";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(229, 273);
            this.DescripcionTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(189, 22);
            this.DescripcionTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            // 
            // PrecioUnitarioTxt
            // 
            this.PrecioUnitarioTxt.Location = new System.Drawing.Point(229, 342);
            this.PrecioUnitarioTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PrecioUnitarioTxt.Name = "PrecioUnitarioTxt";
            this.PrecioUnitarioTxt.Size = new System.Drawing.Size(189, 22);
            this.PrecioUnitarioTxt.TabIndex = 13;
            this.PrecioUnitarioTxt.TextChanged += new System.EventHandler(this.PrecioUnitarioTxt_TextChanged);
            this.PrecioUnitarioTxt.Leave += new System.EventHandler(this.PrecioUnitarioTxt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio Unitario:";
            // 
            // ExistenciaTxt
            // 
            this.ExistenciaTxt.Location = new System.Drawing.Point(231, 420);
            this.ExistenciaTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ExistenciaTxt.Name = "ExistenciaTxt";
            this.ExistenciaTxt.Size = new System.Drawing.Size(189, 22);
            this.ExistenciaTxt.TabIndex = 15;
            this.ExistenciaTxt.Leave += new System.EventHandler(this.ExistenciaTxt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Existencia:";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(101, 534);
            this.AceptarBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(111, 38);
            this.AceptarBtn.TabIndex = 17;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(356, 534);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(111, 38);
            this.CancelarBtn.TabIndex = 18;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ProveedorCbo
            // 
            this.ProveedorCbo.FormattingEnabled = true;
            this.ProveedorCbo.Location = new System.Drawing.Point(231, 161);
            this.ProveedorCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProveedorCbo.Name = "ProveedorCbo";
            this.ProveedorCbo.Size = new System.Drawing.Size(249, 24);
            this.ProveedorCbo.TabIndex = 19;
            this.ProveedorCbo.SelectedIndexChanged += new System.EventHandler(this.ProveedorCbo_SelectedIndexChanged);
            // 
            // CategoriaCbo
            // 
            this.CategoriaCbo.FormattingEnabled = true;
            this.CategoriaCbo.Location = new System.Drawing.Point(231, 234);
            this.CategoriaCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriaCbo.Name = "CategoriaCbo";
            this.CategoriaCbo.Size = new System.Drawing.Size(249, 24);
            this.CategoriaCbo.TabIndex = 20;
            this.CategoriaCbo.SelectedIndexChanged += new System.EventHandler(this.CategoriaCbo_SelectedIndexChanged);
            // 
            // ProductoAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 617);
            this.Controls.Add(this.CategoriaCbo);
            this.Controls.Add(this.ProveedorCbo);
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
            this.Controls.Add(this.IdProveedor);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductoAMFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductoAMFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdProveedorTxt;
        private System.Windows.Forms.Label IdProveedor;
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
        private System.Windows.Forms.ComboBox ProveedorCbo;
        private System.Windows.Forms.ComboBox CategoriaCbo;
    }
}