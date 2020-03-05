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
        public static FamilyTreeNode altNode;
        public static string altName = null;
        public 修改成员窗口()
        {
            InitializeComponent();
        }

        private void 确认修改_Click(object sender, EventArgs e)
        {

            主窗口.是否有改动 = true;
            this.MdiParent.Text = 主窗口.title + " - " + 主窗口.xml + "*";

            //lw
            String UIname = 姓名输入框.Text;
            String UIgender;
            if (性别_male.Checked)
            {
                UIgender = "male";
            }
            else
                UIgender = "female";
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

            altNode.Name = UIname;altNode.Gender = UIgender;altNode.Age = UIage;
            altNode.Birthplace = UIBirthplace;altNode.Birthday = UIBirthday;altNode.Deathday = UIDeathday;
            altNode.IsDead = UIisdead;altNode.Education = UIeducation;

            //altNode.Height = UIheight;
            //altNode.Profession = UIprofession;


            //altNode = new FamilyTreeNode(UIname, UIage, UIgender, UIisdead, UIBirthday, UIBirthplace, UIDeathday, UIheight, UIeducation, UIprofession, UIHighestProfessionRank);
            //出生日期和死亡日期是date类型，没办法转到String去（已经解决）


            //if (已有的人.SelectedIndex == -1)//没有选择与“已有的人”来设置亲戚关系
            //{
            //    //将newNode默认设置成为root的父亲，作为老祖宗
            //}
            //else
            //{
            //    string Name = 已有的人.SelectedItem.ToString();
            //    {
            //        string relation = 亲戚关系.SelectedItem.ToString();
            //        if (relation == "儿子" || relation == "女儿")
            //        {
            //            主窗口.myFamilyTree.insert_child(altNode, Name);
            //        }
            //        else//兄弟姐妹关系
            //        {
            //            //需要一个添加兄弟的函数
            //            //或者添加一个找到父亲的函数，再给父亲加孩子，相当于加兄弟
            //            //szm
            //        }
            //    }
            //}

            ((主窗口)(this.MdiParent)).树视图展示.Nodes.Clear();
            TreeNode rootNode = new TreeNode("家族树");
            主窗口.bulidTreeView(主窗口.myFamilyTree.root, rootNode);
            ((主窗口)(this.MdiParent)).树视图展示.Nodes.Add(rootNode);
            this.Close();
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

            //if (主窗口.myFamilyTree != null)
            //{
            //    List<FamilyTreeNode> allNodes = new List<FamilyTreeNode>();
            //    FamilyTree.DFS_getAll(主窗口.myFamilyTree.root, allNodes);
            //    foreach (var node in allNodes)
            //    {
            //        已有的人.Items.Add(node.Name);
            //    }
            //}

        }

        //private void 性别_male_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (性别_male.Checked)
        //    {
        //        亲戚关系.Items.Clear();
        //        亲戚关系.Text = "";
        //        foreach (string relation in R.male_relation)
        //        {
        //            亲戚关系.Items.Add(relation);
        //        }

        //    }
        //}

        //private void 性别_female_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (性别_female.Checked)
        //    {
        //        亲戚关系.Items.Clear();
        //        亲戚关系.Text = "";
        //        foreach (string relation in R.female_relation)
        //        {
        //            亲戚关系.Items.Add(relation);
        //        }

        //    }
        //}

        private void 修改成员窗口_Shown(object sender, EventArgs e)
        {
            if (altName == null)
            {
                this.Close();
                return;
            }else
            {
                altNode = 主窗口.myFamilyTree.query(主窗口.myFamilyTree.root, altName);

                姓名输入框.Text = altNode.Name;
                if (altNode.Gender == "male")
                {
                    性别_male.Checked = true;
                }
                else
                {
                    性别_female.Checked = true;
                }
                年龄选择框.Value = altNode.Age;
                省份.Text = altNode.Birthplace;
                出生日期选择框.Value = altNode.Birthday;
                if (altNode.IsDead == true)
                    是否在世_已故.Checked = true;
                else
                    是否在世_在世.Checked = true;
                死亡日期选择框.Value = altNode.Deathday;
                学历水平选择框.Text = altNode.Education;
                最高职位输入框.Text = altNode.HighestProfessionRank;
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
