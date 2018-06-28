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
    

    public partial class ProveedorAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;

        private bool _val= false;
        Proveedor prov;
        public ProveedorAMFrm()
        {
            InitializeComponent();
        }
        public void ShowProveedor(Proveedor proveedor, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de Proveedor";
            prov = proveedor;
            this.IdMsk.Enabled = false;
            this.NombreProveedorTxt.Text = prov.NombreProveedor;
            this.ContactoTxt.Text = prov.ContactoProveedor;
            this.IdMsk.Text = prov.ProveedorId.ToString();
            this.CelularTxt.Text = prov.CeluProveedor;
            this.FijoTxt.Text = prov.FijoProveedor;

            this.ShowDialog();
        }
        public void NewProveedor(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Proveedor";
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
                    prov = new Proveedor();
                    //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                }
                /* Comprobar que esten los datos obligatorios*/
                prov.NombreProveedor = this.NombreProveedorTxt.Text;
                prov.ContactoProveedor = this.ContactoTxt.Text;
                prov.CeluProveedor = this.CelularTxt.Text;
                prov.FijoProveedor = this.FijoTxt.Text;
                if (!this._val)
                    return;
                if (!prov.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo Proveedor" : "Error al intentar editar informacion de Proveedor", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nuevo Proveedor dado de alta" : "Actualizacion de informacion de Proveedor", operacion == OperacionForm.frmAlta ? "Ingreso de Proveedor..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo Proveedor" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //_frmGrid.ReloadGrid();
            this.Dispose();
        }

        private void CelularTxt_Leave(object sender, EventArgs e)
        {
            if (!PrincipalFrm.ValidarNumero(CelularTxt.Text))
            {
                CelularTxt.Focus();
                CelularTxt.BackColor = System.Drawing.Color.IndianRed;
                this._val = false;
            }
            else
            {
                CelularTxt.BackColor = System.Drawing.Color.White;
                this._val = true;
            }
        }

        private void FijoTxt_Leave(object sender, EventArgs e)
        {
            if (!PrincipalFrm.ValidarNumero(FijoTxt.Text))
            {
                FijoTxt.Focus();
                FijoTxt.BackColor = System.Drawing.Color.IndianRed;
                this._val = false;
            }
            else
            {
                FijoTxt.BackColor = System.Drawing.Color.White;
                this._val = true;
            }
        }

  

    }
}
