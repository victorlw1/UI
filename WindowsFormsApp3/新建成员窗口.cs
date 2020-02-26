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
    public partial class 新建成员窗口 : Form
    {
        public 新建成员窗口()
        {
            InitializeComponent();
        }

        private void 确认新建_Click(object sender, EventArgs e)
        {
            主窗口.是否有改动 = true;
            this.MdiParent.Text = 主窗口.xml + "*";
            this.Close();
        }
    }
}
