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
    public partial class CategoriaResultsFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
        public CategoriaResultsFrm()
        {
            InitializeComponent();
        }
        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
        }
        public void ResultadosCategoria(string nombre = null)
        {
            this.gridCategoria.AutoGenerateColumns = false;
            List<Categoria> lista = ManagerDB<Categoria>.findAll();
            this.gridCategoria.DataSource = lista;
            Cursor.Current = Cursors.Default;

            this.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ReloadGrid()
        {
            this.gridCategoria.Refresh();
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
        
    }
}
