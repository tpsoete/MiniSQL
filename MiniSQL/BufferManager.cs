using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    partial class MiniSQL
    {
        byte[] read(Address addr);
        bool write(Address addr, byte[] data);
        Address findFreeSpace(string table);
        bool free(Address addr);



        Block readFromFile(string file, int offset);
        bool writeToFile(Block b, string file, int offset);
    }
}