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
    public partial class OrdenDetalleResultsFrm : Form, IFormGridReload
    {
        OperacionForm operacion = OperacionForm.frmModificacion;

        string orden;
        public OrdenDetalleResultsFrm()
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

        public void ResultadosOrden(String ord)
        {
            this.gridDetalleOrden.AutoGenerateColumns = false;
            orden = ord;
            List<DetalleOrden> lista = ManagerDB<DetalleOrden>.findAll(String.Format("orden_id = '{0}'", ord));
            this.gridDetalleOrden.DataSource = lista;
            Cursor.Current = Cursors.Default;
            this.ShowDialog();
        }

        public void ReloadGrid()
        {
            this.gridDetalleOrden.Refresh();
        }

        private void gridOrden_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DetalleOrden proAborto;
            Producto proVida;
            foreach (var item in this.gridDetalleOrden.Rows)
            {
                proAborto = (item as DataGridViewRow).DataBoundItem as DetalleOrden;
                proVida = proAborto.ProductoObj;
                (item as DataGridViewRow).Cells[1].Value = proVida.Descripcion;
            }
        }
        private void gridDetalleOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.operacion == OperacionForm.frmModificacion)
            {
                DetalleOrdenAMFrm frm = new DetalleOrdenAMFrm();
                frm.Orden = orden;
                frm.ShowDetalleOrden((this.gridDetalleOrden.Rows[e.RowIndex].DataBoundItem as DetalleOrden), this);
            } 
        }

        private void AltaDetalleOrdenBtn_Click(object sender, EventArgs e)
        {
            if(this.operacion == OperacionForm.frmModificacion){
                DetalleOrdenAMFrm frm = new DetalleOrdenAMFrm();
                frm.NewDetalleOrden(null, orden);
            }
        }

        private void ModOrdenBtn_Click(object sender, EventArgs e)
        {
            if (this.operacion == OperacionForm.frmModificacion)
            {
                Orden ord = new Orden();
                ord=ord.findbykey(String.Format(orden));
                OrdenAMFrm frm = new OrdenAMFrm();
                frm.ShowOrden(ord, this);
            }
        }

    }
}
