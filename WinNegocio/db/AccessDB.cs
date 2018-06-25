using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Npgsql;

namespace LibNegocio.db
{
    public class AccessDB
    {
        public static Npgsql.NpgsqlConnection conn = new NpgsqlConnection();        
                    
        public static string CadenaConexion
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings["pgsqlContext"].ConnectionString; }            
        }
        public static void OpenConnDB()
        {

        }
        public static void CloseConnDB()
        {
        }
        public static DataTable getExecuteSQL(string sql, bool isTransaction=false)
        {
            DataSet ds = new DataSet();
            if (!isTransaction)
            {
                conn.ConnectionString = CadenaConexion;
                conn.Open();
            }
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            //Limpiar el dataset
            ds.Reset();
            // llenar con la definicion de la consulta
            da.Fill(ds);
            if(!isTransaction)
                conn.Close();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count == 0)
                    return null;
                return ds.Tables[0];
            }
            else
                return null;
        }
    }
}
