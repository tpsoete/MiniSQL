using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    enum Operator { Equal, NotEqual, Less, Greater, LessEq, GreaterEq };

    class Condition
    {
        public string fieldName;
        public Operator op;
        public object right;

        public bool judge(object o)
        {
            return judge(o, op, right);
        }

        public static bool judge(object left, Operator op, object right)
        {
            string sl = left as string, sr = right as string;
            if ((sl != null) ^ (sr != null))
                return false;

            float? fl = left as float?, fr = right as float?;
            int? il = left as int?, ir = right as int?;

            switch (op) {
                case Operator.Equal:
                    if (sl != null) return sl == sr;
                    else return fl == fr || fl == ir || il == fr || il == ir;

                case Operator.NotEqual:
                    if (sl != null) return sl != sr;
                    else return fl != fr || fl != ir || il != fr || il != ir;

                case Operator.Less:
                    if (sl != null) return string.Compare(sl, sr) < 0;
                    else return fl < fr || fl < ir || il < fr || il < ir;

                case Operator.Greater:
                    if (sl != null) return string.Compare(sl, sr) > 0;
                    else return fl > fr || fl > ir || il > fr || il > ir;

                case Operator.LessEq:
                    if (sl != null) return string.Compare(sl, sr) <= 0;
                    else return fl <= fr || fl <= ir || il <= fr || il <= ir;

                case Operator.GreaterEq:
                    if (sl != null) return string.Compare(sl, sr) >= 0;
                    else return fl >= fr || fl >= ir || il >= fr || il >= ir;

                default:
                    throw new Exception("Wrong operator");
            }
        }
    }
}
