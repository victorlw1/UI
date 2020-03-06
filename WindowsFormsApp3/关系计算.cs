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
    public partial class 关系计算 : Form
    {
        public 关系计算()
        {
            InitializeComponent();
        }

        private void 关系计算_Load(object sender, EventArgs e)
        {
            List<FamilyTreeNode> allNodes = new List<FamilyTreeNode>();
            FamilyTree.DFS_getAll(主窗口.myFamilyTree.root, allNodes);
            foreach (var node in allNodes)
            {
                一个人.Items.Add(node.Name);
                另一个人.Items.Add(node.Name);
            }
        }

        private void 一个人_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _decode = null;
            string _result = null;
            if (一个人.SelectedItem != null && 另一个人.SelectedItem != null)
            {
                string encode = 主窗口.myFamilyTree.findRelation(另一个人.SelectedItem.ToString(), 一个人.SelectedItem.ToString());
                FamilyGraph.decode(encode, ref _decode, ref _result);
                关系展示框.Text = _decode;
                //称呼展示框.Text = _result;
            }
        }

        private void 另一个人_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _decode = null;
            string _result = null;
            if (一个人.SelectedItem != null && 另一个人.SelectedItem != null)
            {
                string encode = 主窗口.myFamilyTree.findRelation(另一个人.SelectedItem.ToString(), 一个人.SelectedItem.ToString());
                FamilyGraph.decode(encode, ref _decode, ref _result);
                关系展示框.Text = _decode;
                //称呼
            }
        }
    }
}
