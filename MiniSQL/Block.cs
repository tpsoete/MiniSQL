using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class Block
    {
        public const int SIZE = 4096;

        public BlockAddress addr;
        public int spaceUsed;
        public bool isDirty;

        byte[] data;

        Block(string filename, int offset)
        {
            data = new byte[SIZE];
            addr.file = filename;
            addr.fileOffset = offset;
            spaceUsed = 0;
            isDirty = false;
        }

        public bool load()
        {
            return false;
        }

        public bool save()
        {
            return false;
        }
    }
}
