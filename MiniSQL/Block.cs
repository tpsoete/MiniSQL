using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class Block
    {
        string file;
        int fileOffset;
        int spaceUsed;
        bool isDirty;

        byte[] data;
    }
}
