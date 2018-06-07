using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class Index
    {
        public string name;
        public string table, field;
        Address addr;
    }


    public partial class MiniSQL
    {
        bool createIndex(string table, string field, string indexName)
        {
            return false;
        }

        bool dropIndex(string index)
        {
            return false;
        }

        List<Address> select(Index index, List<Condition> conditions)
        {
            return null;
        }

        bool insert(Index index, object data, FieldType type, Address addr)
        {
            return false;
        }

        List<Address> delete(Index index, List<Condition> conditions)
        {
            return null;
        }
    }
}