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
    public partial class ProveedorResultsFrm : Form, IFormGridReload
    {
        OperacionForm operacion = OperacionForm.frmModificacion;

        public ProveedorResultsFrm()
        {
            InitializeComponent();
        }

        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
        }
        public void ResultadosProveedor(string nombre = null)
        {
            if (nombre == null)
            {
                this.gridProveedor.AutoGenerateColumns = false;
                List<Proveedor> lista = ManagerDB<Proveedor>.findAll();
                this.gridProveedor.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null)
            {
                this.gridProveedor.AutoGenerateColumns = false;
                List<Proveedor> lista = ManagerDB<Proveedor>.findAll(String.Format("nombre_proveedor like '%{0}%'",nombre));
                this.gridProveedor.DataSource = lista;
            }
            this.ShowDialog();

        }
        private void gridProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gridProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.operacion == OperacionForm.frmModificacion)
            {
                ProveedorAMFrm frm = new ProveedorAMFrm();
                frm.ShowProveedor((this.gridProveedor.Rows[e.RowIndex].DataBoundItem as Proveedor), this);
            }      
        }

        public void ReloadGrid()
        {
            this.gridProveedor.Refresh();
        }
        
        private void gridProveedor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Proveedor p;
            foreach (DataGridViewRow row in gridProveedor.Rows)
            {
                DataGridViewCell cell;
                p = (row.DataBoundItem as Proveedor);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}, {1}, {2}, {3}", p.NombreProveedor, p.ContactoProveedor,p.CeluProveedor,p.FijoProveedor);
            }
        }
    }
}
