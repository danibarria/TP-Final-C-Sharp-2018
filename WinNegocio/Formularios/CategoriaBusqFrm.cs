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
    public partial class CategoriaBusqFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
        public CategoriaBusqFrm()
        {
            InitializeComponent();
        }
        public void newListado() {
            this.operacion = OperacionForm.frmConsulta;
        }
        private void button1_Click(object sender, EventArgs e) //boton buscar
        {
           CategoriaResultsFrm frm = new CategoriaResultsFrm();
            if (!nombreCheck.Checked && !listarCheck.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.operacion == OperacionForm.frmConsulta) {
                frm.NewListado();
            }
            if(nombreCheck.Checked)
            {
                //hacer filtrado
                frm.ResultadosCategoria(this.NombreTxt.Text);
            }
            if (listarCheck.Checked)
            {
                //buscar indistintamente
                frm.ResultadosCategoria();
            }
        }
        private void listarCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.listarCheck.Checked) {
                this.nombreCheck.Checked = false;
            }
        }
        private void nombreCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.nombreCheck.Checked;
            if (this.nombreCheck.Checked)
            {
                this.listarCheck.Checked = false;
                this.NombreTxt.Focus();
            }
        }
    }
}
