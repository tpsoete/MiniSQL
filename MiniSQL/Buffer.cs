using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    class Buffer
    {
        List<Block> buffer;

        bool addBlock(Block b) { return false; }

        bool LRUreplace(Block b) { return false; }

        bool isDirty(Block b) { return false; }

        bool pin(Block b) { return false; }
    }
}
