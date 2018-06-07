using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class BlockAddress
    {
        public string file;
        public int fileOffset;
    }

    class Address : BlockAddress
    {
        public int blockOffset;
    }
}
