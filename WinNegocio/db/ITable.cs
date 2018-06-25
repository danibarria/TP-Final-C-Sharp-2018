using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public interface ITable
    {
        bool IsNew { get; }
        string TableName{ get;}
        string KeyTable { get; }
        string[] columns { get; }
        string SqlString {get;}        
        void initialize(DataRow dr);
        void setKeyValue(object valueId);
        string sqlKeyWhere(params object[] values);
    }
    public interface IAutoIncrement
    {
    }
}
