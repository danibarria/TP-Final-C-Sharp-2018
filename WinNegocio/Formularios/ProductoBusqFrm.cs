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
    public partial class ProductoBusqFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
        public ProductoBusqFrm()
        {
            InitializeComponent();
        }
        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
        }

        private void CategoriaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CategoriaTxt.Enabled = this.CategoriaChk.Checked;
            if (this.CategoriaChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.CategoriaTxt.Focus();
            }
        }
        private void ProveedorChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ProveedorTxt.Enabled = this.ProveedorChk.Checked;
            if (this.ProveedorChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.ProveedorTxt.Focus();
            }
        }
        private void DescripcionChk_CheckedChanged(object sender, EventArgs e)
        {
            this.DescripcionTxt.Enabled = this.DescripcionChk.Checked;
            if (this.DescripcionChk.Checked)
            {
                this.ListTodoChk.Checked = false;
                this.DescripcionTxt.Focus();
            }
        }

        private void ListTodoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ListTodoChk.Checked)
            {
                this.CategoriaChk.Checked = false;
                this.DescripcionChk.Checked = false;
                this.ProveedorChk.Checked = false;
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            ProductoResultsFrm pfrm;
            string proveedor = null;
            string categoria = null;
            string descripcion = null;

            if (!ListTodoChk.Checked && !this.ProveedorChk.Checked && !this.CategoriaChk.Checked && !this.DescripcionChk.Checked)
            {
                MessageBox.Show("Tiene que ingresar criterio de busqueda", "Faltan criterios...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.ProveedorChk.Checked)
                proveedor = this.ProveedorTxt.Text;
            if (this.CategoriaChk.Checked)
                categoria = this.CategoriaTxt.Text;
            if (this.DescripcionChk.Checked)
                descripcion = this.DescripcionTxt.Text;
            
            pfrm = new ProductoResultsFrm(); 
            if (this.operacion == OperacionForm.frmConsulta)
            {
                pfrm.NewListado();
            }
            Cursor.Current = Cursors.WaitCursor;
            this.Visible = false;
            pfrm.ResultadosProducto(proveedor,categoria,descripcion);
            this.Dispose();

        }
    }
}
