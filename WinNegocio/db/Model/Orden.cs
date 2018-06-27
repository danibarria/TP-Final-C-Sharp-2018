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
        private Empleado _empleado=null;
		private int _cliente_id;
        private Cliente _cliente=null;
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



        public Empleado EmpleadoObj
        {
            get
            {
                if (this._empleado_id != 0 && this._empleado == null)
                {
                     _empleado= new Empleado();
                    _empleado.findbykey(_empleado_id);
                }
                return _empleado;
            }
            set
            {
                if (value == null)
                {
                    _empleado_id = 0;
                }
                else
                {
                    if (value.EmpleadoId != _empleado_id)
                        _empleado_id = value.EmpleadoId;
                }
                _empleado = value;
            }
        }


        public Cliente ClienteObj
        {
            get
            {
                if (this._cliente_id != 0 && this._cliente == null)
                {
                    _cliente = new Cliente();
                    _cliente.findbykey(_cliente_id);
                }
                return _cliente;
            }
            set
            {

                if (value == null)
                {
                    _cliente_id = 0;
                }
                else
                {
                    if (value.ClienteId != _cliente_id)
                        _cliente_id = value.ClienteId;
                }
                _cliente = value;
            }
        }

        #endregion

    }
}
