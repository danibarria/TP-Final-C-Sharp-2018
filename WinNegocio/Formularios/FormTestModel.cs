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
    public partial class FormTestModel : Form
    {
        public FormTestModel()
        {
            InitializeComponent();
        }

        private void CargarCategoriasBtn_Click(object sender, EventArgs e)
        {
            // propiedades del control a configurar para que se carguen en el control
            this.CategoriasCbo.DisplayMember = "NombreCategoria";
            this.CategoriasCbo.ValueMember = "CategoriaId";
            this.CategoriasCbo.DataSource = ManagerDB<Categoria>.findAll();
        }

        private void CategoriaAddBtn_Click(object sender, EventArgs e)
        {
            #region codigo Ejemplo Altas
           
            /*
            // Categoria - ADD
            Categoria cat = new Categoria();
            cat.NombreCategoria = "Nueva Categoria.";
            cat.saveObj();
            */
           
            #endregion
        }
        //Evento que permite gestionar la visualizacion de las tuplas de la grilla
        private void gridProducto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Producto prod;
            // para cada fila: cliente
            foreach (DataGridViewRow row in gridProducto.Rows)
            {
                //ProductoId, Descripcion, Categoria, Proveedor, PrecioUnit, Existencia, ColCombina
                prod = (row.DataBoundItem as Producto);
                row.Cells[2].Value = prod.CategoriaObj.NombreCategoria;
                row.Cells[3].Value = prod.ProveedorObj.NombreProveedor;
                row.Cells[6].Value = String.Format("Ids:{0} - {1} - {2}", prod.ProductoId,prod.CategoriaId,prod.ProveedorId);
            }
        }

        private void CargarGrillaBtn_Click(object sender, EventArgs e)
        {
            
            // Se necesita esta opcion para mantener configuracion de columnas editada en el diseño de la grilla
            this.gridProducto.AutoGenerateColumns = false;
            this.gridProducto.DataSource = ManagerDB<Producto>.findAll();
        }

        private void FormTestModel_Load(object sender, EventArgs e)
        {

        }

        private void CategoriasCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
