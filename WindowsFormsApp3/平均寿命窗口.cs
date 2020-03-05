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
    public partial class 平均寿命窗口 : Form
    {
        public 平均寿命窗口()
        {
            InitializeComponent();
        }

        private void 平均寿命_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 单位岁_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void 平均寿命返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 平均寿命窗口_Load(object sender, EventArgs e)
        {
            int age = 0;
            int man = 0;
            int woman = 0;
            FamilyTree.DFS_output_all_age(主窗口.myFamilyTree.root, age,man,woman);
            double average = Convert.ToDouble(age) / (man + woman);
            average=Math.Round(average, 2);
            平均寿命展示框.Text = Convert.ToString(average) + "岁";



        }
    }
}
