using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MiniSQL
{
    public partial class MiniSQL
        //: API, BufferManager, CatalogManager, IndexManager, Interpreter, RecordManager
    {
        Dictionary<string, Table> tables;
        Dictionary<string, Index> indices;

        public string log;
        public string path;

        public MiniSQL(string workspace)
        {
            tables = new Dictionary<string, Table>();
            indices = new Dictionary<string, Index>();
            log = "";
            path = workspace;
        }

        ~MiniSQL()
        {

        }

        void addLog(string msg)
        {
            log += msg + '\n';
        }

        void clearLog()
        {
            log = "";
        }


        public DataTable SQL(string sql)
        {
            try
            {
                log = sql;
                if (checkSyntax(sql))
                {
                    Request req = parse(sql);
                    if (checkLexeme(req))
                    {
                        Response res = execute(req);
                    }
                }
            }
            catch (Exception e)
            {
                addLog(e.Message);
            }
            return null;
        }

        public DataSet command(string cmd)
        {
            return null;
        }

        public DataSet execfile(string filename)
        {
            return new DataSet();
        }
    }
}
