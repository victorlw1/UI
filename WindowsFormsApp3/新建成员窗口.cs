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
            this.MdiParent.Text = 主窗口.title + " - " + 主窗口.xml + "*";
            this.Close();
            //需要增加TreeNode的函数
        }

        private void 新建成员窗口_Load(object sender, EventArgs e)
        {
            foreach(string province in R.provinces)
            {
                省份.Items.Add(province);
            }
            foreach (string edu in R.education)
            {
                学历水平选择框.Items.Add(edu);
            }
            主窗口.familyTreeNodes.Clear();
            if (主窗口.myFamilyTree != null)
            {
                List<FamilyTreeNode> allNodes = new List<FamilyTreeNode>();
                FamilyTree.DFS_getAll(主窗口.myFamilyTree.root, allNodes);
                foreach (var node in allNodes)
                {
                    已有的人.Items.Add(node.Name);
                }
            }
        }

        private void 性别_男_CheckedChanged(object sender, EventArgs e)
        {
            if (性别_男.Checked)
            {
                亲戚关系.Items.Clear();
                foreach (string relation in R.male_relation)
                {
                    亲戚关系.Items.Add(relation);
                }

            }
        }

        private void 性别_女_CheckedChanged(object sender, EventArgs e)
        {
            if (性别_女.Checked)
            {
                亲戚关系.Items.Clear();
                foreach (string relation in R.female_relation)
                {
                    亲戚关系.Items.Add(relation);
                }

            }
        }
    }
}
