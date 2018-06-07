using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class FieldType
    {
        const int MaxChar = 255, MaxCode = 257;

        public const int Int = 256, Float = 257, Invalid = 0;
        public static int Char(int i) {
            if (i > 0 && i <= MaxChar) return i;
            return Invalid;
        }

        static int check(int i)
        {
            if (i > MaxCode) return Invalid;
            if (i > 0) return Char(i);
            return i;
        }
        
        public readonly int code;

        public FieldType(int typecode)
        {
            code = check(typecode);
        }

        public FieldType(string typename)
        {
            string tn = typename.Trim().ToLower();
            try
            {
                if (tn.StartsWith("char") && tn.EndsWith(")"))
                {
                    int i = Convert.ToInt32(tn.Substring(5, tn.Length - 6));
                    code = Char(i);
                }
                else switch (tn) {
                        case "int": code = Int; break;
                        case "float": code = Float; break;
                        default: code = Invalid; break;
                    }
            }
            catch
            {
                code = Invalid;
            }
        }

        public bool IsChar
        {
            get
            {
                return code > 0 && code <= MaxChar;
            }
        }

        public int Size {
            get {
                switch (code) {
                    case Int: return sizeof(int);
                    case Float: return sizeof(float);
                    case Invalid: return 0;
                    default: return code;
                }
            }
        }
    }
}
