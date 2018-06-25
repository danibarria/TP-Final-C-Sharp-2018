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
                     //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                 }
               /* Comprobar que esten los datos obligatorios*/
                 cl.NombreCia = this.NombreCiaTxt.Text;
                 cl.CedulaRuc = this.CedulaRucTxt.Text; 
                 cl.NombreContacto = this.ContactoTxt.Text;
                 cl.DirCliente = this.DireccionTxt.Text;
                 cl.Fax = this.FaxTxt.Text;
                 cl.Email = this.EmailTxt.Text;
                 cl.Celular = this.CelularTxt.Text;
                 cl.Fijo = this.FijoTxt.Text;
                 if (!cl.saveObj())
                 {
                     MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo Cliente" : "Error al intentar editar informacion de Cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
                 MessageBox.Show(operacion == OperacionForm.frmAlta ?"Nuevo Cliente dado de alta":"Actualizacion de informacion de Cliente", operacion == OperacionForm.frmAlta ?"Ingreso de paciente...":"Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ?"ingresar nuevo Cliente":"actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
           //_frmGrid.ReloadGrid();
            this.Dispose();
        }

        private void ClientesAMFrm_Load(object sender, EventArgs e)
        {

        }

      
    }
}
