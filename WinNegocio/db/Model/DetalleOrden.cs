using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class DetalleOrden
    {
        // Agregar Objeto Relacion: Orden, Producto Ver en Model/Producto.cs ejemplo
        #region variables locales
        private int _orden_id;
        private int _detalle_id;
		private int _producto_id;		
		private int _cantidad;        
        #endregion

        #region propiedades publicas
        
        public int OrdenId
        {
            get { return _orden_id; }
            set { _orden_id = value; }
        }

        public int ProductoId
        {
            get { return _producto_id; }
            set { _producto_id = value; }
        }

        public int DetalleId
        {
            get { return _detalle_id; }
            set { _detalle_id = value; }
        }

      
     		
		public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }				

        #endregion

    }
}
