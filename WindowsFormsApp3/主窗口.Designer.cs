namespace WindowsFormsApp3
{
    partial class 主窗口
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建家庭成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除家庭成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按关系删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按姓名删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改家庭成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按关系修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按姓名修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询家庭成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按亲戚关系查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按基本信息查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平均寿命ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.男女比例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家庭平均人口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家庭树ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.统计ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.新建ToolStripMenuItem.Text = "文件";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.新建成员ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建家庭成员ToolStripMenuItem,
            this.删除家庭成员ToolStripMenuItem,
            this.修改家庭成员ToolStripMenuItem,
            this.查询家庭成员ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 新建家庭成员ToolStripMenuItem
            // 
            this.新建家庭成员ToolStripMenuItem.Name = "新建家庭成员ToolStripMenuItem";
            this.新建家庭成员ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.新建家庭成员ToolStripMenuItem.Text = "新建家庭成员信息";
            this.新建家庭成员ToolStripMenuItem.Click += new System.EventHandler(this.新建家庭成员ToolStripMenuItem_Click);
            // 
            // 删除家庭成员ToolStripMenuItem
            // 
            this.删除家庭成员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按关系删除ToolStripMenuItem,
            this.按姓名删除ToolStripMenuItem});
            this.删除家庭成员ToolStripMenuItem.Name = "删除家庭成员ToolStripMenuItem";
            this.删除家庭成员ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.删除家庭成员ToolStripMenuItem.Text = "删除家庭成员信息";
            this.删除家庭成员ToolStripMenuItem.Click += new System.EventHandler(this.删除家庭成员ToolStripMenuItem_Click);
            // 
            // 按关系删除ToolStripMenuItem
            // 
            this.按关系删除ToolStripMenuItem.Name = "按关系删除ToolStripMenuItem";
            this.按关系删除ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按关系删除ToolStripMenuItem.Text = "按关系删除";
            this.按关系删除ToolStripMenuItem.Click += new System.EventHandler(this.按关系删除ToolStripMenuItem_Click);
            // 
            // 按姓名删除ToolStripMenuItem
            // 
            this.按姓名删除ToolStripMenuItem.Name = "按姓名删除ToolStripMenuItem";
            this.按姓名删除ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按姓名删除ToolStripMenuItem.Text = "按姓名删除";
            this.按姓名删除ToolStripMenuItem.Click += new System.EventHandler(this.按姓名删除ToolStripMenuItem_Click);
            // 
            // 修改家庭成员ToolStripMenuItem
            // 
            this.修改家庭成员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按关系修改ToolStripMenuItem,
            this.按姓名修改ToolStripMenuItem});
            this.修改家庭成员ToolStripMenuItem.Name = "修改家庭成员ToolStripMenuItem";
            this.修改家庭成员ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.修改家庭成员ToolStripMenuItem.Text = "修改家庭成员信息";
            // 
            // 按关系修改ToolStripMenuItem
            // 
            this.按关系修改ToolStripMenuItem.Name = "按关系修改ToolStripMenuItem";
            this.按关系修改ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按关系修改ToolStripMenuItem.Text = "按关系修改";
            this.按关系修改ToolStripMenuItem.Click += new System.EventHandler(this.按关系修改ToolStripMenuItem1_Click);
            // 
            // 按姓名修改ToolStripMenuItem
            // 
            this.按姓名修改ToolStripMenuItem.Name = "按姓名修改ToolStripMenuItem";
            this.按姓名修改ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按姓名修改ToolStripMenuItem.Text = "按姓名修改";
            this.按姓名修改ToolStripMenuItem.Click += new System.EventHandler(this.按姓名修改ToolStripMenuItem1_Click);
            // 
            // 查询家庭成员ToolStripMenuItem
            // 
            this.查询家庭成员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按亲戚关系查找ToolStripMenuItem,
            this.按基本信息查找ToolStripMenuItem});
            this.查询家庭成员ToolStripMenuItem.Name = "查询家庭成员ToolStripMenuItem";
            this.查询家庭成员ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.查询家庭成员ToolStripMenuItem.Text = "查询家庭成员信息";
            // 
            // 按亲戚关系查找ToolStripMenuItem
            // 
            this.按亲戚关系查找ToolStripMenuItem.Name = "按亲戚关系查找ToolStripMenuItem";
            this.按亲戚关系查找ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按亲戚关系查找ToolStripMenuItem.Text = "按关系查找";
            this.按亲戚关系查找ToolStripMenuItem.Click += new System.EventHandler(this.按关系查找ToolStripMenuItem_Click);
            // 
            // 按基本信息查找ToolStripMenuItem
            // 
            this.按基本信息查找ToolStripMenuItem.Name = "按基本信息查找ToolStripMenuItem";
            this.按基本信息查找ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按基本信息查找ToolStripMenuItem.Text = "按姓名查找";
            this.按基本信息查找ToolStripMenuItem.Click += new System.EventHandler(this.按姓名查找ToolStripMenuItem_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.平均寿命ToolStripMenuItem,
            this.男女比例ToolStripMenuItem,
            this.家庭平均人口ToolStripMenuItem});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // 平均寿命ToolStripMenuItem
            // 
            this.平均寿命ToolStripMenuItem.Name = "平均寿命ToolStripMenuItem";
            this.平均寿命ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.平均寿命ToolStripMenuItem.Text = "平均寿命";
            this.平均寿命ToolStripMenuItem.Click += new System.EventHandler(this.平均寿命ToolStripMenuItem_Click);
            // 
            // 男女比例ToolStripMenuItem
            // 
            this.男女比例ToolStripMenuItem.Name = "男女比例ToolStripMenuItem";
            this.男女比例ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.男女比例ToolStripMenuItem.Text = "男女比例";
            this.男女比例ToolStripMenuItem.Click += new System.EventHandler(this.男女比例ToolStripMenuItem_Click);
            // 
            // 家庭平均人口ToolStripMenuItem
            // 
            this.家庭平均人口ToolStripMenuItem.Name = "家庭平均人口ToolStripMenuItem";
            this.家庭平均人口ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.家庭平均人口ToolStripMenuItem.Text = "家庭平均人口";
            this.家庭平均人口ToolStripMenuItem.Click += new System.EventHandler(this.家庭平均人口ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.家庭树ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 家庭树ToolStripMenuItem
            // 
            this.家庭树ToolStripMenuItem.Name = "家庭树ToolStripMenuItem";
            this.家庭树ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.家庭树ToolStripMenuItem.Text = "家谱树";
            this.家庭树ToolStripMenuItem.Click += new System.EventHandler(this.家庭树ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1262, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(267, 623);
            this.treeView1.TabIndex = 7;
            // 
            // 主窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家谱管理系统UI beta";
            this.Load += new System.EventHandler(this.主窗口_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改家庭成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除家庭成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询家庭成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平均寿命ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 男女比例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家庭平均人口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家庭树ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按亲戚关系查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按基本信息查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建家庭成员ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 按关系删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按姓名删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按关系修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按姓名修改ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}

