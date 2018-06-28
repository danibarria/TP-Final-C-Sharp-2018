namespace WinNegocio.Formularios
{
    partial class CategoriaBusqFrm
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
            this.listarCheck = new System.Windows.Forms.CheckBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.nombreCheck = new System.Windows.Forms.CheckBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listarCheck
            // 
            this.listarCheck.AutoSize = true;
            this.listarCheck.Location = new System.Drawing.Point(45, 103);
            this.listarCheck.Name = "listarCheck";
            this.listarCheck.Size = new System.Drawing.Size(97, 21);
            this.listarCheck.TabIndex = 0;
            this.listarCheck.Text = "Listar todo";
            this.listarCheck.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.listarCheck.UseVisualStyleBackColor = true;
            this.listarCheck.CheckedChanged += new System.EventHandler(this.listarCheck_CheckedChanged);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(160, 149);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(90, 29);
            this.BuscarBtn.TabIndex = 1;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreCheck
            // 
            this.nombreCheck.AutoSize = true;
            this.nombreCheck.Location = new System.Drawing.Point(45, 54);
            this.nombreCheck.Name = "nombreCheck";
            this.nombreCheck.Size = new System.Drawing.Size(80, 21);
            this.nombreCheck.TabIndex = 2;
            this.nombreCheck.Text = "Nombre";
            this.nombreCheck.UseVisualStyleBackColor = true;
            this.nombreCheck.CheckedChanged += new System.EventHandler(this.nombreCheck_CheckedChanged);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(160, 54);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(235, 22);
            this.NombreTxt.TabIndex = 3;
            // 
            // CategoriaBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 224);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.nombreCheck);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.listarCheck);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoriaBusqFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox listarCheck;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.CheckBox nombreCheck;
        private System.Windows.Forms.TextBox NombreTxt;
    }
}