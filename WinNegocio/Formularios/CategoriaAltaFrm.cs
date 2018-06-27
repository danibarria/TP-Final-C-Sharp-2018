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
    public partial class CategoriaAltaFrm : Form
    {
        IFormGridReload _frmGrid;
        OperacionForm operacion = OperacionForm.frmAlta;
        Categoria nuevaCategoria;
        public CategoriaAltaFrm()
        {
            InitializeComponent();
        }

        private void AgregarCategoria(object sender, EventArgs e)
        {

        }

        private void agregarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click_1(object sender, EventArgs e)
        {
            try 
            {
                if (this.operacion == OperacionForm.frmAlta)
                {
                    nuevaCategoria = new Categoria();

                }
                nuevaCategoria.NombreCategoria = this.AltaCategoria.Text;
                
                if (!nuevaCategoria.saveObj())
                {
                    MessageBox.Show(operacion == OperacionForm.frmAlta ? "Error al intentar ingresar nuevo Categoria" : "Error al intentar editar informacion de Categoria", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(operacion == OperacionForm.frmAlta ? "Nueva Categoria dado de alta" : "Actualizacion de informacion de Categoria", operacion == OperacionForm.frmAlta ? "Ingreso de Categoria..." : "Actualizacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //nuevaCategoria.saveObj();
                this.Dispose(); //cerrar ventana
            }catch(Exception ex){
                MessageBox.Show("Error al intentar " + (operacion == OperacionForm.frmAlta ? "ingresar nuevo Categoria" : "actualizar informacion") + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        public void ShowCategoria(Categoria c, IFormGridReload frmGrid)
        {
            _frmGrid = frmGrid;
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de infromacion de Categoria";
            nuevaCategoria = c;
            this.AltaCategoria.Text = nuevaCategoria.NombreCategoria;
            this.ShowDialog();
        }
    }
}
