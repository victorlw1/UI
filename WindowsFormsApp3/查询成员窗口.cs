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
        public 查询成员窗口()
        {
            InitializeComponent();
        }

        public static string findName = null;

        private void 查询成员窗口_Load(object sender, EventArgs e)
        {
            查找方法选择窗口 查找方法窗口 = new 查找方法选择窗口();
            查找方法窗口.ShowDialog();
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
