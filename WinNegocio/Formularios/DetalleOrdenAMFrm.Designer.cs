namespace WinNegocio.Formularios
{
    partial class DetalleOrdenAMFrm
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.IdMsk = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductoIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(200, 353);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(83, 31);
            this.CancelarBtn.TabIndex = 19;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(57, 353);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(83, 31);
            this.AceptarBtn.TabIndex = 20;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(129, 43);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(106, 20);
            this.IdMsk.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Renglon:";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(129, 131);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(143, 20);
            this.CantidadTxt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad:";
            // 
            // ProductoIdTxt
            // 
            this.ProductoIdTxt.Location = new System.Drawing.Point(129, 82);
            this.ProductoIdTxt.Name = "ProductoIdTxt";
            this.ProductoIdTxt.Size = new System.Drawing.Size(143, 20);
            this.ProductoIdTxt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Producto Id:";
            // 
            // DetalleOrdenAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 407);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductoIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Name = "DetalleOrdenAMFrm";
            this.Text = "DetalleOrdenAMFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.MaskedTextBox IdMsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductoIdTxt;
        private System.Windows.Forms.Label label3;
    }
}