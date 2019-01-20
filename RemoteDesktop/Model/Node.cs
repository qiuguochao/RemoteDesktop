/******************
*修改时间：2019/1/19 20:15:57
*修改人:qiuguochao
******************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteDesktop.Model
{
    public class Node
    {
        /// <summary>
        /// 标识
        /// </summary>
        public string NodeGuid { get; set; }
        /// <summary>
        /// 节点层级（0 主节点、1 服务器分类 、2 远程服务器）
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentGuid { get; set; }
    }
}
