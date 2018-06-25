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

        Producto prod;
        public ProductoAMFrm()
        {
            InitializeComponent();
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
            string aux;
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
                prod.PrecioUnitario = float.Parse(this.PrecioUnitarioTxt.Text,CultureInfo.InvariantCulture);
                prod.Existencia = System.Convert.ToInt32(this.ExistenciaTxt.Text, 10);

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
    }
}
