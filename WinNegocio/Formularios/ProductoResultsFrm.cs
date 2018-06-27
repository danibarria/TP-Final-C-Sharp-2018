using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibNegocio.db;

namespace WinNegocio.Formularios
{
    public partial class ProductoResultsFrm : Form, IFormGridReload
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
        
        public ProductoResultsFrm()
        {
            InitializeComponent();
        }
        
        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
        }
        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ReloadGrid()
        {
            this.gridProducto.Refresh();
        }

        public void ResultadosProducto(string proveedor = null,string categoria=null,string descripcion= null)
        {

            if (proveedor == null && categoria == null && descripcion == null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll();
                this.gridProducto.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (proveedor != null && categoria == null && descripcion == null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("proveedor_id like '%{0}%'", proveedor));
                this.gridProducto.DataSource = lista;
            }
            if (proveedor == null && categoria != null && descripcion == null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("categoria_id like '%{0}%'", categoria));
                this.gridProducto.DataSource = lista;
            }
            if (proveedor == null && categoria == null && descripcion != null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("descripcion like '%{0}%'", descripcion));
                this.gridProducto.DataSource = lista;
            }
            if (proveedor != null && categoria != null && descripcion == null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("proveedor_id = '{0}' and categoria_id like '%{1}%'", proveedor, categoria));
                this.gridProducto.DataSource = lista;
            }
            if (proveedor != null && categoria == null && descripcion != null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("proveedor_id = '{0}' and descripcion like '%{1}%'", proveedor, descripcion));
                
                this.gridProducto.DataSource = lista;
            }
            if (proveedor == null && categoria != null && descripcion != null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("categoria_id = '{0}' and descripcion like '%{1}%'", categoria, descripcion));
                this.gridProducto.DataSource = lista;
            }
            if (proveedor != null && categoria != null && descripcion != null)
            {
                this.gridProducto.AutoGenerateColumns = false;
                List<Producto> lista = ManagerDB<Producto>.findAll(String.Format("proveedor_id = '{0}' and categoria_id like '%{1}%' and descripcion like '%{2}%'", proveedor, categoria,descripcion));
                this.gridProducto.DataSource = lista;
            }
            this.ShowDialog();

        }

        private void gridProducto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Producto p;
            Categoria c;
            Proveedor pv;
            foreach (var item in this.gridProducto.Rows)
            {
                p = (item as DataGridViewRow).DataBoundItem as Producto;
                c = p.CategoriaObj;
                pv = p.ProveedorObj;
                (item as DataGridViewRow).Cells[0].Value = pv.NombreProveedor;
                (item as DataGridViewRow).Cells[1].Value = c.NombreCategoria;
            }
        }

        private void gridProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.operacion == OperacionForm.frmModificacion)
            {
                ProductoAMFrm frm = new ProductoAMFrm();
                frm.ShowProducto((this.gridProducto.Rows[e.RowIndex].DataBoundItem as Producto), this);
            }      
        }

 

    }
}
