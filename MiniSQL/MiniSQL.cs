using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace MiniSQL
{
    public partial class MiniSQL
        //: API, BufferManager, CatalogManager, IndexManager, Interpreter, RecordManager
    {
        Dictionary<string, Table> tables;
        Dictionary<string, Index> indices;

        public string log;
        bool quit = false;

        public MiniSQL(string workspace)
        {
            tables = new Dictionary<string, Table>();
            indices = new Dictionary<string, Index>();
            log = "";
            Directory.SetCurrentDirectory(workspace);
        }

        ~MiniSQL()
        {

        }

        void addLog(string msg)
        {
            log += msg + Environment.NewLine;
        }

        void clearLog()
        {
            log = "";
        }

        // 执行单独的SQL语句
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

        // 拆分并识别命令（quit, execfile)
        public DataSet command(string cmd)
        {
            return null;
        }

        public DataSet execfile(string filename)
        {
            return new DataSet();
        }



        public void Test(string input)
        {
            // 测试内容
            clearLog();
            string[] sa = input.Split(' ');
            if (sa.Length < 2) addLog("Invalid input");
            else
            {
                int ans = int.Parse(sa[0]) + int.Parse(sa[1]);
                addLog(ans.ToString());
            }
        }
    }
}
