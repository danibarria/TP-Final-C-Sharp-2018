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
    public partial class EmpleadoAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;

        Empleado emp;
        public EmpleadoAMFrm()
        {
            InitializeComponent();
        }

        public void ShowEmpleado(Empleado empelado, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de Empleado";
            emp = empelado;
            this.IdMsk.Enabled = false;
            this.NombreTxt.Text = emp.Nombre;
            this.ApellidoTxt.Text = emp.Apellido;
            this.IdMsk.Text = emp.EmpleadoId.ToString();
            this.FechaNacimientoTxt.Text = emp.FechaNac.ToString();
            this.ReportarATxt.Text = emp.ReportaA.ToString();
            this.ExtensionTxt.Text = emp.Extension.ToString();
            this.ShowDialog();
        }
        public void NewEmpleado(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Empleado";
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
                    emp = new Empleado();
                    //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                }
                /* Comprobar que esten los datos obligatorios*/
                emp.Nombre = this.NombreTxt.Text;
                emp.Apellido = this.ApellidoTxt.Text;
                emp.FechaNac = Convert.ToDateTime(this.FechaNacimientoTxt.Text);
                if (this.ReportarATxt.Text != "")
                    emp.ReportaA = Convert.ToInt32(this.ReportarATxt.Text, 10);
                else
                    emp.ReportaA = 0;
                emp.Extension = Convert.ToInt32(this.ExtensionTxt.Text, 10); 
                if (!emp.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo Empleado" : "Error al intentar editar informacion de Empleado", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nuevo Empleado dado de alta" : "Actualizacion de informacion de Empleado", operacion == OperacionForm.frmAlta ? "Ingreso de Empleado..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo Empleado" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //_frmGrid.ReloadGrid();
            this.Dispose();
        }
    }
}
