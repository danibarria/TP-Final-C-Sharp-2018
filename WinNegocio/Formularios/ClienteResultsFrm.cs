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
    public partial class ClientesResultsFrm : Form, IFormGridReload
    {
        public ClientesResultsFrm()
        {
            InitializeComponent();
        }

        public void ResultadosCliente(string cedularuc = null, string nombrecia = null)
        {
            if ( cedularuc == null && nombrecia== null)
            {
                /*
                * Se requiere este seteo para que se posibilite el mapeo de columnas que se Agregaron
                * desde el diseñador, Click con boton derecho sobre seleccion de grilla -> Edit Columns
                */            
                this.gridClientes.AutoGenerateColumns = false;
                List<Cliente> lista = ManagerDB<Cliente>.findAll();
                this.gridClientes.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
        
            if (cedularuc != null && nombrecia==null)
            {
                this.gridClientes.AutoGenerateColumns = false;
                List<Cliente> lista = ManagerDB<Cliente>.findAll(String.Format("cedula_ruc = '{0}'", cedularuc));
                this.gridClientes.DataSource = lista;
            }

            if (cedularuc == null && nombrecia != null)
            {
                this.gridClientes.AutoGenerateColumns = false;
                List<Cliente> lista = ManagerDB<Cliente>.findAll(String.Format("nombre_cia like '%{0}%'", nombrecia));
                this.gridClientes.DataSource = lista;
            }
            if (cedularuc != null && nombrecia != null)
            {
                this.gridClientes.AutoGenerateColumns = false;
                List<Cliente> lista = ManagerDB<Cliente>.findAll(String.Format("cedula_ruc = '{0}' and nombre_cia like '%{1}%'", cedularuc, nombrecia));
                this.gridClientes.DataSource = lista;
            }
           
            this.ShowDialog();
        }
       

        private void ClienteFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ClienteAMFrm frm = new ClienteAMFrm();
                frm.ShowCliente(grid.Rows[e.RowIndex].DataBoundItem as Cliente,this);
            }
        }

        private void gridClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Cliente p;
            foreach (DataGridViewRow row in gridClientes.Rows)
            {                
                DataGridViewCell cell;
                p = (row.DataBoundItem as Cliente);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}, {1}", p.CedulaRuc, p.NombreCia);
            }
        }

        private void NuevoClienteBtn_Click(object sender, EventArgs e)
        {
            ClienteAMFrm frm = new ClienteAMFrm();
            frm.NewCliente(this);
        }

        public void ReloadGrid()
        {
            this.gridClientes.Refresh();
        }

        private void ClientesResultsFrm_Load(object sender, EventArgs e)
        {

        }

        private void gridClientes_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Cliente cli;
            foreach (var item in this.gridClientes.Rows)
	        {
                cli = (item as DataGridViewRow).DataBoundItem as Cliente ;
                (item as DataGridViewRow).Cells[2].Value = cli.CedulaRuc + " - " + cli.NombreCia;
	        }
        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteAMFrm frm = new ClienteAMFrm();

            frm.ShowCliente((this.gridClientes.Rows[e.RowIndex].DataBoundItem as Cliente),this );
        }
    }
}
