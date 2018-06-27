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
    public partial class CategoriaResultsFrm : Form, IFormGridReload
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
        private string filter;
        public CategoriaResultsFrm()
        {
            InitializeComponent();
        }

        public CategoriaResultsFrm(string filter)
        {
            // TODO: Complete member initialization
            this.filter = filter;
        }
        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void ReloadGrid()
        {
            this.gridCategoria.Refresh();
        }
        
        public void ResultadosCategoria()
        {
            this.gridCategoria.AutoGenerateColumns = false;
            List<Categoria> lista = ManagerDB<Categoria>.findAll();            
            this.gridCategoria.DataSource = lista;
            Cursor.Current = Cursors.Default;
            this.ShowDialog();
        }
        public void ResultadosCategoria(string nombre = null)
        {
            this.gridCategoria.AutoGenerateColumns = false;
            List<Categoria> lista = new List<Categoria>();
            lista= ManagerDB<Categoria>.findAll(String.Format("nombre_categoria like '%{0}%'", nombre));
            this.gridCategoria.DataSource = lista;
            Cursor.Current = Cursors.Default;
            this.ShowDialog();
        }
        private void gridCategoria_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Categoria p;
            foreach (DataGridViewRow row in gridCategoria.Rows)
            {
                DataGridViewCell cell;
                p = (row.DataBoundItem as Categoria);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", p.NombreCategoria);
            }
        }

        private void gridCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.operacion == OperacionForm.frmModificacion)
            {
                CategoriaAMFrm frm = new CategoriaAMFrm();
                frm.ShowCategoria((this.gridCategoria.Rows[e.RowIndex].DataBoundItem as Categoria),this);
            }
        }
    }
}
