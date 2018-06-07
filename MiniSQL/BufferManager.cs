using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    public partial class MiniSQL
    {
        byte[] read(Address addr)
        {
            return null;
        }

        bool write(Address addr, byte[] data)
        {
            return false;
        }

        Address findFreeSpace(string table)
        {
            return null;
        }
        bool free(Address addr)
        {
            return false;
        }


        Block readFromFile(string file, int offset)
        {
            return null;
        }
        bool writeToFile(Block b, string file, int offset)
        {
            return false;
        }
    }
}