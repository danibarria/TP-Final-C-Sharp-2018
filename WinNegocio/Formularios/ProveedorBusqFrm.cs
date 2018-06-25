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
    public partial class ProveedorBusqFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmModificacion;

        public ProveedorBusqFrm()
        {
            InitializeComponent();
        }

        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
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

        private void ListTodoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ListTodoChk.Checked)
            {
                this.NombreChk.Checked = false;
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            ProveedorResultsFrm pfrm;
            string nombre = null;
            if (!ListTodoChk.Checked && !this.NombreChk.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.NombreChk.Checked)
                nombre = this.NombreTxt.Text;
            pfrm = new ProveedorResultsFrm();
            if (this.operacion == OperacionForm.frmConsulta)
            {
                pfrm.NewListado();
            }
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;
            pfrm.ResultadosProveedor(nombre);
            this.Dispose();

        }

    }
}
