using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilySys
{
    public partial class 主窗口 : Form
    {
        public static string title = "家谱管理系统UI beta";
        public static string xml = null;
        public static bool 是否有改动 = false;

        public static bool 打开查询成员窗口时是否打开查找方法选择窗口 = true;


        public static List<FamilyTreeNode> familyTreeNodes=new List<FamilyTreeNode>();
        public static FamilyTree myFamilyTree;
        public static FamilyGraph myFamilyGraph;

        public 主窗口()
        {
            InitializeComponent();
            myFamilyTree = new FamilyTree();
            myFamilyGraph = new FamilyGraph();
            //压力测试
            //pressureTest();

        }

        private void pressureTest() 
        {
            ArrayList list = new ArrayList();
            Random rd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                string name= rd.Next(1, 10000).ToString();
                
                list.Add(name);
                int index = rd.Next(0, list.Count);
                FamilyTreeNode familyTreeNode = new FamilyTreeNode(name, 1, "male", false, new DateTime(rd.Next(1800,9000),rd.Next(1,13),rd.Next(1,28)), "china", new DateTime(rd.Next(1800, 9000), rd.Next(1, 13), rd.Next(1, 28)), "180", "stu", "hhh", "hhhhh");
                myFamilyTree.insert_child(familyTreeNode, list[index].ToString());
            }
            myFamilyTree.saveTree("treeTest.xml");
        }

        private void 新建家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            新建成员窗口 新建窗口 = new 新建成员窗口();
            新建窗口.MdiParent = this;
            新建窗口.Show();
        }

        private void 删除家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            删除成员窗口 删除窗口 = new 删除成员窗口();
            删除窗口.MdiParent = this;
            删除窗口.Show();
        }



        private void 家庭树ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.树视图展示.Visible)
            {
                this.树视图展示.Hide();
            }
            else
            {
                树视图展示.Show();
            }
        }


        private void 修改家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改成员窗口 修改窗口 = new 修改成员窗口();
            修改窗口.MdiParent = this;
            修改窗口.Show();
        }

        private void 查询家庭成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询成员窗口 查询窗口 = new 查询成员窗口();
            查询窗口.MdiParent = this;
            查询窗口.Show();
        }


        private void 平均寿命ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平均寿命窗口 平均寿命 = new 平均寿命窗口();
            平均寿命.StartPosition = FormStartPosition.CenterParent;
            平均寿命.ShowDialog();

        }

        private void 男女比例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            男女比例窗口 男女比例 = new 男女比例窗口();
            男女比例.StartPosition = FormStartPosition.CenterParent;
            男女比例.ShowDialog();

        }

        

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog 导入窗口 = new OpenFileDialog();
            导入窗口.Title = "请选择文件";
            导入窗口.Filter = "(*.xml)|*.xml";
            导入窗口.RestoreDirectory = true;
            if (导入窗口.ShowDialog() == DialogResult.OK)
            {
                xml = 导入窗口.FileName;
                this.Text = xml;


                //需要加载操作

                myFamilyTree.loadTree(xml);

                树视图展示.Nodes.Clear();
                TreeNode rootNode = new TreeNode("家族树");
                bulidTreeView(myFamilyTree.root, rootNode);
                树视图展示.Nodes.Add(rootNode);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (主窗口.是否有改动)
            {
                DialogResult 选择结果 = MessageBox.Show("文件尚未保存，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (选择结果 == DialogResult.Yes)
                {
                    //保存
                    SaveFileDialog dialog = new SaveFileDialog();
                    //dialog.Description = "请选择文件路径";
                    dialog.Title = "请选择保存路径";
                    dialog.Filter = "(*.xml)|*.xml";
                    dialog.RestoreDirectory = true;
                    dialog.FileName = "famliy.xml";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string foldPath = dialog.FileName;

                        //需要保存操作

                        myFamilyTree.saveTree(foldPath);

                    }
                    this.Close();
                }
                else if (选择结果 == DialogResult.No)
                {
                    this.Close();
                }
                else if (选择结果 == DialogResult.Cancel)
                {
                    ;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Description = "请选择文件路径";
            dialog.Title = "请选择保存路径";
            dialog.Filter = "(*.xml)|*.xml";
            dialog.RestoreDirectory = true;
            dialog.FileName = "famliy.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.FileName;

                myFamilyTree.saveTree(foldPath);

            }
        }

        private void 主窗口_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (主窗口.是否有改动)
            {
                DialogResult 选择结果 = MessageBox.Show("文件尚未保存，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (选择结果 == DialogResult.Yes)
                {
                    //保存
                    SaveFileDialog dialog = new SaveFileDialog();
                    //dialog.Description = "请选择文件路径";
                    dialog.Title = "请选择保存路径";
                    dialog.Filter = "(*.xml)|*.xml";
                    dialog.RestoreDirectory = true;
                    dialog.FileName = "famliy.xml";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string foldPath = dialog.FileName;
                        //需要保存操作
                        myFamilyTree.saveTree(foldPath);
                    }
                }
                else if (选择结果 == DialogResult.No)
                {
                    ;
                }
                else if (选择结果 == DialogResult.Cancel)
                {
                    e.Cancel = true;//取消关闭窗口
                }
            }
        }

        private void 新建ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           (new 主窗口()).Show();
        }

        public static void bulidTreeView(FamilyTreeNode root, TreeNode tNode)
        {
            if (root == null)
            {
                return;
            }
            for (var p = root; p != null; p = p.RightChild)
            {
                TreeNode ttNode = new TreeNode(p.Name);
                tNode.Nodes.Add(ttNode);
                bulidTreeView(p.LeftChild, ttNode);
            }
        }


        private void 寻找两人亲戚关系ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            关系计算 关系窗口 = new 关系计算();
            关系窗口.Show();
}
        private void 树视图展示_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text != "家族树")
            {
                打开查询成员窗口时是否打开查找方法选择窗口 = false;
                查询成员窗口.findName = e.Node.Text;
                查询成员窗口 查询窗口 = new 查询成员窗口();
                查询窗口.MdiParent = this;
                查询窗口.Show();
                打开查询成员窗口时是否打开查找方法选择窗口 = true;
            }

        }
    }
}
