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
        private Empleado _reporta_empleado=null;
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

        public Empleado ReportaEmpleadoObj
        {
            get
            {
                if (this._reporta_a != 0 && this._reporta_empleado == null)
                {
                    _reporta_empleado = new Empleado();
                    _reporta_empleado.findbykey(_reporta_a);
                }
                return _reporta_empleado;
            }
            set
            {
                if (value == null)
                {
                    _reporta_a = 0;
                }
                else
                {
                    if (value.EmpleadoId != _reporta_a)
                        _reporta_a = value.EmpleadoId;
                }
                _reporta_empleado = value;
            }
        }
        
        #endregion

    }
}
