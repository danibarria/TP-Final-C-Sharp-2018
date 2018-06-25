using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibTurnos.db;

namespace WinTurnos.Formularios
{
    public partial class PacientesFrm : Form
    {
        public PacientesFrm()
        {
            InitializeComponent();
        }

        private void PacienteFrm_Load(object sender, EventArgs e)
        {
            /*
             * Se requiere este seteo para que se posibilite el mapeo de columnas que se Agregaron
             * desde el diseñador, Click con boton derecho sobre seleccion de grilla -> Edit Columns
            */
            this.gridPacientes.AutoGenerateColumns = false;
            List<Paciente>lista = ManagerDB<Paciente>.findAll();
            this.gridPacientes.DataSource = lista;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                PacientesAMFrm frm = new PacientesAMFrm();
                frm.ShowPaciente(senderGrid.Rows[e.RowIndex].DataBoundItem as Paciente,null);
            }
        }

        private void gridPacientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Paciente p;
            foreach (DataGridViewRow row in gridPacientes.Rows)
            {                
                DataGridViewCell cell;
                p = (row.DataBoundItem as Paciente);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}, {1}", p.Nombres, p.Apellido);
            }
        }

        private void NuevoPacienteBtn_Click(object sender, EventArgs e)
        {
            PacientesAMFrm frm = new PacientesAMFrm();

            frm.NewPaciente(null);
        }
    }
}
