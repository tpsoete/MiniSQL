using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    public partial class MiniSQL
    {
        bool tableExists(string table)
        {
            return tables.ContainsKey(table);
        }

        int fieldCount(string table)
        {
            return tables[table].columns.Count;
        }

        int indexCount(string table)
        {
            int i = 0;
            foreach (TableColumn col in tables[table].columns)
            {
                if (col.index != null) i++;
            }
            return i;
        }

        List<string> fieldsOnTable(string table)
        {
            List<string> ls = new List<string>();
            foreach (TableColumn col in tables[table].columns)
            {
                ls.Add(col.name);
            }
            return ls;
        }

        List<string> indicesOnTable(string table)
        {
            List<string> ls = new List<string>();
            foreach (TableColumn col in tables[table].columns)
            {
                if (col.index != null) ls.Add(col.index);
            }
            return ls;
        }

        int rowLength(string table)
        {
            return tables[table].rowSize;
        }

        string pkOnTable(string table)
        {
            return tables[table].pkey;
        }

        FieldType fieldType(string table, string field)
        {
            return tables[table].fields[field].type;
        }

        bool isUnique(string table, string field)
        {
            return tables[table].fields[field].unique;
        }

        bool isPK(string table, string field)
        {
            return field == pkOnTable(table);
        }

        bool hasIndex(string table, string field)
        {
            return tables[table].fields[field].index != null;
        }

        string indexName(string table, string field)
        {
            return tables[table].fields[field].index;
        }

        string tableIndexOn(string index)
        {
            return indices[index].table;
        }

        string fieldIndexOn(string index)
        {
            return indices[index].field;
        }

        bool addTable()
        {
            return false;
        }

        bool deleteTable(string table)
        {
            return false;
        }

        bool addIndex()
        {
            return false;
        }

        bool deleteIndex(string index)
        {
            return false;
        }

        bool storeToFile()
        {
            return false;
        }
    }
}