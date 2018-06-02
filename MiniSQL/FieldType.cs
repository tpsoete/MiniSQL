using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class FieldType
    {
        readonly int code;

        FieldType(int c)
        {
            code = c;
        }

        public string Name()
        {
            if (code > 0) return string.Format("char({0})", code);
            else switch (code) {
                    case 0: return "int";
                    case -1: return "float";
                    default: throw new Exception(string.Format("Invalid FieldType code = {0}", code));
                }
        }

        // （伪）常量

        static readonly FieldType Int = new FieldType(0);
        static readonly FieldType Float = new FieldType(-1);
        
        static FieldType Char(int i)
        {
            if (i > 0 && i <= 255) return new FieldType(i);
            else throw new Exception(string.Format("Invalid FieldType Char({0})", i));
        }
    }
}
