namespace RemoteDesktop
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("远程");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CCWin.SkinControl.SkinRollingBarThemeBase skinRollingBarThemeBase3 = new CCWin.SkinControl.SkinRollingBarThemeBase();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.远程ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.远程设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.远程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增远程服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.远程连接双击可ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.断开连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.断开连接并关闭选项卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大或双击选项卡标题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增服务器分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除服务器分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinRollingBar1 = new CCWin.SkinControl.SkinRollingBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.关闭选项卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.远程ToolStripMenuItem1,
            this.关于ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(8, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 21);
            this.toolStripMenuItem1.Text = "+新增服务器";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 远程ToolStripMenuItem1
            // 
            this.远程ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.远程设置ToolStripMenuItem,
            this.操作说明ToolStripMenuItem});
            this.远程ToolStripMenuItem1.Name = "远程ToolStripMenuItem1";
            this.远程ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.远程ToolStripMenuItem1.Text = "远程";
            // 
            // 远程设置ToolStripMenuItem
            // 
            this.远程设置ToolStripMenuItem.Name = "远程设置ToolStripMenuItem";
            this.远程设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.远程设置ToolStripMenuItem.Text = "远程设置";
            // 
            // 操作说明ToolStripMenuItem
            // 
            this.操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
            this.操作说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.操作说明ToolStripMenuItem.Text = "操作说明";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem1.Text = "关于";
            // 
            // 远程ToolStripMenuItem
            // 
            this.远程ToolStripMenuItem.Name = "远程ToolStripMenuItem";
            this.远程ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.远程ToolStripMenuItem.Text = "远程";
            // 
            // 新增远程服务ToolStripMenuItem
            // 
            this.新增远程服务ToolStripMenuItem.Name = "新增远程服务ToolStripMenuItem";
            this.新增远程服务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增远程服务ToolStripMenuItem.Text = "新增远程服务";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 4;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 20;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(8, 64);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.ImageKey = "c16.ico";
            treeNode1.Name = "mainNode";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "远程";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.SelectedImageIndex = 4;
            this.treeView1.Size = new System.Drawing.Size(238, 778);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "42.ico");
            this.imageList1.Images.SetKeyName(1, "c16.ico");
            this.imageList1.Images.SetKeyName(2, "resizeApi (1).png");
            this.imageList1.Images.SetKeyName(3, "122.png");
            this.imageList1.Images.SetKeyName(4, "0.ico");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详情ToolStripMenuItem,
            this.远程连接双击可ToolStripMenuItem,
            this.删除服务器ToolStripMenuItem,
            this.关闭选项卡ToolStripMenuItem,
            this.断开连接ToolStripMenuItem,
            this.断开连接并关闭选项卡ToolStripMenuItem,
            this.放大或双击选项卡标题ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 180);
            // 
            // 远程连接双击可ToolStripMenuItem
            // 
            this.远程连接双击可ToolStripMenuItem.Name = "远程连接双击可ToolStripMenuItem";
            this.远程连接双击可ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.远程连接双击可ToolStripMenuItem.Text = "远程连接（或双击）";
            this.远程连接双击可ToolStripMenuItem.Click += new System.EventHandler(this.远程连接双击可ToolStripMenuItem_Click);
            // 
            // 删除服务器ToolStripMenuItem
            // 
            this.删除服务器ToolStripMenuItem.Name = "删除服务器ToolStripMenuItem";
            this.删除服务器ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.删除服务器ToolStripMenuItem.Text = "删除该服务器";
            this.删除服务器ToolStripMenuItem.Click += new System.EventHandler(this.删除服务器ToolStripMenuItem_Click);
            // 
            // 断开连接ToolStripMenuItem
            // 
            this.断开连接ToolStripMenuItem.Name = "断开连接ToolStripMenuItem";
            this.断开连接ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.断开连接ToolStripMenuItem.Text = "断开连接";
            this.断开连接ToolStripMenuItem.Click += new System.EventHandler(this.断开连接ToolStripMenuItem_Click);
            // 
            // 断开连接并关闭选项卡ToolStripMenuItem
            // 
            this.断开连接并关闭选项卡ToolStripMenuItem.Name = "断开连接并关闭选项卡ToolStripMenuItem";
            this.断开连接并关闭选项卡ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.断开连接并关闭选项卡ToolStripMenuItem.Text = "断开连接并关闭选项卡";
            this.断开连接并关闭选项卡ToolStripMenuItem.Click += new System.EventHandler(this.断开连接并关闭选项卡ToolStripMenuItem_Click);
            // 
            // 放大或双击选项卡标题ToolStripMenuItem
            // 
            this.放大或双击选项卡标题ToolStripMenuItem.Name = "放大或双击选项卡标题ToolStripMenuItem";
            this.放大或双击选项卡标题ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.放大或双击选项卡标题ToolStripMenuItem.Text = "全屏(或双击选项卡标题)";
            this.放大或双击选项卡标题ToolStripMenuItem.Click += new System.EventHandler(this.放大或双击选项卡标题ToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增服务器分类ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 26);
            // 
            // 新增服务器分类ToolStripMenuItem
            // 
            this.新增服务器分类ToolStripMenuItem.Name = "新增服务器分类ToolStripMenuItem";
            this.新增服务器分类ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.新增服务器分类ToolStripMenuItem.Text = "新增服务器分类";
            this.新增服务器分类ToolStripMenuItem.Click += new System.EventHandler(this.新增服务器分类ToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增服务器ToolStripMenuItem,
            this.删除服务器分类ToolStripMenuItem,
            this.重命名ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(137, 70);
            // 
            // 新增服务器ToolStripMenuItem
            // 
            this.新增服务器ToolStripMenuItem.Name = "新增服务器ToolStripMenuItem";
            this.新增服务器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新增服务器ToolStripMenuItem.Text = "新增服务器";
            this.新增服务器ToolStripMenuItem.Click += new System.EventHandler(this.新增服务器ToolStripMenuItem_Click);
            // 
            // 删除服务器分类ToolStripMenuItem
            // 
            this.删除服务器分类ToolStripMenuItem.Name = "删除服务器分类ToolStripMenuItem";
            this.删除服务器分类ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除服务器分类ToolStripMenuItem.Text = "删除该分类";
            this.删除服务器分类ToolStripMenuItem.Click += new System.EventHandler(this.删除服务器分类ToolStripMenuItem_Click);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // skinRollingBar1
            // 
            this.skinRollingBar1.BaseColor = System.Drawing.Color.DodgerBlue;
            this.skinRollingBar1.DiamondColor = System.Drawing.Color.Transparent;
            this.skinRollingBar1.Location = new System.Drawing.Point(80, 67);
            this.skinRollingBar1.Name = "skinRollingBar1";
            this.skinRollingBar1.PenWidth = 1F;
            this.skinRollingBar1.Radius2 = 24;
            this.skinRollingBar1.Size = new System.Drawing.Size(22, 19);
            this.skinRollingBar1.SkinBackColor = System.Drawing.Color.White;
            this.skinRollingBar1.Style = CCWin.SkinControl.RollingBarStyle.ChromeOneQuarter;
            this.skinRollingBar1.TabIndex = 8;
            this.skinRollingBar1.TabStop = false;
            skinRollingBarThemeBase3.BackColor = System.Drawing.Color.White;
            skinRollingBarThemeBase3.BaseColor = System.Drawing.Color.DodgerBlue;
            skinRollingBarThemeBase3.DiamondColor = System.Drawing.Color.Transparent;
            skinRollingBarThemeBase3.PenWidth = 1F;
            skinRollingBarThemeBase3.Radius1 = 10;
            skinRollingBarThemeBase3.Radius2 = 24;
            skinRollingBarThemeBase3.SpokeNum = 12;
            this.skinRollingBar1.XTheme = skinRollingBarThemeBase3;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(246, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 778);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // 关闭选项卡ToolStripMenuItem
            // 
            this.关闭选项卡ToolStripMenuItem.Name = "关闭选项卡ToolStripMenuItem";
            this.关闭选项卡ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.关闭选项卡ToolStripMenuItem.Text = "关闭选项卡";
            this.关闭选项卡ToolStripMenuItem.Click += new System.EventHandler(this.关闭选项卡ToolStripMenuItem_Click);
            // 
            // 详情ToolStripMenuItem
            // 
            this.详情ToolStripMenuItem.Name = "详情ToolStripMenuItem";
            this.详情ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.详情ToolStripMenuItem.Text = "详情";
            this.详情ToolStripMenuItem.Click += new System.EventHandler(this.详情ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 850);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.skinRollingBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "远程桌面管理v1.0.0-【可乐不加冰】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 远程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增远程服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 远程ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 远程设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除服务器ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 新增服务器分类ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 新增服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除服务器分类ToolStripMenuItem;
        private CCWin.SkinControl.SkinRollingBar skinRollingBar1;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem 远程连接双击可ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 断开连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 断开连接并关闭选项卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大或双击选项卡标题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭选项卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详情ToolStripMenuItem;
    }
}

