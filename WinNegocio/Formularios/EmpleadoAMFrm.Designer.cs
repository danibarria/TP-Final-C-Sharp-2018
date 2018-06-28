namespace WinNegocio.Formularios
{
    partial class EmpleadoAMFrm
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
            this.proveedorId = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaNacimientoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportarATxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExtensionTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(129, 26);
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(110, 20);
            this.IdMsk.TabIndex = 3;
            // 
            // proveedorId
            // 
            this.proveedorId.AutoSize = true;
            this.proveedorId.Location = new System.Drawing.Point(24, 29);
            this.proveedorId.Name = "proveedorId";
            this.proveedorId.Size = new System.Drawing.Size(16, 13);
            this.proveedorId.TabIndex = 2;
            this.proveedorId.Text = "Id";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(130, 85);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(151, 20);
            this.NombreTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(129, 127);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(151, 20);
            this.ApellidoTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido:";
            // 
            // FechaNacimientoTxt
            // 
            this.FechaNacimientoTxt.Location = new System.Drawing.Point(129, 167);
            this.FechaNacimientoTxt.Name = "FechaNacimientoTxt";
            this.FechaNacimientoTxt.Size = new System.Drawing.Size(151, 20);
            this.FechaNacimientoTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // ReportarATxt
            // 
            this.ReportarATxt.Location = new System.Drawing.Point(130, 207);
            this.ReportarATxt.Name = "ReportarATxt";
            this.ReportarATxt.Size = new System.Drawing.Size(151, 20);
            this.ReportarATxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reporta a:";
            // 
            // ExtensionTxt
            // 
            this.ExtensionTxt.Location = new System.Drawing.Point(130, 252);
            this.ExtensionTxt.Name = "ExtensionTxt";
            this.ExtensionTxt.Size = new System.Drawing.Size(151, 20);
            this.ExtensionTxt.TabIndex = 13;
            this.ExtensionTxt.Leave += new System.EventHandler(this.ExtensionTxt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Extension:";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(27, 318);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(95, 38);
            this.AceptarBtn.TabIndex = 14;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(185, 317);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(95, 39);
            this.CancelarBtn.TabIndex = 15;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // EmpleadoAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 394);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.ExtensionTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReportarATxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaNacimientoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApellidoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.proveedorId);
            this.Name = "EmpleadoAMFrm";
            this.Text = "EmpleadoAMFrm";
            this.Load += new System.EventHandler(this.EmpleadoAMFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.Label proveedorId;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FechaNacimientoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReportarATxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExtensionTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}