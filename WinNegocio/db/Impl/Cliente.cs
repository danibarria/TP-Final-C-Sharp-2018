using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Cliente : CommonObj, IAccessDB<Cliente>, ITable, IAutoIncrement
    {
        private string[] _columns = { "cliente_id", "cedula_ruc", "nombre_cia", "nombre_contacto", "dir_cliente", "fax", "email","celular","fijo" };
        public List<Cliente> findAll()
        {
            return this.findAll(null);
        }
        public List<Cliente> findAll(string criterio)
        {
            return ManagerDB<Cliente>.findAll(criterio);
        }
        public Cliente findbykey(params object[] key)
        {
            Cliente p = (Cliente)ManagerDB<Cliente>.findbyKey(key);
            this.ClienteId = p.ClienteId;
            this.CedulaRuc = p.CedulaRuc;
            this.NombreCia = p.NombreCia;
            this.NombreContacto = p.NombreContacto;            
            this.DirCliente = p.DirCliente;
            this.Fax = p.Fax;
            this.Email = p.Email;
            this.Celular = p.Celular;
            this.Fijo = p.Fijo;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<Cliente>.saveObject(this);
        }

        public string TableName
        {
            get { return "clientes"; }
        }

        public string KeyTable
        {
            get { return "cliente_id"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
            this._cliente_id = Int32.Parse(dr[_columns[0]].ToString());
            this._cedula_ruc = dr[_columns[1]].ToString().Trim();
			this._nombre_cia = dr[_columns[2]].ToString().Trim();
            this._nombre_contacto = dr[_columns[3]].ToString().Trim();
            this._dir_cliente = dr[_columns[4]].ToString().Trim();
            this._fax = dr[_columns[5]].ToString().Trim();
            this._email = dr[_columns[6]].ToString().Trim();
            this._celular = dr[_columns[7]].ToString().Trim();
            this._fijo = dr[_columns[8]].ToString().Trim();
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "cliente_id", "cedula_ruc", "nombre_cia", "nombre_contacto", "dir_cliente", "fax", "email","celular","fijo" 
            string[] values = { 
                                (this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._cedula_ruc), //formato cadena ''
                                (this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._nombre_cia),//formato cadena ''
                                (this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._nombre_contacto),//formato cadena ''
                                (this.IsNew?"":_columns[4] + "=")+String.Format("'{0}'",this._dir_cliente),//formato cadena ''
                                (this.IsNew?"":_columns[5] + "=")+String.Format("'{0}'",this._fax),//formato cadena ''
                                (this.IsNew?"":_columns[6] + "=")+String.Format("'{0}'",this._email),//formato cadena ''
                                (this.IsNew?"":_columns[7] + "=")+String.Format("'{0}'",this._celular),//formato cadena ''
                                (this.IsNew?"":_columns[8] + "=")+String.Format("'{0}'",this._fijo),//formato cadena ''
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("cliente_id = {0}", this.ClienteId)));
            }
        }

        public void setKeyValue(object valueId)
        {
            this._cliente_id= Convert.ToInt32(valueId);
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("cliente_id = {0}", values[0]);
        }        
    }
}
