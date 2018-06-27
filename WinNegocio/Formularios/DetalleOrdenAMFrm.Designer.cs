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
            this.ProductoCbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(267, 434);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(111, 38);
            this.CancelarBtn.TabIndex = 19;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(76, 434);
            this.AceptarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(111, 38);
            this.AceptarBtn.TabIndex = 20;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // IdMsk
            // 
            this.IdMsk.Enabled = false;
            this.IdMsk.Location = new System.Drawing.Point(172, 53);
            this.IdMsk.Margin = new System.Windows.Forms.Padding(4);
            this.IdMsk.Mask = "999999999";
            this.IdMsk.Name = "IdMsk";
            this.IdMsk.ReadOnly = true;
            this.IdMsk.Size = new System.Drawing.Size(140, 22);
            this.IdMsk.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Renglon:";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(172, 161);
            this.CantidadTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(189, 22);
            this.CantidadTxt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad:";
            // 
            // ProductoIdTxt
            // 
            this.ProductoIdTxt.Enabled = false;
            this.ProductoIdTxt.Location = new System.Drawing.Point(172, 101);
            this.ProductoIdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProductoIdTxt.Name = "ProductoIdTxt";
            this.ProductoIdTxt.Size = new System.Drawing.Size(189, 22);
            this.ProductoIdTxt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Producto Id:";
            // 
            // ProductoCbo
            // 
            this.ProductoCbo.DisplayMember = "Agregar";
            this.ProductoCbo.FormattingEnabled = true;
            this.ProductoCbo.Location = new System.Drawing.Point(172, 131);
            this.ProductoCbo.Name = "ProductoCbo";
            this.ProductoCbo.Size = new System.Drawing.Size(189, 24);
            this.ProductoCbo.TabIndex = 27;
            this.ProductoCbo.SelectedIndexChanged += new System.EventHandler(this.ProductoCbo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descripcion:";
            // 
            // DetalleOrdenAMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductoCbo);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductoIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdMsk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox ProductoCbo;
        private System.Windows.Forms.Label label2;
    }
}