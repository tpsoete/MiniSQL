using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    partial class MiniSQL
    {
        bool tableExists(string table);

        int fieldCount(string table);

        int indexCount(string table);

        List<string> fieldsOnTable(string table);

        List<string> indicesOnTable(string table);

        int rowLength(string table);

        string pkOnTable(string table);

        FieldType fieldType(string table, string field);

        bool isUnique(string table, string field);

        bool isPK(string table, string field);

        bool hasIndex(string table, string field);

        string indexName(string table, string field);

        string tableIndexOn(string index);

        string fieldIndexOn(string index);

        bool addTable();

        bool deleteTable(string table);

        bool addIndex();

        bool deleteIndex(string index);

        bool storeToFile();
    }
}