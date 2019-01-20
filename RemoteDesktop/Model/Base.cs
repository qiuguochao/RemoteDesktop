/******************
*修改时间：2019/1/19 18:58:51
*修改人:qiuguochao
******************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteDesktop.Model
{
    public class Base
    {

        public List<Node> Nodes { get; set; }

        public List<Server> Servers { get; set; }

        public void NewNodes(List<Node> list)
        {
            Nodes = new List<Node>(list);
        }
        public void NewNodes(List<Server> list)
        {
            Servers = new List<Server>(list);
        }

    }
}
