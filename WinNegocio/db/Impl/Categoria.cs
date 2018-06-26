using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Categoria : CommonObj, IAccessDB<Categoria>, ITable, IAutoIncrement
    {
        private string[] _columns = { "categoria_id", "nombre_categoria" };
        public List<Categoria> findAll()
        {
            return this.findAll(null);
        }
        public List<Categoria> findAll(string criterio)
        {
            return ManagerDB<Categoria>.findAll(criterio);
        }
        public Categoria findbykey(params object[] key)
        {
            Categoria i = (Categoria)ManagerDB<Categoria>.findbyKey(key);
            this.CategoriaId = i.CategoriaId;
            this.NombreCategoria = i.NombreCategoria;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<Categoria>.saveObject(this);
        }

        public string TableName
        {
            get { return "categorias"; }
        }

        public string KeyTable
        {
            get { return "categoria_id"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this.categoria_id = Int32.Parse(dr[_columns[0]].ToString());
            this._nombre_categoria = dr[_columns[1]].ToString().Trim();
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this.categoria_id.ToString(),                                
                                (this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._nombre_categoria)
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("categoria_id = {0}", this.CategoriaId)));
            }
        }

        // propiedad seteada por implementar IAutoIncrement
        public void setKeyValue(object valueId)
        {
            this.categoria_id = Convert.ToInt32(valueId);
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("categoria_id={0}", values[0]);
        }
    }
}
