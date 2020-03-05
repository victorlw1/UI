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
    public partial class 输入姓名 : Form
    {
        public 输入姓名()
        {
            InitializeComponent();
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            if (姓名输入框.Text == "")
            {
                MessageBox.Show("请输入内容", null, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                修改成员窗口.altName = 姓名输入框.Text;
                删除成员窗口.delName = 姓名输入框.Text;
                查询成员窗口.findName= 姓名输入框.Text;
                this.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
