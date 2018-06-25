using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Proveedor : CommonObj, IAccessDB<Proveedor>, ITable, IAutoIncrement
    {
        private string[] _columns = { "proveedor_id", "nombre_proveedor", "contacto", "celu_prov", "fijo_prov" };
        public List<Proveedor> findAll()
        {
            return this.findAll(null);
        }
        public List<Proveedor> findAll(string criterio)
        {
            return ManagerDB<Proveedor>.findAll(criterio);
        }
        public Proveedor findbykey(params object[] key)
        {
            Proveedor d = (Proveedor)ManagerDB<Proveedor>.findbyKey(key);
            this.ProveedorId = d.ProveedorId;
            this.NombreProveedor = d.NombreProveedor;
            this.ContactoProveedor = d.ContactoProveedor;
            this.CeluProveedor = d.CeluProveedor;
            this.FijoProveedor = d.FijoProveedor;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<Proveedor>.saveObject(this);
        }

        public string TableName
        {
            get { return "proveedores"; }
        }

        public string KeyTable
        {
            get { return "proveedor_id"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._proveedor_id = Int32.Parse(dr[_columns[0]].ToString());
            this._nombre_proveedor = dr[_columns[1]].ToString().Trim();
            this._contacto_proveedor = dr[_columns[2]].ToString().Trim();
            this._celu_proveedor = dr[_columns[3]].ToString().Trim();
            this._fijo_proveedor = dr[_columns[4]].ToString().Trim();
			this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            //  "proveedor_id", "nombre_proveedor", "contacto", "celu_prov", "fijo_prov"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._proveedor_id.ToString(),
                                (this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._nombre_proveedor), 
                                (this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._contacto_proveedor), 
                                (this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._celu_proveedor), 
                                (this.IsNew?"":_columns[4] + "=")+String.Format("'{0}'",this._fijo_proveedor), 
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("proveedor_id = {0}", this.ProveedorId)));
            }
        }
        // propiedad seteada por implementar IAutoIncrement
        public void setKeyValue(object valueId)
        {
            this._proveedor_id = Convert.ToInt32(valueId);
        }
        
        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("proveedor_id={0}", values[0]);
        }
    }
}

