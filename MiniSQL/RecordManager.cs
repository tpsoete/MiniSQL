using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    public partial class MiniSQL
    {
        bool createTable(Table table)
        {
            return false;
        }

        bool dropTable(Table table)
        {
            return false;
        }

        List<TableRow> select(Table table, List<Condition> conditions)
        {
            return null;
        }

        Address insert(Table table, List<string> data)
        {
            return null;
        }

        int delete(Table table, List<Condition> conditions)
        {
            return 0;
        }

        List<TableRow> select(List<Address> addr)
        {
            return null;
        }

        int delete(List<Address> addr)
        {
            return 0;
        }
    }
}