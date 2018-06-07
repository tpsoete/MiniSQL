using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    public partial class MiniSQL
    {
        bool checkSyntax(string sql)
        {
            return false;
        }

        Request parse(string sql)
        {
            return null;
        }

        bool checkLexeme(Request request)
        {
            return false;
        }

        Response execute(Request request)
        {
            return null;
        }
    }
}