using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinNegocio.Formularios
{
    public partial class EmpleadoBusqFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
        public EmpleadoBusqFrm()
        {
            InitializeComponent();
        }
        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListTodoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ListTodoChk.Checked)
            {
                this.NombreChk.Checked = false;
                this.ApellidoChk.Checked = false;
                this.ReportaAChk.Checked = false;
                this.ExtensionChk.Checked = false;
            }
        }

        private void ExtensionChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ExtensionTxt.Enabled = this.ExtensionChk.Checked;
            if (this.ExtensionChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.ExtensionTxt.Focus();
            }
        }

        private void ReportaAChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ReportaATxt.Enabled = this.ReportaAChk.Checked;
            if (this.ReportaAChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.ReportaATxt.Focus();
            }
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
            if (this.ApellidoChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.ApellidoTxt.Focus();
            }
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
            if (this.NombreChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.NombreTxt.Focus();
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            EmpleadoResultsFrm pfrm;
            string nombre = null;
            string apellido = null;
            string reportaA = null;
            string extension = null;

            if (!ListTodoChk.Checked && !this.NombreChk.Checked && !this.ApellidoChk.Checked && !this.ReportaAChk.Checked && !this.ExtensionChk.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.NombreChk.Checked)
                nombre = this.NombreTxt.Text;
            if (this.ApellidoChk.Checked)
                apellido = this.ApellidoTxt.Text;
            if (this.ReportaAChk.Checked)
                reportaA = this.ReportaATxt.Text;
            if (this.ExtensionChk.Checked)
                extension = this.ExtensionTxt.Text;

            pfrm = new EmpleadoResultsFrm();
            if (this.operacion == OperacionForm.frmConsulta)
            {
                pfrm.NewListado();
            }
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;
            pfrm.ResultadosEmpleado(nombre, apellido, reportaA,extension);
            this.Dispose();
        }
    }
}
