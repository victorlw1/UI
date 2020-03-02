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
    public partial class 删除成员窗口 : Form
    {

        public static string delName;

        public 删除成员窗口()
        {
            InitializeComponent();
        }

        private void 确认删除_Click(object sender, EventArgs e)
        {
            主窗口.是否有改动 = true;
            this.MdiParent.Text = 主窗口.title+" - "+主窗口.xml + "*";
            this.Close();
        }

        private void 删除成员窗口_Load(object sender, EventArgs e)
        {
            查找方法选择窗口 查找方法窗口 = new 查找方法选择窗口();
            查找方法窗口.ShowDialog();
        }

        private void 删除成员窗口_FormClosed(object sender, FormClosedEventArgs e)
        {
            delName = null;
        }

        private void 删除成员窗口_Shown(object sender, EventArgs e)
        {
            if (delName == null)
            {
                this.Close();
                return;
            }
        }
    }
}
