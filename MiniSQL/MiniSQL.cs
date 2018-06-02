using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MiniSQL
{
    partial class MiniSQL
    {
        Dictionary<string, Table> tables;

        MiniSQL()
        {
            
        }

        ~MiniSQL()
        {

        }

        DataTable SQL(string sql)
        {
            return null;
        }

        DataSet execfile(string filename)
        {
            return new DataSet();
        }
    }
}
