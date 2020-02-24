using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class 主窗口 : Form
    {
        //lw666



        public 主窗口()
        {
            InitializeComponent();
        }

        private void 新建成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 新建家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            新建成员窗口 新建窗口 = new 新建成员窗口();
            新建窗口.MdiParent = this;
            新建窗口.Show();
        }

        private void 删除家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 按关系查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            输入信息窗口 输入窗口 = new 输入信息窗口();
            输入窗口.MdiParent = this;
            输入窗口.Show();
        }

        private void 按姓名查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            输入信息窗口 输入窗口 = new 输入信息窗口();
            输入窗口.MdiParent = this;
            输入窗口.Show();
        }

        private void 平均寿命ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 男女比例ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 家庭平均人口ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 家庭树ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView1.Visible)
            {
                this.treeView1.Hide();
            }
            else
            {
                treeView1.Show();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 主窗口_Load(object sender, EventArgs e)
        {

        }

        private void 按关系删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            输入信息窗口 输入窗口= new 输入信息窗口();
            输入窗口.MdiParent = this;
            输入窗口.Show();
        }

        private void 按姓名删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            输入信息窗口 输入窗口 = new 输入信息窗口();
            输入窗口.MdiParent = this;
            输入窗口.Show();
        }

        private void 按关系修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            输入信息窗口 输入窗口 = new 输入信息窗口();
            输入窗口.MdiParent = this;
            输入窗口.Show();
        }

        private void 按姓名修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            输入信息窗口 输入窗口 = new 输入信息窗口();
            输入窗口.MdiParent = this;
            输入窗口.Show();
        }
    }
}
