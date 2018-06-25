using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Orden : CommonObj, IAccessDB<Orden>, ITable
    {
        private string[] _columns = { "orden_id", "empleado_id", "cliente_id", "fecha_orden", "descuento" };
        public List<Orden> findAll()
        {
            return this.findAll(null);
        }
        public List<Orden> findAll(string criterio)
        {
            return ManagerDB<Orden>.findAll(criterio);
        }
        public Orden findbykey(params object[] key)
        {
            Orden p = (Orden)ManagerDB<Orden>.findbyKey(key);
            this.OrdenId = p.OrdenId;
            this.ClienteId = p.ClienteId;
            this.EmpleadoId = p.EmpleadoId;
            this.FechaOrden = p.FechaOrden;            
            this.Descuento = p.Descuento;            
            this.IsNew = false;
            return this;          
        }
        public bool saveObj()
        {
            return ManagerDB<Orden>.saveObject(this);
        }

        public string TableName
        {
            get { return "ordenes"; }
        }

        public string KeyTable
        {
            get { return "orden_id"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._orden_id = Int32.Parse(dr[_columns[0]].ToString());
            this._empleado_id = Int32.Parse(dr[_columns[1]].ToString());
            this._cliente_id = Int32.Parse(dr[_columns[2]].ToString());
			this._fecha_orden = DateTime.Parse(dr[_columns[3]].ToString());
            this._descuento = Int32.Parse(dr[_columns[4]].ToString());            
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "orden_id", "empleado_id", "cliente_id", "fecha_orden", "descuento" 
            string[] values = { 
                                (this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._fecha_orden.ToString("yyyy-MM-dd HH:mm")),//formato cadena ''
                                (this.IsNew?"":_columns[4] + "=")+String.Format("'{0}'",this._descuento),//formato cadena ''                                
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
