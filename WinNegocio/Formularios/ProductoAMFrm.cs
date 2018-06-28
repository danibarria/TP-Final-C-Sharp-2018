using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibNegocio.db;
using System.Globalization;
namespace WinNegocio.Formularios
{
    public partial class ProductoAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
        IFormGridReload _frmGrid;

        private bool _val=false;
        Producto prod;
        public ProductoAMFrm()
        {
            InitializeComponent();
            this.ProveedorCbo.DisplayMember = "NombreProveedor";
            this.ProveedorCbo.ValueMember = "ProveedorId";
            this.ProveedorCbo.DataSource = ManagerDB<Proveedor>.findAll();

            this.CategoriaCbo.DisplayMember = "NombreCategoria";
            this.CategoriaCbo.ValueMember = "CategoriaId";
            this.CategoriaCbo.DataSource = ManagerDB<Categoria>.findAll();
        }
        public void ShowProducto(Producto producto, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de Producto";
            prod = producto;
            this.IdMsk.Enabled = false;
            this.IdProveedorTxt.Text = String.Format("{0}",prod.ProveedorId);
            this.IdCategoriaTxt.Text = String.Format("{0}",prod.CategoriaId);
            this.IdMsk.Text = prod.ProductoId.ToString();
            this.DescripcionTxt.Text = prod.Descripcion;
            this.PrecioUnitarioTxt.Text = String.Format("{0}",prod.PrecioUnitario);
            this.ExistenciaTxt.Text = String.Format("{0}",prod.Existencia);
            this.ShowDialog();
        }

        public void NewProducto(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Producto";
            this.operacion = OperacionForm.frmAlta;
            this.ShowDialog();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.operacion == OperacionForm.frmAlta)
                {
                    prod = new Producto();
                    //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                }
                prod.ProveedorId = System.Convert.ToInt32(this.IdProveedorTxt.Text, 10);
                prod.CategoriaId = System.Convert.ToInt32(this.IdCategoriaTxt.Text, 10);
                prod.Descripcion = this.DescripcionTxt.Text;
                prod.PrecioUnitario = Convert.ToDouble(this.PrecioUnitarioTxt.Text);
                prod.Existencia = System.Convert.ToInt32(this.ExistenciaTxt.Text, 10);

                if (!this._val)
                    return;
                if (!prod.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo Producto" : "Error al intentar editar informacion de Producto", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nuevo Producto dado de alta" : "Actualizacion de informacion de Producto", operacion == OperacionForm.frmAlta ? "Ingreso de Producto..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo Producto" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //_frmGrid.ReloadGrid();
            this.Dispose();
        }

        private void ProveedorCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p = (this.ProveedorCbo.SelectedItem as Proveedor);
            this.IdProveedorTxt.Text = p.ProveedorId.ToString();
        }

        private void CategoriaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Categoria c = new Categoria();
            c = (this.CategoriaCbo.SelectedItem as Categoria);
            this.IdCategoriaTxt.Text = c.CategoriaId.ToString();
        }

        private void ExistenciaTxt_Leave(object sender, EventArgs e)
        {
            if (!PrincipalFrm.ValidarNumero(ExistenciaTxt.Text))
            {
                ExistenciaTxt.Focus();
                ExistenciaTxt.BackColor = System.Drawing.Color.IndianRed;
                this._val = false;
            }
            else
            {
                ExistenciaTxt.BackColor = System.Drawing.Color.White;
                this._val = true;
            }
        }

        private void PrecioUnitarioTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void PrecioUnitarioTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(this.PrecioUnitarioTxt.Text);
                this._val = true;
                PrecioUnitarioTxt.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                PrecioUnitarioTxt.Focus();
                PrecioUnitarioTxt.BackColor = System.Drawing.Color.IndianRed;
                this._val = false;
            }
        }

    }
}
