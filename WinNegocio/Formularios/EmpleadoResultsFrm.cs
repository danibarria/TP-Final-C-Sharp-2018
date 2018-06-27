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
    public partial class EmpleadoResultsFrm : Form, IFormGridReload
    {
        OperacionForm operacion = OperacionForm.frmModificacion;
       
        public EmpleadoResultsFrm()
        {
            InitializeComponent();
        }

        public void NewListado()
        {
            this.operacion = OperacionForm.frmConsulta;
        }

        public void ReloadGrid()
        {
            this.gridEmpleado.Refresh();
        }
        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void ResultadosEmpleado(string nombre=null, string apellido=null, string reportaA=null, string extension=null)
        {
            if (nombre == null && apellido == null && reportaA == null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll();
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }

            if (nombre == null && apellido == null && reportaA == null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("extension like '%{0}%'", extension));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre == null && apellido == null && reportaA != null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("reporta_a like '%{0}%'", reportaA));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre == null && apellido == null && reportaA != null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("reporta_a = '{0}' and extension like '%{1}%'", reportaA, extension));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre == null && apellido != null && reportaA == null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("apellido like '%{0}%'", apellido));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre == null && apellido != null && reportaA == null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("extension = '{0}' and apellido like '%{1}%'", extension, apellido));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre == null && apellido != null && reportaA != null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("apellido like '%{0}%' and reporta_A = '{1}'", apellido,reportaA));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre == null && apellido != null && reportaA != null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("apellido like '%{0}%' and reporta_A = '{1}' and extension = '{2}'", apellido, reportaA, extension));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido == null && reportaA == null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%'", nombre));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido == null && reportaA == null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%' and extension like '%{1}%'", nombre,extension));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido == null && reportaA != null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%' and reportar_a like '%{1}%'", nombre, reportaA));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido == null && reportaA != null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%' and reportar_a like '%{1}%' and extension like '%{2}%'", nombre, reportaA, extension));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido != null && reportaA == null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%' and apellido like '%{1}%'", nombre, apellido));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido != null && reportaA == null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%' and apellido like '%{1}%' and extension like '%{2}%'", nombre, apellido, extension));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido != null && reportaA != null && extension == null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%' and apellido like '%{1}%' and reporta_a like '%{2}%'", nombre, apellido, reportaA));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            if (nombre != null && apellido != null && reportaA != null && extension != null)
            {
                this.gridEmpleado.AutoGenerateColumns = false;
                List<Empleado> lista = ManagerDB<Empleado>.findAll(String.Format("nombre like '%{0}%' and apellido like '%{1}%' and reporta_a like '%{2}%' and extension '%{3}%'", nombre, apellido, reportaA,extension));
                this.gridEmpleado.DataSource = lista;
                Cursor.Current = Cursors.Default;
            }
            this.ShowDialog();

        }
        private void gridEmpleado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Empleado em;
            Empleado rem;
            foreach (var item in this.gridEmpleado.Rows)
            {
                em = (item as DataGridViewRow).DataBoundItem as Empleado;
                if (em.ReportaA != 0)
                {
                    rem = em.ReportaEmpleadoObj;
                    (item as DataGridViewRow).Cells[3].Value = rem.Nombre + " " + rem.Apellido;
                }
            }
        }

        private void gridEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.operacion == OperacionForm.frmModificacion)
            {
                EmpleadoAMFrm frm = new EmpleadoAMFrm();
                frm.ShowEmpleado((this.gridEmpleado.Rows[e.RowIndex].DataBoundItem as Empleado), this);
            }      
        }
    }
}
