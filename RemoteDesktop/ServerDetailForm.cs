using CCWin;
using RemoteDesktop.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteDesktop
{
    public partial class ServerDetailForm  : Skin_Color
    {
        public ServerDetailForm(Form f)
        {
            InitializeComponent();
            initShow(f);
        }

        public void initShow(Form frm1)
        {
            //Form1 frm1 = (Form1)this.Owner;
            var currentNode = ((TreeView)frm1.Controls["treeView1"]).SelectedNode;
            var servers = DataHelper.CurrentData.Servers.Where(p => p.ServerGuid == currentNode.Name);
            var typeData = DataHelper.GetNodeLevelData(Enums.LevelEnum.TypeNode);
            if (servers.Count() > 0)
            {
                var obj = servers.FirstOrDefault();
                this.ServerType.Text = typeData.Where(t => t.NodeGuid == currentNode.Parent.Name).FirstOrDefault().NodeName;
                this.IPText.Text = obj.Ip;
                this.Domain.Text = obj.Domain;
                this.UserName.Text = obj.UserName;
                this.Password.Text = obj.Password;
                this.Text= obj.Ip;
            }
            else
            {
                MessageBox.Show("获取详情出错！", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
