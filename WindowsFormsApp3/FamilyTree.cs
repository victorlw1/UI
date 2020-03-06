using System;
using System.Collections.Generic;
using System.Xml;

namespace FamilySys
{

    public class FamilyTree
    {
        public FamilyTreeNode root;
        public FamilyTree()
        {
            root = null;
        }
        public FamilyTree(string name, int age, string gender, bool isDead, DateTime birthday, string birthplace, DateTime deathday, string height, string education, string profession, string highestProfessionRank)
        {
            root = new FamilyTreeNode(name, age, gender, isDead, birthday, birthplace, deathday, height, education, profession, highestProfessionRank);
        }

        public static void DFS_output(FamilyTreeNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.Name);
            DFS_output(node.LeftChild);
            DFS_output(node.RightChild);
        }
        public static void DFS_output_all_age(FamilyTreeNode node,int age,int man,int woman)
        {
            if (node == null) return;
            age = age + node.Age;
            if (node.Gender == "male")
            {
                ++man;
            }
            else
                ++woman;
            DFS_output_all_age(node.LeftChild,age,man,woman);
            DFS_output_all_age(node.RightChild,age,man,woman);

        }
        



        public static void DFS_getAll(FamilyTreeNode node,List<FamilyTreeNode> familyTreeNodes)
        {
            if (node == null) return;
            familyTreeNodes.Add(node);
            DFS_getAll(node.LeftChild, familyTreeNodes);
            DFS_getAll(node.RightChild, familyTreeNodes);
        }

        public FamilyTreeNode query(FamilyTreeNode startNode, string name)//HowToQuery
        {
            if (startNode == null) return null;
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

        public void insert_parent(FamilyTreeNode node)
        {
            if (root == null)
            {
                node.Parent = null;
                node.Level = 1;
                root = node;
                return;
            }
            else 
            {
                node.Level = root.Level - 1;
                node.Parent = null;
                node.LeftChild = root;
                root.Parent = node;
                root = node;
            }
        }
        public void insert_child(FamilyTreeNode node, string fatherName)
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

        public void get_sons(string name,List<FamilyTreeNode> sonNodes)
        {
            if (root == null)
            {
                return;
            }
            FamilyTreeNode temp = query(root, name);
            if (temp != null)
            {
                if (temp.LeftChild == null)
                {
                    return;
                }
                else
                {
                    FamilyTreeNode p = temp;
                    temp = temp.LeftChild;
                    while (temp != null)
                    {
                        if (temp.Gender == "male")
                        {
                            sonNodes.Add(temp);
                        }
                        temp = temp.RightChild;
                    }
                }
            }
        }
        public void get_daughters(string name, List<FamilyTreeNode> sonNodes)
        {
            if (root == null)
            {
                return;
            }
            FamilyTreeNode temp = query(root, name);
            if (temp != null)
            {
                if (temp.LeftChild == null)
                {
                    return;
                }
                else
                {
                    FamilyTreeNode p = temp;
                    temp = temp.LeftChild;
                    while (temp != null)
                    {
                        if (temp.Gender == "female")
                        {
                            sonNodes.Add(temp);
                        }
                        temp = temp.RightChild;
                    }
                }
            }
        }
        public void get_elderBrothers(string name, List<FamilyTreeNode> elderBrotherNodes)
        {
            if (root == null)
            {
                return;
            }
            FamilyTreeNode temp = query(root, name);
            FamilyTreeNode p = temp.RightChild;
            while (p != null)
            {
                if (p.Gender == "male" &&( p.Age > temp.Age||DateTime.Compare(p.Birthday,temp.Birthday)<0))
                {
                    elderBrotherNodes.Add(p);
                }
                p = p.RightChild;
            }
        }
        public void get_littleBrothers(string name, List<FamilyTreeNode> littleBrotherNodes)
        {
            if (root == null)
            {
                return;
            }
            FamilyTreeNode temp = query(root, name);
            FamilyTreeNode p = temp.RightChild;
            while (p != null)
            {
                if (p.Gender == "male" && (p.Age < temp.Age || DateTime.Compare(p.Birthday, temp.Birthday) > 0))
                {
                    littleBrotherNodes.Add(p);
                }
                p = p.RightChild;
            }
        }
        public void get_elderSisters(string name, List<FamilyTreeNode> elderSisterNodes)
        {
            if (root == null)
            {
                return;
            }
            FamilyTreeNode temp = query(root, name);
            FamilyTreeNode p = temp.RightChild;
            while (p != null)
            {
                if (p.Gender == "female" && ( p.Age > temp.Age||DateTime.Compare(p.Birthday,temp.Birthday)<0))
                {
                    elderSisterNodes.Add(p);
                }
                p = p.RightChild;
            }
        }
        public void get_littleSisters(string name, List<FamilyTreeNode> littleSisterNodes)
        {
            if (root == null)
            {
                return;
            }
            FamilyTreeNode temp = query(root, name);
            FamilyTreeNode p = temp.RightChild;
            while (p != null)
            {
                if (p.Gender == "female" && (p.Age < temp.Age || DateTime.Compare(p.Birthday, temp.Birthday) > 0))
                {
                    littleSisterNodes.Add(p);
                }
                p = p.RightChild;
            }
        }
        public void delete(string name)
        {
            FamilyTreeNode temp = query(root, name);
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
            temp.Name = null;
            temp.Birthplace = null;
            temp.Birthday = new DateTime(2000, 1, 1);
            temp.Deathday = new DateTime(2000, 1, 1);
            temp.Gender = null;
            temp.Height = null;
            temp.Education = null;
            temp.Profession = null;
            temp.HighestProfessionRank = null;
        }
        public void update(string name,string newName, int newAge, string newGender, bool newIsDead, DateTime newBirthday, string newBirthplace, DateTime newDeathday, string newHeight, string newEducation, string newProfession, string newHighestProfessionRank)
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
            DateTime str1 = node1.Birthday;
            DateTime str2 = node2.Birthday;
            for (int i = 0; i < 8; i++)
            {
                if (str1 > str2)
                    return false;
                if (str1 < str2)
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
        * female儿 12
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
            if (node1 == node2)
                return "00";
            if (node1.Level > node2.Level)
            {
                while (node1.Level != node2.Level)
                {
                    node1 = node1.Parent;
                    if (node1.Gender == "male")
                        result += "01";
                    else
                        result += "02";
                }
            }
            else if (node1.Level < node2.Level)
            {
                while (node1.Level != node2.Level)
                {
                    if (node2.Gender == "male")
                        result_rev += "11";
                    else
                        result_rev += "21";
                    node2 = node2.Parent;
                }
            }

            while (isSibling(node1, node2) == -1)
            {
                node1 = node1.Parent;
                if (node1.Gender == "male")
                    result += "01";
                else
                    result += "02";
                if (node2.Gender == "male")
                    result_rev += "11";
                else
                    result_rev += "21";
                node2 = node2.Parent;
            }

            if (isSibling(node1, node2) != 0)
            {
                if (node2.Gender == "male")
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


        public void saveTree(string filePath) //将树保存到本地

        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            xmlDoc.AppendChild(xmlDeclaration);
            XmlElement rootElem = xmlDoc.CreateElement("root");
            xmlDoc.AppendChild(rootElem);
            saveTreeHelper(xmlDoc, rootElem, root);
            xmlDoc.Save(filePath);
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
            elem.SetAttribute("bd", node.Birthday.ToString());
            elem.SetAttribute("id", node.IsDead.ToString());
            elem.SetAttribute("dd", node.Deathday.ToString());
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

        public void loadTree(string filePath) //从本地加载一棵树
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(filePath);
            XmlNode xmlnode = xmldoc.SelectSingleNode("root");
            XmlElement xmlelem = (XmlElement)xmlnode;
            root = loadTreeHelper(xmldoc, xmlelem, null, 0);
        }

        public FamilyTreeNode loadTreeHelper(XmlDocument xmlDoc, XmlElement xmlElem, FamilyTreeNode parentNode, int level)
        {
            if (xmlElem.GetAttribute("emp") == "y")
            {
                FamilyTreeNode node1 = null;
                return node1;
            }
            string name = xmlElem.GetAttribute("n");
            string birthplace = xmlElem.GetAttribute("bp");
            string birthdayStr = xmlElem.GetAttribute("bd");
            DateTime birthday = Convert.ToDateTime(birthdayStr);
            string isDead_str = xmlElem.GetAttribute("id");
            bool isDead;
            if (isDead_str == "True")
            {
                isDead = true;
            }
            else
            {
                isDead = false;
            }
            string deathdayStr = xmlElem.GetAttribute("dd");
            DateTime deathday = Convert.ToDateTime(deathdayStr);
            int birthday_int = (int)Double.Parse(birthdayStr.Substring(0, 4));
            int age = 0;
            if (isDead)
            {
                int deathday_int = (int)Double.Parse(deathdayStr.Substring(0, 4));
                age = deathday_int - birthday_int;
            }
            else 
            {
                DateTime currentTime = System.DateTime.Now;
                int defaultYear = currentTime.Year;
                age = defaultYear - birthday_int;
            }

            string gender = xmlElem.GetAttribute("g");
            string height = xmlElem.GetAttribute("h");
            string education = xmlElem.GetAttribute("e");
            string profession = xmlElem.GetAttribute("p");
            string highestProfessionRank = xmlElem.GetAttribute("hp");
            FamilyTreeNode node = new FamilyTreeNode(name, age, gender, isDead, birthday, birthplace, deathday, height, education, profession, highestProfessionRank);
            node.Parent = parentNode;
            node.Level = level;
            XmlElement lElem = (XmlElement)xmlElem.SelectSingleNode("l");
            XmlElement rElem = (XmlElement)xmlElem.SelectSingleNode("r");
            node.LeftChild = loadTreeHelper(xmlDoc, lElem, node, level + 1);
            node.RightChild = loadTreeHelper(xmlDoc, rElem, parentNode, level);
            return node;
        }

    }

}