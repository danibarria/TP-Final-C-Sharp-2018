using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    interface IAccessDB<T> 
    {
        List<T> findAll(string criterio);
        T findbykey(params object[] key);
        bool saveObj();        
    }
}
