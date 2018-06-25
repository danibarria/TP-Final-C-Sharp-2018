using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Empleado
    {// Agregar Objeto Relacion:ReportaA Ver en Model/Producto.cs ejemplo

        #region variables locales
        private int _empleado_id;
        private string _nombre;
		private DateTime _fecha_nac;
		private string _apellido;
        private int _reporta_a;
        private int _extension;
		#endregion

        #region propiedades publicas
        
        public int EmpleadoId
        {
            get { return _empleado_id; }
            set { _empleado_id = value; }
        }

        public DateTime FechaNac
        {
            get { return _fecha_nac; }
            set { _fecha_nac = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int ReportaA
        {
            get { return _reporta_a; }
            set { _reporta_a = value; }
        }
        
        public int Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }
        
        #endregion

    }
}
