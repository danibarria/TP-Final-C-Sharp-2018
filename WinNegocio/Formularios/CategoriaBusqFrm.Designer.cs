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
            this.listaTodo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaTodo
            // 
            this.listaTodo.AutoSize = true;
            this.listaTodo.Location = new System.Drawing.Point(45, 103);
            this.listaTodo.Name = "listaTodo";
            this.listaTodo.Size = new System.Drawing.Size(97, 21);
            this.listaTodo.TabIndex = 0;
            this.listaTodo.Text = "Listar todo";
            this.listaTodo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.listaTodo.UseVisualStyleBackColor = true;
            this.listaTodo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CategoriaBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaTodo);
            this.Name = "CategoriaBusqFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox listaTodo;
        private System.Windows.Forms.Button button1;
    }
}