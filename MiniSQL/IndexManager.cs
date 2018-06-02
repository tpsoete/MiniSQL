using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    partial class MiniSQL
    {
        bool createIndex(string table, string field);

        bool dropIndex(string index);

        List<Address> select(string index, List<Condition> conditions);

        bool insert(string index, object data, FieldType type, Address addr);

        List<Address> delete(string index, List<Condition> conditions);
    }
}