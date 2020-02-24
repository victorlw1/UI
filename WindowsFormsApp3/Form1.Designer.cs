namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改家庭成员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除家庭成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平均寿命ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平均身高ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.男女比例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家庭平均人口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最高ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最高ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.最低ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平均ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询家庭成员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家庭树ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按亲戚关系查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按基本信息查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(178, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "家谱管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.统计ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建成员ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.新建ToolStripMenuItem.Text = "文件";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 新建成员ToolStripMenuItem
            // 
            this.新建成员ToolStripMenuItem.Name = "新建成员ToolStripMenuItem";
            this.新建成员ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新建成员ToolStripMenuItem.Text = "新建家庭成员";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改家庭成员信息ToolStripMenuItem,
            this.删除家庭成员ToolStripMenuItem,
            this.查询家庭成员信息ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 修改家庭成员信息ToolStripMenuItem
            // 
            this.修改家庭成员信息ToolStripMenuItem.Name = "修改家庭成员信息ToolStripMenuItem";
            this.修改家庭成员信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.修改家庭成员信息ToolStripMenuItem.Text = "修改家庭成员信息";
            // 
            // 删除家庭成员ToolStripMenuItem
            // 
            this.删除家庭成员ToolStripMenuItem.Name = "删除家庭成员ToolStripMenuItem";
            this.删除家庭成员ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.删除家庭成员ToolStripMenuItem.Text = "删除家庭成员";
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.平均寿命ToolStripMenuItem,
            this.平均身高ToolStripMenuItem,
            this.男女比例ToolStripMenuItem,
            this.家庭平均人口ToolStripMenuItem,
            this.最高ToolStripMenuItem});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // 平均寿命ToolStripMenuItem
            // 
            this.平均寿命ToolStripMenuItem.Name = "平均寿命ToolStripMenuItem";
            this.平均寿命ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.平均寿命ToolStripMenuItem.Text = "平均寿命";
            // 
            // 平均身高ToolStripMenuItem
            // 
            this.平均身高ToolStripMenuItem.Name = "平均身高ToolStripMenuItem";
            this.平均身高ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.平均身高ToolStripMenuItem.Text = "平均身高";
            // 
            // 男女比例ToolStripMenuItem
            // 
            this.男女比例ToolStripMenuItem.Name = "男女比例ToolStripMenuItem";
            this.男女比例ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.男女比例ToolStripMenuItem.Text = "男女比例";
            // 
            // 家庭平均人口ToolStripMenuItem
            // 
            this.家庭平均人口ToolStripMenuItem.Name = "家庭平均人口ToolStripMenuItem";
            this.家庭平均人口ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.家庭平均人口ToolStripMenuItem.Text = "家庭平均人口";
            // 
            // 最高ToolStripMenuItem
            // 
            this.最高ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最高ToolStripMenuItem1,
            this.最低ToolStripMenuItem,
            this.平均ToolStripMenuItem});
            this.最高ToolStripMenuItem.Name = "最高ToolStripMenuItem";
            this.最高ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.最高ToolStripMenuItem.Text = "学历";
            // 
            // 最高ToolStripMenuItem1
            // 
            this.最高ToolStripMenuItem1.Name = "最高ToolStripMenuItem1";
            this.最高ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.最高ToolStripMenuItem1.Text = "最高";
            // 
            // 最低ToolStripMenuItem
            // 
            this.最低ToolStripMenuItem.Name = "最低ToolStripMenuItem";
            this.最低ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.最低ToolStripMenuItem.Text = "最低";
            // 
            // 平均ToolStripMenuItem
            // 
            this.平均ToolStripMenuItem.Name = "平均ToolStripMenuItem";
            this.平均ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.平均ToolStripMenuItem.Text = "平均";
            // 
            // 查询家庭成员信息ToolStripMenuItem
            // 
            this.查询家庭成员信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按亲戚关系查找ToolStripMenuItem,
            this.按基本信息查找ToolStripMenuItem});
            this.查询家庭成员信息ToolStripMenuItem.Name = "查询家庭成员信息ToolStripMenuItem";
            this.查询家庭成员信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询家庭成员信息ToolStripMenuItem.Text = "查询家庭成员信息";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.退出ToolStripMenuItem.Text = "退出";
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
            this.家庭树ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.家庭树ToolStripMenuItem.Text = "家谱树";
            this.家庭树ToolStripMenuItem.Click += new System.EventHandler(this.家庭树ToolStripMenuItem_Click);
            // 
            // 按亲戚关系查找ToolStripMenuItem
            // 
            this.按亲戚关系查找ToolStripMenuItem.Name = "按亲戚关系查找ToolStripMenuItem";
            this.按亲戚关系查找ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.按亲戚关系查找ToolStripMenuItem.Text = "按亲戚关系查找";
            // 
            // 按基本信息查找ToolStripMenuItem
            // 
            this.按基本信息查找ToolStripMenuItem.Name = "按基本信息查找ToolStripMenuItem";
            this.按基本信息查找ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.按基本信息查找ToolStripMenuItem.Text = "按基本信息查找";
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
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "家谱管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改家庭成员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除家庭成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询家庭成员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平均寿命ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平均身高ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 男女比例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家庭平均人口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最高ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最高ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 最低ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平均ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家庭树ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按亲戚关系查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按基本信息查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

