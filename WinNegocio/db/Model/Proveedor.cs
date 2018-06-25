using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Proveedor
    {
        #region variables locales
        private int _proveedor_id;
        private string _nombre_proveedor;
        private string _contacto_proveedor;
        private string _celu_proveedor;
        private string _fijo_proveedor;
		#endregion
        
        #region propiedades publicas
        public string FijoProveedor
        {
            get { return _fijo_proveedor; }
            set { _fijo_proveedor = value; }
        }
        public string CeluProveedor
        {
            get { return _celu_proveedor; }
            set { _celu_proveedor = value; }
        }
        public string ContactoProveedor
        {
            get { return _contacto_proveedor; }
            set { _contacto_proveedor = value; }
        }
        public string NombreProveedor
        {
            get { return _nombre_proveedor; }
            set { _nombre_proveedor = value; }
        }
		
        public int ProveedorId
        {
            get { return _proveedor_id; }
            set { _proveedor_id = value; }
        }
        
        #endregion
        
    }
}
