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
    public partial class 男女比例窗口 : Form
    {
        public 男女比例窗口()
        {
            InitializeComponent();
        }

        private void 男女比例窗口_Load(object sender, EventArgs e)
        {
            //lw
            int age = 0;
            int man = 0;
            int woman = 0;
            FamilyTree.DFS_output_all_age(主窗口.myFamilyTree.root,ref age,ref man,ref woman);
            男女比例展示框.Text = Convert.ToString(man) + ":" + Convert.ToString(woman);

        }

        private void 男女比例返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
