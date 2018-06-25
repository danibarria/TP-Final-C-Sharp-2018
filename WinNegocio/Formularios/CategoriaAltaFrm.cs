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

        private void AltaCategoria_TextChanged(object sender, EventArgs e)
        {
            //unimplemented
        }
        private void Guardar_Click_1(object sender, EventArgs e)
        {
            nuevaCategoria = new Categoria();

            nuevaCategoria.NombreCategoria = this.AltaCategoria.Text;
            if (nuevaCategoria.findbykey(this.AltaCategoria.Text).CategoriaId > 0)
            {
                Console.WriteLine("ya existe");
            }
            else
            {
                nuevaCategoria.saveObj();
            }
            
            this.Dispose(); //cerrar ventana
        }
    }
}
