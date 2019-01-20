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
    public partial class AddServerForm : Skin_Color
    {
        private string currentSelectGuid = string.Empty;
        public AddServerForm(string currentGuid)
        {
            InitializeComponent();
            InitDropDownData(currentGuid);
        }
        private void InitDropDownData(string currentGuid)
        {
            var typeData = DataHelper.GetNodeLevelData(Enums.LevelEnum.TypeNode);
            this.comboBox1.DataSource = typeData.ToList();
            this.comboBox1.ValueMember = "NodeGuid";
            this.comboBox1.DisplayMember = "NodeName";
            if (!string.IsNullOrEmpty(currentGuid))
            {
                this.comboBox1.SelectedValue = currentGuid;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("请先添加分类！", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(this.textBox3.Text) || string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("请输入IP或用户名！", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form1 frm1 = (Form1)this.Owner;
            var rollingBar = ((CCWin.SkinControl.SkinRollingBar)frm1.Controls["skinRollingBar1"]);
            try
            {
                rollingBar.Visible = true;
                rollingBar.StartRolling();
                var guid = DataHelper.GetGuild();
                var selectedValue = this.comboBox1.SelectedValue.ToString();
                DataHelper.CurrentData.Nodes.Add(new Model.Node
                {
                    Level = (int)Enums.LevelEnum.ServerNode,
                    NodeGuid = guid,
                    ParentGuid = selectedValue,
                    NodeName = this.textBox1.Text
                });
                DataHelper.CurrentData.Servers.Add(new Model.Server
                {
                    ServerGuid = guid,//与nodeguid一致
                    Ip = this.textBox1.Text,
                    UserName = this.textBox3.Text,
                    Password = this.textBox4.Text,
                    Domain = this.textBox2.Text
                });
                DataHelper.SaveData();
                //在父窗口添加节点
                TreeNode tchild = new TreeNode();
                tchild.Name = guid;
                tchild.Text = this.textBox1.Text;
                tchild.ImageIndex = 3;
                tchild.SelectedImageIndex = 3;
                var parentNode = ((TreeView)frm1.Controls["treeView1"]).Nodes.Find(selectedValue, true)[0];
                parentNode.Nodes.Add(tchild);
                parentNode.ExpandAll();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                rollingBar.StopRolling();
                rollingBar.Visible = false;
            }
          

        }
    }
}
