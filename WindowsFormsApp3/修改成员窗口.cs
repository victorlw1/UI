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
    public partial class 修改成员窗口 : Form
    {
        public static FamilyTreeNode AfaltNode;
        public static FamilyTreeNode BfaltNode;
        public static string altName = null;
        public 修改成员窗口()
        {
            InitializeComponent();
        }

        private void 确认修改_Click(object sender, EventArgs e)
        {

            主窗口.是否有改动 = true;
            this.MdiParent.Text = 主窗口.title + " - " + 主窗口.xml + "*";
            this.Close();
            //lw
            String UIname = 姓名输入框.Text;
            String UIgender;
            if (性别_男.Checked)
            {
                UIgender = "男";
            }
            else
                UIgender = "女";
            int UIage = (int)年龄选择框.Value;
            String UIBirthplace = 省份.Text;
            DateTime UIBirthday = 出生日期选择框.Value;
            bool UIisdead;
            if (是否在世_在世.Checked)
                UIisdead = false;
            else
                UIisdead = true;
            DateTime UIDeathday = 死亡日期选择框.Value;
            String UIeducation = 学历水平选择框.Text;
            String UIHighestProfessionRank = 最高职位输入框.Text;
            String UIheight = "1";//？？？UI里没有身高输入
            String UIprofession = " balabala";//？？？UI里没有职业
            AfaltNode = new FamilyTreeNode(UIname, UIage, UIgender, UIisdead, UIBirthday, UIBirthplace, UIDeathday, UIheight, UIeducation, UIprofession, UIHighestProfessionRank);
            //出生日期和死亡日期是date类型，没办法转到String去
            //需要修改TreeNode的函数
        }

        private void 修改成员窗口_Load(object sender, EventArgs e)
        {
            查找方法选择窗口 查找方法窗口 = new 查找方法选择窗口();
            查找方法窗口.ShowDialog();
            foreach (string province in R.provinces)
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
            //lw
            姓名输入框.Text = BfaltNode.Name;
            if (BfaltNode.Gender == "男")
            {
                性别_男.Checked = true;
            }
            else
                性别_女.Checked = true;
            年龄选择框.Value = BfaltNode.Age;
            省份.Text = BfaltNode.Birthplace;
            出生日期选择框.Value = BfaltNode.Birthday;
            if (BfaltNode.IsDead == true)
                是否在世_在世.Checked = true;
            else
                是否在世_已故.Checked = true;
            死亡日期选择框.Value = BfaltNode.Deathday;
            学历水平选择框.Text = BfaltNode.Education;
            最高职位输入框.Text = BfaltNode.HighestProfessionRank;


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

        private void 修改成员窗口_Shown(object sender, EventArgs e)
        {
            if (altName == null)
            {
                this.Close();
                return;
            }
        }

        private void 修改成员窗口_FormClosed(object sender, FormClosedEventArgs e)
        {
            altName = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
