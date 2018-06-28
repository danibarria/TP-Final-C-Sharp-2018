namespace WinNegocio.Formularios
{
    partial class OrdenBusqFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.FechaChk = new System.Windows.Forms.CheckBox();
            this.ClienteIdTxt = new System.Windows.Forms.TextBox();
            this.ClienteIdChk = new System.Windows.Forms.CheckBox();
            this.ListTodoChk = new System.Windows.Forms.CheckBox();
            this.EmpleadoIdTxt = new System.Windows.Forms.TextBox();
            this.EmpleadoIdChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaTxt);
            this.groupBox1.Controls.Add(this.FechaChk);
            this.groupBox1.Controls.Add(this.ClienteIdTxt);
            this.groupBox1.Controls.Add(this.ClienteIdChk);
            this.groupBox1.Controls.Add(this.ListTodoChk);
            this.groupBox1.Controls.Add(this.EmpleadoIdTxt);
            this.groupBox1.Controls.Add(this.EmpleadoIdChk);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(565, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // FechaTxt
            // 
            this.FechaTxt.Enabled = false;
            this.FechaTxt.Location = new System.Drawing.Point(184, 87);
            this.FechaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(251, 22);
            this.FechaTxt.TabIndex = 8;
            // 
            // FechaChk
            // 
            this.FechaChk.AutoSize = true;
            this.FechaChk.Location = new System.Drawing.Point(36, 87);
            this.FechaChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FechaChk.Name = "FechaChk";
            this.FechaChk.Size = new System.Drawing.Size(73, 21);
            this.FechaChk.TabIndex = 7;
            this.FechaChk.Text = "Fecha:";
            this.FechaChk.UseVisualStyleBackColor = true;
            this.FechaChk.CheckedChanged += new System.EventHandler(this.FechaChk_CheckedChanged);
            // 
            // ClienteIdTxt
            // 
            this.ClienteIdTxt.Enabled = false;
            this.ClienteIdTxt.Location = new System.Drawing.Point(184, 55);
            this.ClienteIdTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClienteIdTxt.Name = "ClienteIdTxt";
            this.ClienteIdTxt.Size = new System.Drawing.Size(251, 22);
            this.ClienteIdTxt.TabIndex = 6;
            // 
            // ClienteIdChk
            // 
            this.ClienteIdChk.AutoSize = true;
            this.ClienteIdChk.Location = new System.Drawing.Point(36, 55);
            this.ClienteIdChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClienteIdChk.Name = "ClienteIdChk";
            this.ClienteIdChk.Size = new System.Drawing.Size(92, 21);
            this.ClienteIdChk.TabIndex = 5;
            this.ClienteIdChk.Text = "Cliente Id:";
            this.ClienteIdChk.UseVisualStyleBackColor = true;
            this.ClienteIdChk.CheckedChanged += new System.EventHandler(this.ClienteIdChk_CheckedChanged);
            // 
            // ListTodoChk
            // 
            this.ListTodoChk.AutoSize = true;
            this.ListTodoChk.Location = new System.Drawing.Point(35, 126);
            this.ListTodoChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListTodoChk.Name = "ListTodoChk";
            this.ListTodoChk.Size = new System.Drawing.Size(97, 21);
            this.ListTodoChk.TabIndex = 4;
            this.ListTodoChk.Text = "Listar todo";
            this.ListTodoChk.UseVisualStyleBackColor = true;
            this.ListTodoChk.CheckedChanged += new System.EventHandler(this.ListTodoChk_CheckedChanged);
            // 
            // EmpleadoIdTxt
            // 
            this.EmpleadoIdTxt.Enabled = false;
            this.EmpleadoIdTxt.Location = new System.Drawing.Point(184, 23);
            this.EmpleadoIdTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpleadoIdTxt.Name = "EmpleadoIdTxt";
            this.EmpleadoIdTxt.Size = new System.Drawing.Size(251, 22);
            this.EmpleadoIdTxt.TabIndex = 3;
            // 
            // EmpleadoIdChk
            // 
            this.EmpleadoIdChk.AutoSize = true;
            this.EmpleadoIdChk.Location = new System.Drawing.Point(36, 23);
            this.EmpleadoIdChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpleadoIdChk.Name = "EmpleadoIdChk";
            this.EmpleadoIdChk.Size = new System.Drawing.Size(112, 21);
            this.EmpleadoIdChk.TabIndex = 2;
            this.EmpleadoIdChk.Text = "Empleado Id:";
            this.EmpleadoIdChk.UseVisualStyleBackColor = true;
            this.EmpleadoIdChk.CheckedChanged += new System.EventHandler(this.EmpleadoIdChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(475, 190);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(107, 34);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cerrar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(281, 188);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(111, 36);
            this.BuscarBtn.TabIndex = 5;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // OrdenBusqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 251);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdenBusqFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenBusqFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ClienteIdTxt;
        private System.Windows.Forms.CheckBox ClienteIdChk;
        private System.Windows.Forms.CheckBox ListTodoChk;
        private System.Windows.Forms.TextBox EmpleadoIdTxt;
        private System.Windows.Forms.CheckBox EmpleadoIdChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox FechaTxt;
        private System.Windows.Forms.CheckBox FechaChk;
    }
}