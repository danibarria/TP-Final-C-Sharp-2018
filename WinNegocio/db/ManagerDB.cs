using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;

namespace LibNegocio.db
{
    public class ManagerDB<T> where T : ITable, new()
    {
        public static List<T> findAll()
        {
            T clase = new T();
            List<T> list = null;
            
            DataTable dt = AccessDB.getExecuteSQL(String.Format("select {0} from {1};", String.Join(",", clase.columns),clase.TableName));
            if (dt != null)
            {
                list = new List<T>();
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    T obj = new T();
                    obj.initialize(dt.Rows[i]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public static List<T> findAll(string criterio)
        {
            T clase  = new T();
            List<T> list = null;
            if (criterio == null)
                criterio = "";
            DataTable dt = AccessDB.getExecuteSQL(String.Format("select {0} from {1} {2};", String.Join(",", clase.columns), clase.TableName, (criterio == "" ? "" : " where " + criterio)));            
            if (dt != null)
            {
                list = new List<T>();
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    T obj = new T();
                    obj.initialize(dt.Rows[i]);
                    list.Add(obj);
                }
            }
            return list;            
        }
        public static T findbyKey(params object[] values)
        {
            T clase = new T();

            DataTable dt = AccessDB.getExecuteSQL(String.Format("select {0} from {1} {2};", String.Join(",", clase.columns), clase.TableName, " where " + clase.sqlKeyWhere(values)));
            if (dt != null)
            {
                T obj = new T();
                obj.initialize(dt.Rows[0]);
                (obj as CommonObj).IsNew = false; //marcar que es una instancia recuperada desde la BD
                return obj;
            }
            return default(T);
        }
        public static bool saveObject(T obj)
        {
            T clase = new T();
            DataTable dt = null;
            NpgsqlTransaction tx=null;
            AccessDB.conn.ConnectionString = AccessDB.CadenaConexion;
            AccessDB.conn.Open();
            try
            {
                // iniciar transaccion 
                tx = AccessDB.conn.BeginTransaction();
                if (obj.IsNew)
                {
                    if (obj is IAutoIncrement) //
                    {//recuperar siguiente valor
                        dt = AccessDB.getExecuteSQL(String.Format("select max({0})+1 from {1} ;", clase.KeyTable, clase.TableName), true);
                        if (dt != null)//recuperar maximo id + 1
                            obj.setKeyValue(dt.Rows[0][0]);
                    }
                }
                AccessDB.getExecuteSQL(obj.SqlString,true);
                tx.Commit();
                AccessDB.conn.Close();
                return true;
            }
            catch (Exception)
            {
                if (tx != null)
                    tx.Rollback();
                AccessDB.conn.Close();
                return false;
            }
        }
    }
}
