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

        public BlockAddress(string filename, int offset)
        {
            file = filename;
            fileOffset = offset;
        }
    }

    class Address : BlockAddress
    {
        public int blockOffset;

        public Address(string filename, int foffset, int boffset)
            : base(filename, foffset)
        {
            blockOffset = boffset;
        }

        public Address(BlockAddress b, int boffset)
            : base(b.file, b.fileOffset)
        {
            blockOffset = boffset;
        }
    }
}
