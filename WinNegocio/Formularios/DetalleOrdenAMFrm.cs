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
    public partial class DetalleOrdenAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta;
        IFormGridReload _frmGrid;
        DetalleOrden dOrd;
        private string _det=null;
        private string _ord = null;
        public string Detalle 
        {
            set { _det = value; }
        }
        public string Orden
        {
            set { _ord = value; }
        } 
        public DetalleOrdenAMFrm()
        {
            InitializeComponent();
            this.ProductoCbo.DisplayMember = "Descripcion";
            this.ProductoCbo.ValueMember = "ProductoId";
            this.ProductoCbo.DataSource = ManagerDB<Producto>.findAll();
        }

        public void ShowDetalleOrden(DetalleOrden detalleOrden, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de DetalleOrden";
            dOrd = detalleOrden;
            this.IdMsk.Enabled = false;
            this.ProductoIdTxt.Text = dOrd.ProductoId.ToString();
            this.CantidadTxt.Text = dOrd.Cantidad.ToString();
            this.IdMsk.Text = dOrd.DetalleId.ToString();
            
            //prueba xd
            // propiedades del control a configurar para que se carguen en el control
            


            this.ShowDialog();
        }

        public void NewDetalleOrden(IFormGridReload frmGrid, string orden)
        {
            _frmGrid = frmGrid;
            this.Text = "Nuevo DetalleOrden";
            this.operacion = OperacionForm.frmAlta;
            this._ord = orden;
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
                if (this.operacion == OperacionForm.frmModificacion)
                {
                    dOrd.OrdenId = System.Convert.ToInt32(this._ord, 10);
                    dOrd.DetalleId = System.Convert.ToInt32(this.IdMsk.Text, 10);
                    dOrd.ProductoId = System.Convert.ToInt32(this.ProductoIdTxt.Text, 10);
                    dOrd.Cantidad = System.Convert.ToInt32(this.CantidadTxt.Text, 10);
                    //cl.ClienteId = Convert.ToInt32(this.IdMsk.Text);
                }
                else {
                    dOrd = new DetalleOrden();
                    dOrd.OrdenId = System.Convert.ToInt32(this._ord, 10);
                    dOrd.ProductoId = System.Convert.ToInt32(this.ProductoIdTxt.Text, 10);
                    dOrd.Cantidad = System.Convert.ToInt32(this.CantidadTxt.Text, 10);
                }

                if (!dOrd.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo DetalleOrde" : "Error al intentar editar informacion de DetalleOrden", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nuevo DetalleOrden dado de alta" : "Actualizacion de informacion de DetalleOrden", operacion == OperacionForm.frmAlta ? "Ingreso de DetalleOrden..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo DetalleOrden" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //_frmGrid.ReloadGrid();
            this.Dispose();
        }

        private void ProductoCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p = (this.ProductoCbo.SelectedItem as Producto);
            this.ProductoIdTxt.Text = p.ProductoId.ToString();
            //this.ProductoIdTxt.Text;
        }


    }
}
