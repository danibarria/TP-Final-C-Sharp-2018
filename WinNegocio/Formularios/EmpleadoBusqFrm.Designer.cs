namespace WinNegocio.Formularios
{
    partial class EmpleadoBusqFrm
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
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.ListTodoChk = new System.Windows.Forms.CheckBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.ReportaATxt = new System.Windows.Forms.TextBox();
            this.ReportaAChk = new System.Windows.Forms.CheckBox();
            this.ExtensionTxt = new System.Windows.Forms.TextBox();
            this.ExtensionChk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExtensionTxt);
            this.groupBox1.Controls.Add(this.ExtensionChk);
            this.groupBox1.Controls.Add(this.ReportaATxt);
            this.groupBox1.Controls.Add(this.ReportaAChk);
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoChk);
            this.groupBox1.Controls.Add(this.ListTodoChk);
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.NombreChk);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(114, 45);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(189, 20);
            this.ApellidoTxt.TabIndex = 6;
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(25, 45);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(66, 17);
            this.ApellidoChk.TabIndex = 5;
            this.ApellidoChk.Text = "Apellido:";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // ListTodoChk
            // 
            this.ListTodoChk.AutoSize = true;
            this.ListTodoChk.Location = new System.Drawing.Point(26, 120);
            this.ListTodoChk.Name = "ListTodoChk";
            this.ListTodoChk.Size = new System.Drawing.Size(75, 17);
            this.ListTodoChk.TabIndex = 4;
            this.ListTodoChk.Text = "Listar todo";
            this.ListTodoChk.UseVisualStyleBackColor = true;
            this.ListTodoChk.CheckedChanged += new System.EventHandler(this.ListTodoChk_CheckedChanged);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(114, 19);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(189, 20);
            this.NombreTxt.TabIndex = 3;
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(25, 19);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(66, 17);
            this.NombreChk.TabIndex = 2;
            this.NombreChk.Text = "Nombre:";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(212, 163);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(83, 29);
            this.BuscarBtn.TabIndex = 5;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(356, 164);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(80, 28);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cerrar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ReportaATxt
            // 
            this.ReportaATxt.Enabled = false;
            this.ReportaATxt.Location = new System.Drawing.Point(114, 71);
            this.ReportaATxt.Name = "ReportaATxt";
            this.ReportaATxt.Size = new System.Drawing.Size(189, 20);
            this.ReportaATxt.TabIndex = 8;
            // 
            // ReportaAChk
            // 
            this.ReportaAChk.AutoSize = true;
            this.ReportaAChk.Location = new System.Drawing.Point(25, 71);
            this.ReportaAChk.Name = "ReportaAChk";
            this.ReportaAChk.Size = new System.Drawing.Size(76, 17);
            this.ReportaAChk.TabIndex = 7;
            this.ReportaAChk.Text = "Reporta a:";
            this.ReportaAChk.UseVisualStyleBackColor = true;
            this.ReportaAChk.CheckedChanged += new System.EventHandler(this.ReportaAChk_CheckedChanged);
            // 
            // ExtensionTxt
            // 
            this.ExtensionTxt.Enabled = false;
            this.ExtensionTxt.Location = new System.Drawing.Point(114, 97);
            this.ExtensionTxt.Name = "ExtensionTxt";
            this.ExtensionTxt.Size = new System.Drawing.Size(189, 20);
            this.ExtensionTxt.TabIndex = 10;
            // 
            // ExtensionChk
            // 
            this.ExtensionChk.AutoSize = true;
            this.ExtensionChk.Location = new System.Drawing.Point(25, 97);
            this.ExtensionChk.Name = "ExtensionChk";
            this.ExtensionChk.Size = new System.Drawing.Size(75, 17);
            this.ExtensionChk.TabIndex = 9;
            this.ExtensionChk.Text = "Extension:";
            this.ExtensionChk.UseVisualStyleBackColor = true;
            this.ExtensionChk.CheckedChanged += new System.EventHandler(this.ExtensionChk_CheckedChanged);
            // 
            // EmpleadoBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 204);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpleadoBusqFrm";
            this.Text = "EmpleadoBusqFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.CheckBox ListTodoChk;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.TextBox ExtensionTxt;
        private System.Windows.Forms.CheckBox ExtensionChk;
        private System.Windows.Forms.TextBox ReportaATxt;
        private System.Windows.Forms.CheckBox ReportaAChk;
    }
}