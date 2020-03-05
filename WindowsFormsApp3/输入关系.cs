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
    public partial class 输入关系 : Form
    {
        public 输入关系()
        {
            InitializeComponent();
        }

        private void 输入关系_Load(object sender, EventArgs e)
        {
            主窗口.familyTreeNodes.Clear();
            if (主窗口.myFamilyTree != null)
            {
                List<FamilyTreeNode> allNodes = new List<FamilyTreeNode>();
                FamilyTree.DFS_getAll(主窗口.myFamilyTree.root, allNodes);
                foreach (var node in allNodes)
                {
                    一个人.Items.Add(node.Name);
                }
            }
            亲戚关系.Items.Clear();
            foreach (string relation in R.male_relation)
            {
                亲戚关系.Items.Add(relation);
            }
            foreach (string relation in R.female_relation)
            {
                亲戚关系.Items.Add(relation);
            }
        }

        private void 亲戚关系_SelectedIndexChanged(object sender, EventArgs e)
        {
            另一个人.Items.Clear();
            if (亲戚关系.SelectedItem == "儿子")
            {
                string name = 一个人.SelectedItem.ToString();
                List<FamilyTreeNode> Nodes=new List<FamilyTreeNode>();
                主窗口.myFamilyTree.get_sons(name, Nodes);
                foreach(var i in Nodes)
                {
                    另一个人.Items.Add(i.Name);
                }
            }
            else if (亲戚关系.SelectedItem == "大哥")
            {
                string name = 一个人.SelectedItem.ToString();
                List<FamilyTreeNode> Nodes = new List<FamilyTreeNode>();
                主窗口.myFamilyTree.get_elderBrothers(name, Nodes);
                foreach (var i in Nodes)
                {
                    另一个人.Items.Add(i.Name);
                }
            }
            else if (亲戚关系.SelectedItem == "小弟")
            {
                string name = 一个人.SelectedItem.ToString();
                List<FamilyTreeNode> Nodes = new List<FamilyTreeNode>();
                主窗口.myFamilyTree.get_littleBrothers(name, Nodes);
                foreach (var i in Nodes)
                {
                    另一个人.Items.Add(i.Name);
                }
            }
            else if (亲戚关系.SelectedItem == "female儿")
            {
                string name = 一个人.SelectedItem.ToString();
                List<FamilyTreeNode> Nodes = new List<FamilyTreeNode>();
                主窗口.myFamilyTree.get_daughters(name, Nodes);
                foreach (var i in Nodes)
                {
                    另一个人.Items.Add(i.Name);
                }
            }
            else if (亲戚关系.SelectedItem == "大姐")
            {
                string name = 一个人.SelectedItem.ToString();
                List<FamilyTreeNode> Nodes = new List<FamilyTreeNode>();
                主窗口.myFamilyTree.get_elderSisters(name, Nodes);
                foreach (var i in Nodes)
                {
                    另一个人.Items.Add(i.Name);
                }
            }
            else if (亲戚关系.SelectedItem == "小妹")
            {
                string name = 一个人.SelectedItem.ToString();
                List<FamilyTreeNode> Nodes = new List<FamilyTreeNode>();
                主窗口.myFamilyTree.get_littleSisters(name, Nodes);
                foreach (var i in Nodes)
                {
                    另一个人.Items.Add(i.Name);
                }
            }
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            修改成员窗口.altName = 另一个人.SelectedItem.ToString();
            删除成员窗口.delName = 另一个人.SelectedItem.ToString();
            查询成员窗口.findName = 另一个人.SelectedItem.ToString();
            this.Close();
        }
    }
}
