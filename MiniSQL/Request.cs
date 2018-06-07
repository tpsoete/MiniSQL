using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    // drop
    class Request
    {
        public enum QueryType
        {
            Invalid, Select, Insert, Delete, Create, Drop
        }

        public QueryType type;
        public string target;  // table或index
    }

    // insert
    class InsertRequest : Request
    {
        public List<string> inserted;
    }

    // select delete
    class SelectRequest : Request
    {
        public List<string> columns;
        public List<Condition> condition;
    }

    // create
    class CreateRequest : Request
    {
        public List<TableColumn> attributes;
        public string pkey;
        public int rowSize;
    }
}
