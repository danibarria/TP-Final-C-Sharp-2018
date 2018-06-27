namespace WinNegocio.Formularios
{
    partial class OrdenAMFrm
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
            this.EmpleadoIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClienteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescuentoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(137, 29);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(106, 20);
            this.IdMsk.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // EmpleadoIdTxt
            // 
            this.EmpleadoIdTxt.Location = new System.Drawing.Point(137, 88);
            this.EmpleadoIdTxt.Name = "EmpleadoIdTxt";
            this.EmpleadoIdTxt.Size = new System.Drawing.Size(143, 20);
            this.EmpleadoIdTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Empleado Id";
            // 
            // ClienteTxt
            // 
            this.ClienteTxt.Location = new System.Drawing.Point(137, 130);
            this.ClienteTxt.Name = "ClienteTxt";
            this.ClienteTxt.Size = new System.Drawing.Size(143, 20);
            this.ClienteTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente Id";
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(137, 170);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(151, 20);
            this.FechaTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // DescuentoTxt
            // 
            this.DescuentoTxt.Location = new System.Drawing.Point(137, 210);
            this.DescuentoTxt.Name = "DescuentoTxt";
            this.DescuentoTxt.Size = new System.Drawing.Size(151, 20);
            this.DescuentoTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descuento:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(185, 317);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(95, 39);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(27, 318);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(95, 38);
            this.AceptarBtn.TabIndex = 16;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // OrdenAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 394);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.DescuentoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClienteTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpleadoIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.label1);
            this.Name = "OrdenAMFrm";
            this.Text = "OrdenAMFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpleadoIdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClienteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FechaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescuentoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
    }
}