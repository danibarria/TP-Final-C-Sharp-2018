namespace WinNegocio.Formularios
{
    partial class ProveedorAMFrm
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
            this.proveedorId = new System.Windows.Forms.Label();
            this.IdMsk = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreProveedorTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ContactoTxt = new System.Windows.Forms.TextBox();
            this.CelularTxt = new System.Windows.Forms.TextBox();
            this.FijoTxt = new System.Windows.Forms.TextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proveedorId
            // 
            this.proveedorId.AutoSize = true;
            this.proveedorId.Location = new System.Drawing.Point(24, 29);
            this.proveedorId.Name = "proveedorId";
            this.proveedorId.Size = new System.Drawing.Size(16, 13);
            this.proveedorId.TabIndex = 0;
            this.proveedorId.Text = "Id";
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(129, 26);
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(110, 20);
            this.IdMsk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Proveedor:";
            // 
            // NombreProveedorTxt
            // 
            this.NombreProveedorTxt.Location = new System.Drawing.Point(126, 71);
            this.NombreProveedorTxt.Name = "NombreProveedorTxt";
            this.NombreProveedorTxt.Size = new System.Drawing.Size(151, 20);
            this.NombreProveedorTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contacto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fijo:";
            // 
            // ContactoTxt
            // 
            this.ContactoTxt.Location = new System.Drawing.Point(126, 113);
            this.ContactoTxt.Name = "ContactoTxt";
            this.ContactoTxt.Size = new System.Drawing.Size(151, 20);
            this.ContactoTxt.TabIndex = 7;
            // 
            // CelularTxt
            // 
            this.CelularTxt.Location = new System.Drawing.Point(126, 160);
            this.CelularTxt.Name = "CelularTxt";
            this.CelularTxt.Size = new System.Drawing.Size(151, 20);
            this.CelularTxt.TabIndex = 8;
            this.CelularTxt.Leave += new System.EventHandler(this.CelularTxt_Leave);
            // 
            // FijoTxt
            // 
            this.FijoTxt.Location = new System.Drawing.Point(126, 198);
            this.FijoTxt.Name = "FijoTxt";
            this.FijoTxt.Size = new System.Drawing.Size(151, 20);
            this.FijoTxt.TabIndex = 9;
            this.FijoTxt.Leave += new System.EventHandler(this.FijoTxt_Leave);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(27, 318);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(95, 38);
            this.AceptarBtn.TabIndex = 10;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(185, 317);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(95, 39);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ProveedorAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 394);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.FijoTxt);
            this.Controls.Add(this.CelularTxt);
            this.Controls.Add(this.ContactoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreProveedorTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.proveedorId);
            this.Name = "ProveedorAMFrm";
            this.Text = "ProveedorAMFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label proveedorId;
        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreProveedorTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContactoTxt;
        private System.Windows.Forms.TextBox CelularTxt;
        private System.Windows.Forms.TextBox FijoTxt;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}