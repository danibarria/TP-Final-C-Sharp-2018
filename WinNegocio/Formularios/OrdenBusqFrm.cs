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
    public partial class OrdenBusqFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmModificacion;

        public OrdenBusqFrm()
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
                this.FechaChk.Checked = false;
                this.ClienteIdChk.Checked = false;
                this.EmpleadoIdChk.Checked = false;
            }
        }

        private void FechaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaTxt.Enabled = this.FechaChk.Checked;
            if (this.FechaChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.FechaTxt.Focus();
            }
        }

        private void ClienteIdChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ClienteIdTxt.Enabled = this.ClienteIdChk.Checked;
            if (this.ClienteIdChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.ClienteIdTxt.Focus();
            }
        }

        private void EmpleadoIdChk_CheckedChanged(object sender, EventArgs e)
        {
            this.EmpleadoIdTxt.Enabled = this.EmpleadoIdChk.Checked;
            if (this.EmpleadoIdChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.EmpleadoIdTxt.Focus();
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            OrdenResultsFrm pfrm;
            string empleado = null;
            string cliente = null;
            string fecha = null;

            if (!ListTodoChk.Checked && !this.EmpleadoIdChk.Checked && !this.ClienteIdChk.Checked && !this.FechaChk.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.EmpleadoIdChk.Checked)
                empleado = this.EmpleadoIdTxt.Text;
            if (this.ClienteIdChk.Checked)
                cliente = this.ClienteIdTxt.Text;
            if (this.FechaChk.Checked)
                fecha = this.FechaTxt.Text;

            pfrm = new OrdenResultsFrm();
            if (this.operacion == OperacionForm.frmConsulta)
            {
                pfrm.NewListado();
            }
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;
            pfrm.ResultadosOrden(empleado, cliente, fecha);
            this.Dispose(); 
        }

    }
}
