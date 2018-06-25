using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class DetalleOrden : CommonObj, IAccessDB<DetalleOrden>, ITable
    {
        private string[] _columns = { "orden_id", "detalle_id", "producto_id", "cantidad" };
        public List<DetalleOrden> findAll()
        {
            return this.findAll(null);
        }
        public List<DetalleOrden> findAll(string criterio)
        {
            return ManagerDB<DetalleOrden>.findAll(criterio);
        }
        public DetalleOrden findbykey(params object[] key)
        {
            DetalleOrden p = (DetalleOrden)ManagerDB<DetalleOrden>.findbyKey(key);
            this.DetalleId = p.DetalleId;
            this.OrdenId = p.OrdenId;
            this.ProductoId = p.ProductoId;
            this.Cantidad = p.Cantidad;            
            this.IsNew = false;
            return this;          
        }
        public bool saveObj()
        {
            return ManagerDB<DetalleOrden>.saveObject(this);
        }

        public string TableName
        {
            get { return "detalle_ordenes"; }
        }

        public string KeyTable
        {
            get { return ""; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._orden_id = Int32.Parse(dr[_columns[0]].ToString());
            this._detalle_id = Int32.Parse(dr[_columns[1]].ToString());
            this._producto_id = Int32.Parse(dr[_columns[2]].ToString());
			this._cantidad = Int32.Parse(dr[_columns[3]].ToString());            
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "orden_id", "detalle_id", "producto_id", "cantidad"
            string[] values = {                                 
                                  (this.IsNew?"":_columns[0] + "=")+this._orden_id.ToString(),
                                  (this.IsNew?"":_columns[1] + "=")+this._detalle_id.ToString(),
                                  (this.IsNew?"":_columns[2] + "=")+this._producto_id.ToString(),
                                  (this.IsNew?"":_columns[3] + "=")+this._cantidad.ToString(),
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns).Replace("orden_id,","") : vvalues), (this.IsNew ? vvalues : String.Format("orden_id = {0}", this.OrdenId)));
            }
        }

        public void setKeyValue(object valueId)
        {
            throw new NotImplementedException();
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("orden_id = {0}", values[0]);
        }
    }
}
