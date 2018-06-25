using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql; // Libreria para conectar con PostgreSQL
using LibNegocio.db; // incluir espacio de nombre para poder acceder a los objetos de negocios.

namespace WinNegocio.Formularios
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {            
            InitializeComponent();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
               
        }     
               

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            ClientesResultsFrm frm = new ClientesResultsFrm();
            frm.ShowDialog();
        }

        private void ListadosBtn_Click(object sender, EventArgs e)
        {
            
        }     
                
        private void SearchDniBtn_Click(object sender, EventArgs e)
        {/*
            Cliente p = new Cliente();
            p.findbykey(this.DniSearchTxt.Text);
            ClientesAMFrm fampac = new ClientesAMFrm();
            fampac.ShowCliente(p);*/
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dgresult = MessageBox.Show("Desea salir del sistema?", "salir....", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dgresult == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteAMFrm frmCliAlta = new ClienteAMFrm();
            frmCliAlta.NewCliente(null);
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteBusqFrm pbusq = new ClienteBusqFrm();
            pbusq.Show();
        }

        private void FormTestBtn_Click(object sender, EventArgs e)
        {
            FormTestModel frm = new  FormTestModel();
            frm.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProveedorAMFrm frmProveedorAlta = new ProveedorAMFrm();
            frmProveedorAlta.NewProveedor(null);
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProveedorBusqFrm pbusq = new ProveedorBusqFrm();
            pbusq.NewListado();
            pbusq.Show();
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProveedorBusqFrm pbusq = new ProveedorBusqFrm();
            pbusq.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteBusqFrm pbusq = new ClienteBusqFrm();
            pbusq.NewListado();
            pbusq.Show();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductoAMFrm frmProveedorAlta = new ProductoAMFrm();
            frmProveedorAlta.NewProducto(null);
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductoBusqFrm pbusq = new ProductoBusqFrm();
            pbusq.Show();
        }

        private void listadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductoBusqFrm pbusq = new ProductoBusqFrm();
            pbusq.NewListado();
            pbusq.Show();
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoAMFrm frmProveedorAlta = new EmpleadoAMFrm();
            frmProveedorAlta.NewEmpleado(null);
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoBusqFrm pbusq = new EmpleadoBusqFrm();
            pbusq.Show();
        }

        private void listadoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EmpleadoBusqFrm pbusq = new EmpleadoBusqFrm();
            pbusq.NewListado();
            pbusq.Show();

        }
    }
}
