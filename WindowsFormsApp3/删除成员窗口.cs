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
        public static FamilyTreeNode delNode; 

        public static string delName=null;

        public 删除成员窗口()
        {
            InitializeComponent();
        }

        private void 确认删除_Click(object sender, EventArgs e)
        {
            主窗口.是否有改动 = true;
            this.MdiParent.Text = 主窗口.title+" - "+主窗口.xml + "*";



            //删除的逻辑代码
            主窗口.myFamilyTree.delete(delName);



            ((主窗口)(this.MdiParent)).树视图展示.Nodes.Clear();
            TreeNode rootNode = new TreeNode("家族树");
            主窗口.bulidTreeView(主窗口.myFamilyTree.root, rootNode);
            ((主窗口)(this.MdiParent)).树视图展示.Nodes.Add(rootNode);
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
            else
            {
                delNode = 主窗口.myFamilyTree.query(主窗口.myFamilyTree.root, delName);
                姓名展示框.Text = delNode.Name;
                性别展示框.Text = delNode.Gender;
                年龄展示框.Text = Convert.ToString(delNode.Age);
            }
        }
    }
}
