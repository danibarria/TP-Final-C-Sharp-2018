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
    public partial class ClienteBusqFrm : Form
    {
        public ClienteBusqFrm()
        {
            InitializeComponent();
        }

     

        private void CedulaRucChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CeulaRucTxt.Enabled = this.CedulaRucChk.Checked;
            if (this.CedulaRucChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.CeulaRucTxt.Focus();
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            ClientesResultsFrm pfrm;
            
            string cedula_ruc = null;
            string nombre_cia = null;
            if(!ListTodoChk.Checked && !this.CedulaRucChk.Checked && !this.NombreCiaChk.Checked )
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda","Faltan criterios...",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            
            
            //if (!ListTodoChk.Checked && this.CedulaRucChk.Checked)
                //cedula_ruc = this.CeulaRucTxt.Text;
            nombre_cia = NombreCiaTxt.Text;
            pfrm = new ClientesResultsFrm();
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;
            pfrm.ResultadosCliente(cedula_ruc, nombre_cia);
            this.Dispose(); 
        }

        private void ListTodoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ListTodoChk.Checked)
            {
                this.CedulaRucChk.Checked = false;
                
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NombreCiaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreCiaTxt.Enabled = this.NombreCiaChk.Checked;
            if (this.NombreCiaChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.NombreCiaTxt.Focus();
            }
        }
    }
}
