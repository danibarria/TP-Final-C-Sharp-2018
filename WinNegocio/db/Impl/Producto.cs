using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Producto : CommonObj, IAccessDB<Producto>, ITable, IAutoIncrement
    {
        private string[] _columns = { "producto_id", "proveedor_id", "categoria_id", "descripcion", "precio_unit", "existencia" };
        public List<Producto> findAll()
        {
            return this.findAll(null);
        }
        public List<Producto> findAll(string criterio)
        {
            return ManagerDB<Producto>.findAll(criterio);
        }
        public Producto findbykey(params object[] key)
        {
            Producto d = (Producto)ManagerDB<Producto>.findbyKey(key);
            this.ProductoId = d.ProductoId;
            this.Descripcion = d.Descripcion;
            this.CategoriaId = d.CategoriaId;
            this.ProveedorId = d.ProveedorId;
            this.PrecioUnitario = d.PrecioUnitario;
            this.Existencia = d.Existencia;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<Producto>.saveObject(this);
        }

        public string TableName
        {
            get { return "productos"; }
        }

        public string KeyTable
        {
            get { return "producto_id"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._producto_id = Int32.Parse(dr[_columns[0]].ToString());
            this._proveedor_id = Int32.Parse(dr[_columns[1]].ToString());
            this._categoria_id = Int32.Parse(dr[_columns[2]].ToString());
            this._descripcion = dr[_columns[3]].ToString().Trim();
            this._precio_unit = Convert.ToDouble(dr[_columns[4]].ToString());
            this._existencia= Int32.Parse(dr[_columns[5]].ToString());            
			this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "producto_id", "proveedor_id", "categoria_id", "descripcion", "precio_unit", "existencia" 
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._producto_id.ToString(),
                                (this.IsNew?"":_columns[1] + "=")+this._proveedor_id.ToString(),
                                (this.IsNew?"":_columns[2] + "=")+this._categoria_id.ToString(),
                                (this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._descripcion),
                                (this.IsNew?"":_columns[4] + "=")+this._precio_unit.ToString(),
                                (this.IsNew?"":_columns[5] + "=")+this._existencia.ToString(),
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("producto_id = {0}", this.ProductoId)));
            }
        }
        // propiedad seteada por implementar IAutoIncrement
        public void setKeyValue(object valueId)
        {
            this._producto_id = Convert.ToInt32(valueId);
        }
        
        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("producto_id={0}", values[0]);
        }
    }
}

