using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class TableColumn
    {
        public string name;
        public FieldType type;
        public bool unique;
        public string index = null;
        public int offset;
    }

    class Table
    {
        public string name;
        public List<TableColumn> columns;
        public Dictionary<string, TableColumn> fields;
        public string pkey;
        public int rowSize;

        public string rowfile;

        public Table(CreateRequest request)
        {
            if (request.type != Request.QueryType.Create)
                throw new Exception("not a create request");
            name = request.target;
            columns = request.attributes;
            fields = new Dictionary<string, TableColumn>();
            foreach (TableColumn col in columns)
            {
                fields.Add(col.name, col);
            }
            pkey = request.pkey;
            rowSize = request.rowSize;
            rowfile = name + ".dat";
        }

        public Table(string filename)
        {
            throw new Exception("load table from file is not supported");
        }

        bool saveCatalog()
        {
            return false;
        }
    }
}
