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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 224);
            this.Controls.Add(this.listaTodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox listaTodo;
    }
}