using System;
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
    public partial class 查询成员窗口 : Form
    {
        public static FamilyTreeNode queNode;
        public 查询成员窗口()
        {
            InitializeComponent();
        }

        public static string findName = null;

        private void 查询成员窗口_Load(object sender, EventArgs e)
        {
            查找方法选择窗口 查找方法窗口 = new 查找方法选择窗口();
            查找方法窗口.ShowDialog();
            姓名展示框.Text = queNode.Name;
            性别展示框.Text = queNode.Gender;
            年龄展示框.Text = Convert.ToString(queNode.Age);
            出生地展示框.Text = queNode.Birthplace;
            出生日期展示框.Text = Convert.ToString(queNode.Birthday);
            死亡日期展示框.Text = Convert.ToString(queNode.Deathday);
            学历水平.Text = queNode.Education;
            最高职称展示框.Text = queNode.HighestProfessionRank;
            //亲戚关系怎么写？？？

        }

        private void 查询成员窗口_FormClosed(object sender, FormClosedEventArgs e)
        {
            findName = null;
        }

        private void 查询成员窗口_Shown(object sender, EventArgs e)
        {
            if (findName == null)
            {
                this.Close();
                return;
            }
        }
    }
}
