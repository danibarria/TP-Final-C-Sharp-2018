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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.listaTodo.Checked)
            {
                //consulta
                //resultado = new CategoriaResultsFrm();
            }
            else {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaResultsFrm frm = new CategoriaResultsFrm();
            frm.NewListado();
            frm.ResultadosCategoria();
        }
    }
}
