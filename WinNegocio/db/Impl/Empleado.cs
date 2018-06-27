using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Empleado : CommonObj, IAccessDB<Empleado>, ITable, IAutoIncrement
    {
        private string[] _columns = { "empleado_id", "nombre", "apellido", "fecha_nac", "reporta_a", "extension" };
        public List<Empleado> findAll()
        {
            return this.findAll(null);
        }
        public List<Empleado> findAll(string criterio)
        {
            return ManagerDB<Empleado>.findAll(criterio);
        }
        public Empleado findbykey(params object[] key)
        {
            Empleado p = (Empleado)ManagerDB<Empleado>.findbyKey(key);
            this.FechaNac = p.FechaNac;
            this.Apellido = p.Apellido;
            this.Nombre = p.Nombre;
            this.EmpleadoId = p.EmpleadoId;
            this.IsNew = false;
            return this;          
        }
        public bool saveObj()
        {
            return ManagerDB<Empleado>.saveObject(this);
        }

        public string TableName
        {
            get { return "empleados"; }
        }

        public string KeyTable
        {
            get { return "empleado_id"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._empleado_id = Int32.Parse(dr[_columns[0]].ToString());
            this._nombre = dr[_columns[1]].ToString().Trim();
            this._apellido = dr[_columns[2]].ToString().Trim();
            this._fecha_nac = DateTime.Parse(dr[_columns[3]].ToString());
            if (dr[_columns[4]].ToString() == "")
            {
                this._reporta_a = 0;
            }
            else
            {
                this._reporta_a = Int32.Parse(dr[_columns[4]].ToString());
            }
            this._extension = Int32.Parse(dr[_columns[5]].ToString());
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "nombre", "apellido", "fecha_nac", "reporta_a", "extension"
            string[] values = { 
                                (this.IsNew?"":_columns[0] + "=")+String.Format("'{0}'",this._empleado_id),
                                (this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._nombre), //formato cadena ''
                                (this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._apellido),//formato cadena ''
                                (this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._fecha_nac.ToString("yyyy-MM-dd")), //formato cadena ''
                                (this.IsNew?"":_columns[4] + "=")+(this._reporta_a!=0?this._reporta_a.ToString():"null"),
                                (this.IsNew?"":_columns[5] + "=")+(this._extension.ToString())
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns)/*.Replace("empleado_id,","")*/ : vvalues), (this.IsNew ? vvalues : String.Format("empleado_id = {0}", this.EmpleadoId)));
            }
        }

        public void setKeyValue(object valueId)
        {
            this._empleado_id = Convert.ToInt32(valueId);
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("empleado_id = {0}", values[0]);
        }
    }
}
