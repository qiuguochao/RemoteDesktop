/******************
*修改时间：2019/1/19 20:02:53
*修改人:qiuguochao
******************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteDesktop.Model
{
    public class Server
    {
        public string ServerGuid { get; set; }

        public string Ip { get; set; }

        public string Domain { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
   
        public int RDPPort
        {
            get
            {
                return 3389;
            }
        }
    }
}
