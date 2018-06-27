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
            this.EmpleadoCbo = new System.Windows.Forms.ComboBox();
            this.ClienteCbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(244, 44);
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
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // EmpleadoIdTxt
            // 
            this.EmpleadoIdTxt.Enabled = false;
            this.EmpleadoIdTxt.Location = new System.Drawing.Point(244, 98);
            this.EmpleadoIdTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmpleadoIdTxt.Name = "EmpleadoIdTxt";
            this.EmpleadoIdTxt.Size = new System.Drawing.Size(189, 22);
            this.EmpleadoIdTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Empleado Id";
            // 
            // ClienteTxt
            // 
            this.ClienteTxt.Enabled = false;
            this.ClienteTxt.Location = new System.Drawing.Point(244, 181);
            this.ClienteTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ClienteTxt.Name = "ClienteTxt";
            this.ClienteTxt.Size = new System.Drawing.Size(189, 22);
            this.ClienteTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente Id";
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(244, 257);
            this.FechaTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(251, 22);
            this.FechaTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // DescuentoTxt
            // 
            this.DescuentoTxt.Location = new System.Drawing.Point(244, 302);
            this.DescuentoTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DescuentoTxt.Name = "DescuentoTxt";
            this.DescuentoTxt.Size = new System.Drawing.Size(251, 22);
            this.DescuentoTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descuento:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(329, 480);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(127, 48);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(48, 481);
            this.AceptarBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(127, 47);
            this.AceptarBtn.TabIndex = 16;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // EmpleadoCbo
            // 
            this.EmpleadoCbo.FormattingEnabled = true;
            this.EmpleadoCbo.Location = new System.Drawing.Point(244, 137);
            this.EmpleadoCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpleadoCbo.Name = "EmpleadoCbo";
            this.EmpleadoCbo.Size = new System.Drawing.Size(251, 24);
            this.EmpleadoCbo.TabIndex = 18;
            this.EmpleadoCbo.SelectedIndexChanged += new System.EventHandler(this.EmpleadoCbo_SelectedIndexChanged);
            // 
            // ClienteCbo
            // 
            this.ClienteCbo.FormattingEnabled = true;
            this.ClienteCbo.Location = new System.Drawing.Point(244, 218);
            this.ClienteCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClienteCbo.Name = "ClienteCbo";
            this.ClienteCbo.Size = new System.Drawing.Size(251, 24);
            this.ClienteCbo.TabIndex = 19;
            this.ClienteCbo.SelectedIndexChanged += new System.EventHandler(this.ClienteCbo_SelectedIndexChanged);
            // 
            // OrdenAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 597);
            this.Controls.Add(this.ClienteCbo);
            this.Controls.Add(this.EmpleadoCbo);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ComboBox EmpleadoCbo;
        private System.Windows.Forms.ComboBox ClienteCbo;
    }
}