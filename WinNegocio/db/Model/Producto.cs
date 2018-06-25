using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Producto
    {
        #region variables locales
        private int _producto_id;
        private int _proveedor_id;
        private int _categoria_id;
        private double _precio_unit;
        private int _existencia;

        private Categoria _categoria=null;
        
        private string _descripcion;
		#endregion
        
        #region propiedades publicas
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
		
        public int ProductoId
        {
            get { return _producto_id; }
            set { _producto_id = value; }
        }

        public int ProveedorId
        {
            get { return _proveedor_id; }
            set { _proveedor_id = value; }
        }

        public int CategoriaId
        {
            get { return _categoria_id; }
            set {
                if (value == 0)
                    _categoria = null;
                else
                {
                    if (_categoria != null && _categoria.CategoriaId != value)
                        _categoria_id = 0;
                }
                _categoria_id = value; }
        }

        public double PrecioUnitario
        {
            get { return _precio_unit; }
            set { _precio_unit = value; }
        }

        public int Existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
        }

        // Objeto Relacion con Categoria
        public Categoria CategoriaObj
        {
            get
            {
                if (this._categoria_id != 0 && this._categoria == null)
                {
                    _categoria = new Categoria();
                    _categoria.findbykey(_categoria_id);
                }
                return _categoria;
            }
            set
            {
                if (value == null)
                {
                    _categoria_id = 0;
                }
                else
                {
                    if (value.CategoriaId != _categoria_id)
                        _categoria_id = value.CategoriaId;
                }
                _categoria = value;
            }
        }

        private Proveedor _proveedor;

        public Proveedor ProveedorObj
        {
            get {
                if (this._proveedor_id != 0 && this._proveedor == null)
                {
                    _proveedor = new Proveedor();
                    _proveedor.findbykey(_proveedor_id);
                }                
                return _proveedor; }
            set {

                if (value == null)
                {
                    _proveedor_id = 0;
                }
                else
                {
                    if (value.ProveedorId != _proveedor_id)
                        _proveedor_id = value.ProveedorId;
                }
                _proveedor = value; }
        }

        
        #endregion
        
    }
}
