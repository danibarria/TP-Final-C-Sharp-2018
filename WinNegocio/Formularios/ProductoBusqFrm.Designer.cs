﻿namespace WinNegocio.Formularios
{
    partial class ProductoBusqFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.DescripcionChk = new System.Windows.Forms.CheckBox();
            this.ProveedorTxt = new System.Windows.Forms.TextBox();
            this.ProveedorChk = new System.Windows.Forms.CheckBox();
            this.CategoriaTxt = new System.Windows.Forms.TextBox();
            this.CategoriaChk = new System.Windows.Forms.CheckBox();
            this.ListTodoChk = new System.Windows.Forms.CheckBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescripcionTxt);
            this.groupBox1.Controls.Add(this.DescripcionChk);
            this.groupBox1.Controls.Add(this.ProveedorTxt);
            this.groupBox1.Controls.Add(this.ProveedorChk);
            this.groupBox1.Controls.Add(this.CategoriaTxt);
            this.groupBox1.Controls.Add(this.CategoriaChk);
            this.groupBox1.Controls.Add(this.ListTodoChk);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(565, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Enabled = false;
            this.DescripcionTxt.Location = new System.Drawing.Point(145, 87);
            this.DescripcionTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(251, 22);
            this.DescripcionTxt.TabIndex = 10;
            // 
            // DescripcionChk
            // 
            this.DescripcionChk.AutoSize = true;
            this.DescripcionChk.Location = new System.Drawing.Point(27, 87);
            this.DescripcionChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescripcionChk.Name = "DescripcionChk";
            this.DescripcionChk.Size = new System.Drawing.Size(108, 21);
            this.DescripcionChk.TabIndex = 9;
            this.DescripcionChk.Text = "Descripcion:";
            this.DescripcionChk.UseVisualStyleBackColor = true;
            this.DescripcionChk.CheckedChanged += new System.EventHandler(this.DescripcionChk_CheckedChanged);
            // 
            // ProveedorTxt
            // 
            this.ProveedorTxt.Enabled = false;
            this.ProveedorTxt.Location = new System.Drawing.Point(145, 55);
            this.ProveedorTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProveedorTxt.Name = "ProveedorTxt";
            this.ProveedorTxt.Size = new System.Drawing.Size(251, 22);
            this.ProveedorTxt.TabIndex = 8;
            // 
            // ProveedorChk
            // 
            this.ProveedorChk.AutoSize = true;
            this.ProveedorChk.Location = new System.Drawing.Point(27, 55);
            this.ProveedorChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProveedorChk.Name = "ProveedorChk";
            this.ProveedorChk.Size = new System.Drawing.Size(100, 21);
            this.ProveedorChk.TabIndex = 7;
            this.ProveedorChk.Text = "Proveedor:";
            this.ProveedorChk.UseVisualStyleBackColor = true;
            this.ProveedorChk.CheckedChanged += new System.EventHandler(this.ProveedorChk_CheckedChanged);
            // 
            // CategoriaTxt
            // 
            this.CategoriaTxt.Enabled = false;
            this.CategoriaTxt.Location = new System.Drawing.Point(145, 23);
            this.CategoriaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriaTxt.Name = "CategoriaTxt";
            this.CategoriaTxt.Size = new System.Drawing.Size(251, 22);
            this.CategoriaTxt.TabIndex = 6;
            // 
            // CategoriaChk
            // 
            this.CategoriaChk.AutoSize = true;
            this.CategoriaChk.Location = new System.Drawing.Point(27, 23);
            this.CategoriaChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriaChk.Name = "CategoriaChk";
            this.CategoriaChk.Size = new System.Drawing.Size(95, 21);
            this.CategoriaChk.TabIndex = 5;
            this.CategoriaChk.Text = "Categoria:";
            this.CategoriaChk.UseVisualStyleBackColor = true;
            this.CategoriaChk.CheckedChanged += new System.EventHandler(this.CategoriaChk_CheckedChanged);
            // 
            // ListTodoChk
            // 
            this.ListTodoChk.AutoSize = true;
            this.ListTodoChk.Location = new System.Drawing.Point(27, 126);
            this.ListTodoChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListTodoChk.Name = "ListTodoChk";
            this.ListTodoChk.Size = new System.Drawing.Size(97, 21);
            this.ListTodoChk.TabIndex = 4;
            this.ListTodoChk.Text = "Listar todo";
            this.ListTodoChk.UseVisualStyleBackColor = true;
            this.ListTodoChk.CheckedChanged += new System.EventHandler(this.ListTodoChk_CheckedChanged);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(283, 194);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(111, 39);
            this.BuscarBtn.TabIndex = 6;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(471, 194);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(111, 39);
            this.CerrarBtn.TabIndex = 7;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // ProductoBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 249);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductoBusqFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductoBusqFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CategoriaTxt;
        private System.Windows.Forms.CheckBox CategoriaChk;
        private System.Windows.Forms.CheckBox ListTodoChk;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.CheckBox DescripcionChk;
        private System.Windows.Forms.TextBox ProveedorTxt;
        private System.Windows.Forms.CheckBox ProveedorChk;
    }
}