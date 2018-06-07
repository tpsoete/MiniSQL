using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class Condition
    {
        public string fieldName;
        public string op;
        public object right;

        public bool judge(object o)
        {
            return true;
        }
    }
}
