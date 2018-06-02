using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    partial class MiniSQL
    {
        Response createTable(Request request);

        Response dropTable(Request request);

        Response createIndex(Request request);

        Response dropIndex(Request request);

        Response select(Request request);

        Response insert(Request request);

        Response delete(Request request);
    }
}
