using CCWin;
using RemoteDesktop.Helper;
using RemoteDesktop.Model;
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
    public partial class AddTypeForm : Skin_Color
    {
        public AddTypeForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.textBox1.Text))
                {

                    MessageBox.Show("请输入分类名称！", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var guid = DataHelper.GetGuild();
                var obj = DataHelper.CurrentData;
                Form1 frm1 = (Form1)this.Owner;

                obj.Nodes.Add(new Node
                {
                    Level = (int)Enums.LevelEnum.TypeNode,
                    NodeGuid = guid,
                    NodeName = this.textBox1.Text
                });
                //保存数据
                DataHelper.SaveData();
                TreeNode tchild = new TreeNode();
                tchild.Name = guid;
                tchild.Text = this.textBox1.Text;
                tchild.ImageIndex = 2;
                tchild.SelectedImageIndex = 2;
                //在父窗口添加节点
                ((TreeView)frm1.Controls["treeView1"]).Nodes[0].Nodes.Add(tchild);
                ((TreeView)frm1.Controls["treeView1"]).Nodes[0].ExpandAll();
                this.Close();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

    }
}
