using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class TableRow
    {
        byte[] data;

        TableRow(int size)
        {
            data = new byte[size];
        }

        void set(TableColumn col, object val)
        {
            if (col.type.IsChar)
            {
                string str = val as string;
                if (str != null)
                {
                    int i, len = Math.Min(col.type.Size, str.Length);
                    for (i = 0; i < len; i++) data[col.offset + i] = (byte)str[i];
                    for (; i < col.type.Size; i++) data[col.offset + i] = (byte)' ';
                }
            }
            else
            {
                byte[] temp = null;
                if (col.type.code == FieldType.Int)
                {
                    int? i = val as int?;
                    if (i != null) temp = BitConverter.GetBytes((int)i);
                }
                else if (col.type.code == FieldType.Float)
                {
                    float? f = val as float?;
                    if (f != null) temp = BitConverter.GetBytes((float)f);
                }
                temp?.CopyTo(data, col.offset);
            }
        }

        object get(TableColumn col)
        {
            if (col.type.IsChar) return BitConverter.ToString(data, col.offset, col.type.Size); 
            else switch (col.type.code) {
                    case FieldType.Int: return BitConverter.ToInt32(data, col.offset);
                    case FieldType.Float: return BitConverter.ToSingle(data, col.offset);
                    default: return null;
                }
        }
    }
}
