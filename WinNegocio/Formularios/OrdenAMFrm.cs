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
    public partial class OrdenAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;

        Orden ord;
        public OrdenAMFrm()
        {
            InitializeComponent();

            this.EmpleadoCbo.DisplayMember = "Apellido";
            this.EmpleadoCbo.ValueMember = "EmpleadoId";
            this.EmpleadoCbo.DataSource = ManagerDB<Empleado>.findAll();

            this.ClienteCbo.DisplayMember = "NombreContacto";
            this.ClienteCbo.ValueMember = "ClienteId";
            this.ClienteCbo.DataSource = ManagerDB<Cliente>.findAll();
        }

        public void ShowOrden(Orden orden, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de Orden";
            ord = orden;
            this.IdMsk.Enabled = false;
            this.EmpleadoIdTxt.Text = ord.EmpleadoId.ToString();
            this.ClienteTxt.Text = ord.ClienteId.ToString();
            this.IdMsk.Text = ord.OrdenId.ToString();
            this.FechaTxt.Text = ord.FechaOrden.ToString();
            this.DescuentoTxt.Text = ord.Descuento.ToString();
            this.ShowDialog();
        }

        public void NewOrden(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nueva Orden";
            this.operacion = OperacionForm.frmAlta;
            this.ShowDialog();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.operacion == OperacionForm.frmAlta)
                {
                    ord = new Orden();
                    //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                }
                /* Comprobar que esten los datos obligatorios*/
                ord.EmpleadoId = Convert.ToInt32(this.EmpleadoIdTxt.Text,10);
                ord.ClienteId = Convert.ToInt32(this.ClienteTxt.Text,10);
                ord.FechaOrden = Convert.ToDateTime(this.FechaTxt.Text);
                ord.Descuento = Convert.ToInt32(this.DescuentoTxt.Text, 10);
                if (!ord.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nueva Orden" : "Error al intentar editar informacion de Orden", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nueva Orden dado de alta" : "Actualizacion de informacion de Orden", operacion == OperacionForm.frmAlta ? "Ingreso de Orden..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo Empleado" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //_frmGrid.ReloadGrid();
            this.Dispose();
        }

        private void EmpleadoCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado p = new Empleado();
            p = (this.EmpleadoCbo.SelectedItem as Empleado);
            this.EmpleadoIdTxt.Text = p.EmpleadoId.ToString();
        }

        private void ClienteCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente p = new Cliente();
            p = (this.ClienteCbo.SelectedItem as Cliente);
            this.ClienteTxt.Text = p.ClienteId.ToString();
        }
    }
}
