using System;
using System.Windows.Forms;
using LibNegocio.db;

namespace WinNegocio.Formularios
{
    public enum OperacionForm
    {
        frmConsulta =0, frmAlta=1,frmModificacion=2
    }

    public partial class ClienteAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;
                
        Cliente cl;
        private bool _val=false;
        public ClienteAMFrm()
        {
            InitializeComponent();
        }
        public void ShowCliente(Cliente cliente, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de cliente";
            cl = cliente;
            this.IdMsk.Enabled = false;
            this.CedulaRucTxt.Text = cl.NombreCia;
            this.NombreCiaTxt.Text = cl.CedulaRuc;
            this.IdMsk.Text = cl.ClienteId.ToString();
            this.ContactoTxt.Text = cl.NombreContacto;
            this.DireccionTxt.Text = cl.DirCliente;
            
            this.ShowDialog();
        }
        public void NewCliente(IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo Cliente";
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
                     cl = new Cliente();
                 }
                 /* Comprobar que esten los datos obligatorios*/
                 cl.NombreCia = this.NombreCiaTxt.Text;

                 System.Convert.ToInt32(this.CedulaRucTxt.Text, 10);
                 cl.CedulaRuc = this.CedulaRucTxt.Text;

                 cl.NombreContacto = this.ContactoTxt.Text;
                 cl.DirCliente = this.DireccionTxt.Text;
                 cl.Fax = this.FaxTxt.Text;
                 cl.Email = this.EmailTxt.Text;
                 cl.Celular = this.CelularTxt.Text;
                 cl.Fijo = this.FijoTxt.Text;
                 if (!this._val)
                     return;
                 if (!cl.saveObj())
                 {
                     MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo Cliente" : "Error al intentar editar informacion de Cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
                 MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nuevo Cliente dado de alta" : "Actualizacion de informacion de Cliente", operacion == OperacionForm.frmAlta ? "Ingreso de paciente..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             catch (FormatException ex)
             {
                 MessageBox.Show("Formate invalido");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo Cliente" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
           //_frmGrid.ReloadGrid();
            
        }

        private void ClientesAMFrm_Load(object sender, EventArgs e)
        {

        }

        private void CedulaRucTxt_Leave(object sender, EventArgs e)
        {

            if (!PrincipalFrm.ValidarNumero(CedulaRucTxt.Text))
            {
                CedulaRucTxt.Focus();
                CedulaRucTxt.BackColor = System.Drawing.Color.IndianRed;
                this._val = false;
            }
            else
            {
                CedulaRucTxt.BackColor = System.Drawing.Color.White;
                this._val = true;
            }
        }

        private void CedulaRucTxt_Validated(object sender, EventArgs e)
        {

        }

        private void FaxTxt_Leave(object sender, EventArgs e)
        {
            if (!PrincipalFrm.ValidarNumero(FaxTxt.Text))
            {
                FaxTxt.Focus();
                FaxTxt.BackColor = System.Drawing.Color.IndianRed;
                this._val = false;
            }
            else
            {
                FaxTxt.BackColor = System.Drawing.Color.White;
                this._val = true;
            }
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
