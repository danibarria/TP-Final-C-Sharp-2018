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
    public partial class OrdenResultsFrm : Form, IFormGridReload
    {
        OperacionForm operacion = OperacionForm.frmModificacion;

        public OrdenResultsFrm()
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

        public void ResultadosOrden(string empleado, string cliente, string fecha)
        {
            if (empleado == null && cliente== null && fecha== null)
            {
                /*
                * Se requiere este seteo para que se posibilite el mapeo de columnas que se Agregaron
                * desde el diseñador, Click con boton derecho sobre seleccion de grilla -> Edit Columns
                */
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll();
                this.gridOrden.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }

            if (empleado == null && cliente == null && fecha != null)
            {
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll(String.Format("fecha_orden like '%{0}%'", fecha));
                this.gridOrden.DataSource = lista;
            }
            
            if (empleado == null && cliente != null && fecha == null)
            {
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll(String.Format("cliente_id = '{0}'", cliente));
                this.gridOrden.DataSource = lista;
            }

            if (empleado == null && cliente != null && fecha != null)
            {
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll(String.Format("cliente_id = '{0}' and fecha_orden like '%{1}%'", cliente, fecha));
                this.gridOrden.DataSource = lista;
            }

            if (empleado != null && cliente == null && fecha == null)
            {
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll(String.Format("empleado_id = '{0}'", empleado));
                this.gridOrden.DataSource = lista;
            }

            if (empleado != null && cliente == null && fecha != null)
            {
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll(String.Format("empleado_id = '{0}' and fecha_orden like '%{1}%'", empleado, fecha));
                this.gridOrden.DataSource = lista;
            }

            if (empleado != null && cliente != null && fecha == null)
            {
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll(String.Format("empleado_id = '{0}' and cliente_id = '{1}'", empleado, cliente));
                this.gridOrden.DataSource = lista;
            }

            if (empleado != null && cliente != null && fecha != null)
            {
                this.gridOrden.AutoGenerateColumns = false;
                List<Orden> lista = ManagerDB<Orden>.findAll(String.Format("empleado_id = '{0}' and cliente_id = '{1}' and fecha_orden like '%{2}%'", empleado, cliente, fecha));
                this.gridOrden.DataSource = lista;
            }

            this.ShowDialog();
        }


        private void gridOrden_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Orden ord;
            Empleado emp;
            Cliente cli;
            foreach (var item in this.gridOrden.Rows)
            {
                ord = (item as DataGridViewRow).DataBoundItem as Orden;
                emp = ord.EmpleadoObj;
                cli = ord.ClienteObj;
                (item as DataGridViewRow).Cells[1].Value = emp.Nombre + " " + emp.Apellido;
                (item as DataGridViewRow).Cells[2].Value = cli.NombreCia;
            }
        }

        public void ReloadGrid()
        {
            this.gridOrden.Refresh();
        }

        private void gridOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrdenDetalleResultsFrm frm = new OrdenDetalleResultsFrm();
            if (this.operacion == OperacionForm.frmConsulta)
            {
                frm.NewListado();
            }
            frm.ResultadosOrden((this.gridOrden.Rows[e.RowIndex].DataBoundItem as Orden).OrdenId.ToString()); 
        }
    }
}
