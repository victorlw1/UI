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
    public partial class 查找方法选择窗口 : Form
    {
        public 查找方法选择窗口()
        {
            InitializeComponent();
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            if (姓名选择框.Checked)
            {
                输入姓名 form = new 输入姓名();
                form.ShowDialog();
                this.Close();
            }else if (关系选择框.Checked)
            {
                输入关系 form = new 输入关系();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
