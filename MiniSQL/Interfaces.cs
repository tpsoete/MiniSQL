using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    interface API
    {
        Response createTable(Request request);
        Response dropTable(Request request);
        Response createIndex(Request request);
        Response dropIndex(Request request);
        Response select(Request request);
        Response insert(Request request);
        Response delete(Request request);
    }

    interface BufferManager
    {
        byte[] read(Address addr);
        bool write(Address addr, byte[] data);
        Address findFreeSpace(string table);
        bool free(Address addr);
        Block readFromFile(string file, int offset);
        bool writeToFile(Block b, string file, int offset);
    }

    interface CatalogManager
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

    interface IndexManager
    {
        bool createIndex(string table, string field, string indexName);
        bool dropIndex(string index);
        List<Address> select(Index index, List<Condition> conditions);
        bool insert(Index index, object data, FieldType type, Address addr);
        List<Address> delete(Index index, List<Condition> conditions);
    }

    interface Interpreter
    {
        bool checkSyntax(string sql);
        Request parse(string sql);
        bool checkLexeme(Request request);
        Response execute(Request request);
    }

    interface RecordManager
    {
        bool createTable(Table table);
        bool dropTable(Table table);
        List<TableRow> select(Table table, List<Condition> conditions);
        Address insert(Table table, List<string> data);
        int delete(Table table, List<Condition> conditions);
        List<TableRow> select(List<Address> addr);
        int delete(List<Address> addr);
    }
}
