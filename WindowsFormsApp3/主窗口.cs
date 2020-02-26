﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilySys
{
    public partial class 主窗口 : Form
    {
        public static string xml = null;
        public static bool 是否有改动 = false;
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
            平均人口展示框 平均人口 = new 平均人口展示框();
            平均人口.StartPosition = FormStartPosition.CenterParent;
            平均人口.ShowDialog();

        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog 导入窗口 = new OpenFileDialog();
            导入窗口.Title = "请选择xml文件";
            导入窗口.Filter = "(*.xml)|*.xml";
            if (导入窗口.ShowDialog() == DialogResult.OK)
            {
                xml = 导入窗口.FileName;
                this.Text = xml;
                //得到了xml的路径在url里
                //需要把xml转换成树的函数
            }
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (主窗口.是否有改动)
            {
                DialogResult 选择结果 = MessageBox.Show("文件尚未保存，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (选择结果 == DialogResult.Yes)
                {
                    //保存的方法
                    this.Close();
                }
                else if (选择结果 == DialogResult.No)
                {
                    this.Close();
                }
                else if (选择结果 == DialogResult.Cancel)
                {
                    ;
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
