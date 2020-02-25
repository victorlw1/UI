﻿using System;
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

        public 主窗口()
        {
            InitializeComponent();
        }

        private void 新建家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            新建成员窗口 新建窗口 = new 新建成员窗口();
            新建窗口.MdiParent = this;
            新建窗口.Show();
        }

        private void 删除家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            删除成员窗口 删除窗口 = new 删除成员窗口();
            删除窗口.MdiParent = this;
            删除窗口.Show();
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


        private void 主窗口_Load(object sender, EventArgs e)
        {

        }


        private void 修改家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改成员窗口 修改窗口 = new 修改成员窗口();
            修改窗口.MdiParent = this;
            修改窗口.Show();
        }

        private void 查询家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询成员窗口 查询窗口 = new 查询成员窗口();
            查询窗口.MdiParent = this;
            查询窗口.Show();
        }

        private void 主窗口_Load_1(object sender, EventArgs e)
        {

        }

        private void 平均寿命ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平均寿命窗口 平均寿命 = new 平均寿命窗口();
            平均寿命.StartPosition = FormStartPosition.CenterParent;
            平均寿命.ShowDialog();

        }

        private void 男女比例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            男女比例窗口 男女比例 = new 男女比例窗口();
            男女比例.StartPosition = FormStartPosition.CenterParent;
            男女比例.ShowDialog();

        }

        private void 家庭平均人口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            家庭平均人口窗口 平均人口 = new 家庭平均人口窗口();
            平均人口.StartPosition = FormStartPosition.CenterParent;
            平均人口.ShowDialog();

        }
    }
}
