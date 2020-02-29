using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp3
{
    
    class FamilyTree
    {
        public FamilyTreeNode root;
        public FamilyTree()
        {
            root = null;
        }
        public FamilyTree(string name, int age, string gender, bool isDead, string birthday, string birthplace, string deathday, string height, string education, string profession, string highestProfessionRank)
        {
            root = new FamilyTreeNode(name, age, gender, isDead, birthday, birthplace, deathday, height, education, profession, highestProfessionRank);
        }

        public void DFS_output(FamilyTreeNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.Name);
            DFS_output(node.LeftChild);
            DFS_output(node.RightChild);
        }

        public FamilyTreeNode query(FamilyTreeNode startNode, string name)//HowToQuery
        {
            if (startNode.Name == name)
            {
                return startNode;
            }
            FamilyTreeNode resNode = null;
            if (startNode.LeftChild != null)
            {
                resNode = query(startNode.LeftChild, name);
            }
            if (resNode != null)
            {
                return resNode;
            }
            if (startNode.RightChild != null)
            {
                resNode = query(startNode.RightChild, name);
            }
            return resNode;
        }

        public void insert(FamilyTreeNode node, string fatherName)
        {
            if (root == null)
            {
                node.Parent = null;
                node.Level = 1;
                root = node;
                return;
            }
            FamilyTreeNode temp = query(root, fatherName);
            if (temp != null)
            {
                if (temp.LeftChild == null)
                {
                    temp.LeftChild = node;
                    node.Parent = temp;
                    node.Level = temp.Level + 1;
                }
                else
                {
                    FamilyTreeNode p = temp;
                    temp = temp.LeftChild;
                    while (temp.RightChild != null)
                    {
                        temp = temp.RightChild;
                    }
                    temp.RightChild = node;
                    node.Parent = p;
                    node.Level = p.Level + 1;
                }
            }

        }
        public void delete(string name)//????LB
        {
            FamilyTreeNode temp = query(root, name);
            temp.Name = "无";//????LB
            if (temp.LeftChild == null && temp.RightChild == null)
            {
                if (temp.Parent.LeftChild == temp)
                {
                    temp.Parent.LeftChild = null;
                }
                else
                {
                    FamilyTreeNode p = temp.Parent.LeftChild;
                    while (p.RightChild != temp)
                    {
                        p = p.RightChild;
                    }
                    p.RightChild = null;
                }
            }
            temp.Birthplace = "无";
            temp.Birthday = "无";
            temp.Deathday = "无";
            temp.Gender = "无";
            temp.Height = "无";
            temp.Education = "无";
            temp.Profession = "无";
            temp.HighestProfessionRank = "无";
        }
        public void update(string name,string newName, int newAge, string newGender, bool newIsDead, string newBirthday, string newBirthplace, string newDeathday, string newHeight, string newEducation, string newProfession, string newHighestProfessionRank)
        {
            FamilyTreeNode temp = query(root, name);
            if (newName != null)
                temp.Name = newName;
            if (newAge != null)
                temp.Age = newAge;
            if (newGender != null)
                temp.Gender = newGender;
            if (newIsDead != null)
                temp.IsDead = newIsDead;
            if (newBirthday != null)
                temp.Birthday = newBirthday;
            if (newBirthplace != null)
                temp.Birthplace = newBirthplace;
            if (newDeathday != null)
                temp.Deathday = newDeathday;
            if (newHeight != null)
                temp.Height = newHeight;
            if (newEducation != null)
                temp.Education = newEducation;
            if (newProfession != null)
                temp.Profession = newProfession;
            if (newHighestProfessionRank != null)
                temp.HighestProfessionRank = newHighestProfessionRank;
        }

        public int isSibling(FamilyTreeNode node1, FamilyTreeNode node2) //-1 不是兄弟 0 同一人 1 是兄弟且node2在node1的右子树 2 是兄弟且node1在node2的右子树
        {
            if (node1.Level != node2.Level)
            {
                return -1;
            }
            else if (node1 == node2)
            {
                return 0;
            }
            else
            {
                FamilyTreeNode temp1 = node1;
                FamilyTreeNode temp2 = node2;
                while (temp1.RightChild != null)
                {
                    temp1 = temp1.RightChild;
                    if (temp1 == node2)
                    {
                        return 1;
                    }
                }
                while (temp2.RightChild != null)
                {
                    temp2 = temp2.RightChild;
                    if (temp2 == node1)
                    {
                        return 2;
                    }
                }
                return -1;
            }

        }

        public bool isElder(FamilyTreeNode node1, FamilyTreeNode node2) //判断年龄大小
        {
            string str1 = node1.Birthday;
            string str2 = node2.Birthday;
            for (int i = 0; i < 8; i++)
            {
                if (str1[i] > str2[i])
                    return false;
                if (str1[i] < str2[i])
                    return true;
            }
            return true;
        }

        /*
        * 基础关系：最短编码
        * 
        * 我 00
        * 父亲 01
        * 母亲 02
        * 儿子 11
        * 女儿 12
        * 大哥 21
        * 大姐 22
        * 小弟 31
        * 小妹 32
        * 丈夫 41
        * 妻子 42
        */
        public string findRelation(string name1, string name2)  //查找name2是name1的什么
        {
            string result = "";
            string result_rev = "";
            FamilyTreeNode node1 = query(root, name1);
            FamilyTreeNode node2 = query(root, name2);
            if (node1.Level > node2.Level)
            {
                while (node1.Level != node2.Level)
                {
                    node1 = node1.Parent;
                    if (node1.Gender == "男")
                        result += "01";
                    else
                        result += "02";
                }
            }
            else if (node1.Level < node2.Level)
            {
                while (node1.Level != node2.Level)
                {
                    if (node2.Gender == "男")
                        result_rev += "11";
                    else
                        result_rev += "21";
                    node2 = node2.Parent;
                }
            }

            while (isSibling(node1, node2) == -1)
            {
                node1 = node1.Parent;
                if (node1.Gender == "男")
                    result += "01";
                else
                    result += "02";
                if (node2.Gender == "男")
                    result_rev += "11";
                else
                    result_rev += "21";
                node2 = node2.Parent;
            }

            if (isSibling(node1, node2) != 0)
            {
                if (node2.Gender == "男")
                {
                    if (isElder(node1, node2))
                        result += "31";
                    else
                        result += "21";

                }
                else
                {
                    if (isElder(node1, node2))
                        result += "32";
                    else
                        result += "22";
                }
            }

            char[] arr = result_rev.ToCharArray();
            Array.Reverse(arr);
            result_rev = new string(arr);
            result += result_rev;
            return result;
        }

        public void saveTree() //将树保存到本地
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            xmlDoc.AppendChild(xmlDeclaration);
            XmlElement rootElem = xmlDoc.CreateElement("root");
            xmlDoc.AppendChild(rootElem);
            saveTreeHelper(xmlDoc, rootElem, root);
            xmlDoc.Save("familytree.xml");
        }

        public void saveTreeHelper(XmlDocument xmlDoc, XmlElement elem, FamilyTreeNode node)
        {
            if (node == null)
            {
                elem.SetAttribute("emp", "y");
                return;
            }
            elem.SetAttribute("n", node.Name);
            elem.SetAttribute("bp", node.Birthplace);
            elem.SetAttribute("bd", node.Birthday);
            elem.SetAttribute("dd", node.Deathday);
            elem.SetAttribute("g", node.Gender);
            elem.SetAttribute("h", node.Height);
            elem.SetAttribute("e", node.Education);
            elem.SetAttribute("p", node.Profession);
            elem.SetAttribute("hp", node.HighestProfessionRank);
            elem.SetAttribute("emp", "n");
            XmlElement lElem = xmlDoc.CreateElement("l");
            XmlElement rElem = xmlDoc.CreateElement("r");
            elem.AppendChild(lElem);
            elem.AppendChild(rElem);
            saveTreeHelper(xmlDoc, lElem, node.LeftChild);
            saveTreeHelper(xmlDoc, rElem, node.RightChild);

        }

        //public void loadTree() //从本地加载一棵树
        //{
        //    XmlDocument xmlDoc = new XmlDocument();
        //    xmlDoc.Load("familytree.xml");
        //    XmlNode xmlNode = xmlDoc.SelectSingleNode("root");
        //    XmlElement xmlElem = (XmlElement)xmlNode;
        //    root = loadTreeHelper(xmlDoc, xmlElem, null, 0);
        //}

        //public FamilyTreeNode loadTreeHelper(XmlDocument xmlDoc, XmlElement xmlElem, FamilyTreeNode parentNode, int level)
        //{
        //    if (xmlElem.GetAttribute("emp") == "y")
        //    {
        //        FamilyTreeNode node1 = null;
        //        return node1;
        //    }
        //    string name = xmlElem.GetAttribute("n");
        //    string birthplace = xmlElem.GetAttribute("bp");
        //    string birthday = xmlElem.GetAttribute("bd");
        //    string deathday = xmlElem.GetAttribute("dd");
        //    string gender = xmlElem.GetAttribute("g");
        //    string height = xmlElem.GetAttribute("h");
        //    string education = xmlElem.GetAttribute("e");
        //    string profession = xmlElem.GetAttribute("p");
        //    string highestProfessionRank = xmlElem.GetAttribute("hp");
        //    FamilyTreeNode node = new FamilyTreeNode(name,age,gender,isDead, birthday, birthplace,  deathday, height, education, profession, highestProfessionRank);
        //    node.Parent = parentNode;
        //    node.Level = level;
        //    XmlElement lElem = (XmlElement)xmlElem.SelectSingleNode("l");
        //    XmlElement rElem = (XmlElement)xmlElem.SelectSingleNode("r");
        //    node.LeftChild = loadTreeHelper(xmlDoc, lElem, node, level + 1);
        //    node.RightChild = loadTreeHelper(xmlDoc, rElem, parentNode, level);
        //    return node;
        //}

    }

}