/******************
*修改时间：2019/1/19 18:39:25
*修改人:qiuguochao
******************/
using Newtonsoft.Json;
using RemoteDesktop.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktop.Helper
{
    public class DataHelper
    {
        private static string DataPath =  Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private const string DataName = "save.rd";
        public static string FilePath;
        private static Base dataObj = null;
        public static Base CurrentData
        {
            get
            {
                if (dataObj==null)
                {
                    dataObj = ReadData();
                }
                return dataObj;
            }
        }
        static DataHelper()
        {
            DirectoryInfo dir = new DirectoryInfo(DataPath);
            if (!dir.Exists)
            {
                dir.Create();
            }
            FilePath = Path.Combine(DataPath, DataName);
        }

        public static Base ReadData()
        {
            var result = string.Empty;       
            //读物文件
            using (FileStream fsRead = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                int fsLen = (int)fsRead.Length;
                byte[] hebyte = new byte[fsLen];
                int r = fsRead.Read(hebyte, 0, hebyte.Length);
                Encoding encode = Encoding.UTF8;
                //以Unicode方式读取文件
                var decStr = EncryptDecryptHelper.DESDecrypt(encode.GetString(hebyte));
                result = decStr == null?"": decStr;
            }
            return IfNull(JsonConvert.DeserializeObject<Base>(result));
        }
        public static void SaveData()
        {
            var str = JsonConvert.SerializeObject(CurrentData);
            using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs);             
                sw.Write(EncryptDecryptHelper.DESEncrypt(str));
                sw.Flush();
                sw.Close();
            }
        }
        public static IEnumerable<Node> GetNodeLevelData(Enums.LevelEnum level)
        {
            return CurrentData.Nodes.Where(p => p.Level == (int)level);
        }

        public static string GetGuild()
        {
            return System.Guid.NewGuid().ToString("N");
        }
        public static Base IfNull(Base obj)
        {
            if (obj == null)
            {
                obj = new Base();
            }
            if (obj.Nodes == null)
            {
                obj.Nodes = new List<Node>();
            }
            if (obj.Servers == null)
            {
                obj.Servers = new List<Server>();
            }
            return obj;
        }
    }
}
