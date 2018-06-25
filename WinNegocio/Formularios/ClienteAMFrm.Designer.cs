namespace WinNegocio.Formularios
{
    partial class ClienteAMFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CedulaRucTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreCiaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DireccionTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.IdMsk = new System.Windows.Forms.MaskedTextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CelularTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FijoTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // CedulaRucTxt
            // 
            this.CedulaRucTxt.Location = new System.Drawing.Point(102, 75);
            this.CedulaRucTxt.Name = "CedulaRucTxt";
            this.CedulaRucTxt.Size = new System.Drawing.Size(143, 20);
            this.CedulaRucTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula Ruc.:";
            // 
            // NombreCiaTxt
            // 
            this.NombreCiaTxt.Location = new System.Drawing.Point(102, 110);
            this.NombreCiaTxt.Name = "NombreCiaTxt";
            this.NombreCiaTxt.Size = new System.Drawing.Size(143, 20);
            this.NombreCiaTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre cia.:";
            // 
            // ContactoTxt
            // 
            this.ContactoTxt.Location = new System.Drawing.Point(102, 146);
            this.ContactoTxt.Name = "ContactoTxt";
            this.ContactoTxt.Size = new System.Drawing.Size(143, 20);
            this.ContactoTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contacto:";
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Location = new System.Drawing.Point(102, 182);
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.Size = new System.Drawing.Size(143, 20);
            this.DireccionTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccion:";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(58, 330);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(83, 31);
            this.AceptarBtn.TabIndex = 16;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(199, 330);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(83, 31);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(102, 37);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(106, 20);
            this.IdMsk.TabIndex = 2;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(102, 219);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(143, 20);
            this.EmailTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email:";
            // 
            // CelularTxt
            // 
            this.CelularTxt.Location = new System.Drawing.Point(102, 256);
            this.CelularTxt.Name = "CelularTxt";
            this.CelularTxt.Size = new System.Drawing.Size(143, 20);
            this.CelularTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Celular:";
            // 
            // FijoTxt
            // 
            this.FijoTxt.Location = new System.Drawing.Point(102, 290);
            this.FijoTxt.Name = "FijoTxt";
            this.FijoTxt.Size = new System.Drawing.Size(143, 20);
            this.FijoTxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fijo:";
            // 
            // ClienteAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 390);
            this.Controls.Add(this.FijoTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CelularTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.DireccionTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContactoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreCiaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CedulaRucTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteAMFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Cliente";
            this.Load += new System.EventHandler(this.ClientesAMFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CedulaRucTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreCiaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContactoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DireccionTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CelularTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FijoTxt;
        private System.Windows.Forms.Label label8;
    }
}