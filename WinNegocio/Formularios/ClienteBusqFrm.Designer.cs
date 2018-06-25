namespace WinNegocio.Formularios
{
    partial class ClienteBusqFrm
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
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListTodoChk = new System.Windows.Forms.CheckBox();
            this.CeulaRucTxt = new System.Windows.Forms.TextBox();
            this.CedulaRucChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.NombreCiaTxt = new System.Windows.Forms.TextBox();
            this.NombreCiaChk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(211, 153);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(83, 29);
            this.BuscarBtn.TabIndex = 2;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreCiaTxt);
            this.groupBox1.Controls.Add(this.NombreCiaChk);
            this.groupBox1.Controls.Add(this.ListTodoChk);
            this.groupBox1.Controls.Add(this.CeulaRucTxt);
            this.groupBox1.Controls.Add(this.CedulaRucChk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // ListTodoChk
            // 
            this.ListTodoChk.AutoSize = true;
            this.ListTodoChk.Location = new System.Drawing.Point(26, 102);
            this.ListTodoChk.Name = "ListTodoChk";
            this.ListTodoChk.Size = new System.Drawing.Size(75, 17);
            this.ListTodoChk.TabIndex = 4;
            this.ListTodoChk.Text = "Listar todo";
            this.ListTodoChk.UseVisualStyleBackColor = true;
            this.ListTodoChk.CheckedChanged += new System.EventHandler(this.ListTodoChk_CheckedChanged);
            // 
            // CeulaRucTxt
            // 
            this.CeulaRucTxt.Enabled = false;
            this.CeulaRucTxt.Location = new System.Drawing.Point(115, 34);
            this.CeulaRucTxt.Name = "CeulaRucTxt";
            this.CeulaRucTxt.Size = new System.Drawing.Size(189, 20);
            this.CeulaRucTxt.TabIndex = 3;
            // 
            // CedulaRucChk
            // 
            this.CedulaRucChk.AutoSize = true;
            this.CedulaRucChk.Location = new System.Drawing.Point(26, 34);
            this.CedulaRucChk.Name = "CedulaRucChk";
            this.CedulaRucChk.Size = new System.Drawing.Size(76, 17);
            this.CedulaRucChk.TabIndex = 2;
            this.CedulaRucChk.Text = "CeulaRuc:";
            this.CedulaRucChk.UseVisualStyleBackColor = true;
            this.CedulaRucChk.CheckedChanged += new System.EventHandler(this.CedulaRucChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(356, 154);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(80, 28);
            this.CancelarBtn.TabIndex = 4;
            this.CancelarBtn.Text = "Cerrar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // NombreCiaTxt
            // 
            this.NombreCiaTxt.Enabled = false;
            this.NombreCiaTxt.Location = new System.Drawing.Point(115, 60);
            this.NombreCiaTxt.Name = "NombreCiaTxt";
            this.NombreCiaTxt.Size = new System.Drawing.Size(189, 20);
            this.NombreCiaTxt.TabIndex = 6;
            // 
            // NombreCiaChk
            // 
            this.NombreCiaChk.AutoSize = true;
            this.NombreCiaChk.Location = new System.Drawing.Point(26, 60);
            this.NombreCiaChk.Name = "NombreCiaChk";
            this.NombreCiaChk.Size = new System.Drawing.Size(83, 17);
            this.NombreCiaChk.TabIndex = 5;
            this.NombreCiaChk.Text = "Nombre cia:";
            this.NombreCiaChk.UseVisualStyleBackColor = true;
            this.NombreCiaChk.CheckedChanged += new System.EventHandler(this.NombreCiaChk_CheckedChanged);
            // 
            // ClienteBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 204);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteBusqFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CeulaRucTxt;
        private System.Windows.Forms.CheckBox CedulaRucChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.CheckBox ListTodoChk;
        private System.Windows.Forms.TextBox NombreCiaTxt;
        private System.Windows.Forms.CheckBox NombreCiaChk;
    }
}