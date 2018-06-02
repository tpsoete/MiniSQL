using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    partial class MiniSQL
    {
        bool checkSyntax(string sql);

        Request parse(string sql);

        bool checkLexeme(Request request);

        Response excute(Request request);
    }
}