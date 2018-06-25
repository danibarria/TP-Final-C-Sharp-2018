using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Orden
    {
        // Agregar Objeto Relacion: Empleado, Cliente Ver en Model/Producto.cs ejemplo
        #region variables locales
        private int _orden_id;
        private int _empleado_id;
		private int _cliente_id;
		private DateTime _fecha_orden;     
		private int _descuento;        
        #endregion

        #region propiedades publicas
        
        public int OrdenId
        {
            get { return _orden_id; }
            set { _orden_id = value; }
        }

        public int ClienteId
        {
            get { return _cliente_id; }
            set { _cliente_id = value; }
        }

        public int EmpleadoId
        {
            get { return _empleado_id; }
            set { _empleado_id = value; }
        }

        public DateTime FechaOrden
        {
            get { return _fecha_orden; }
            set { _fecha_orden = value; }
        }
        
     		
		public int Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }				

        #endregion

    }
}
