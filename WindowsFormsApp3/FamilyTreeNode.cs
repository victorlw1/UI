using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class FamilyTreeNode
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthplace { get; set; }
        public string Birthday { get; set; }
        public string Deathday { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string HighestProfessionRank { get; set; }
        public int Level { get; set; }
        public FamilyTreeNode LeftChild { get; set; }
        public FamilyTreeNode RightChild { get; set; }
        public FamilyTreeNode Parent { get; set; }
        public FamilyTreeNode() { }
        public FamilyTreeNode(string name, string birthplace, string birthday, string deathday, string gender, string height, string education, string profession, string highestProfessionRank)
        {
            Name = name;
            Birthplace = birthplace;
            Birthday = birthday;
            Deathday = deathday;
            Gender = gender;
            Height = height;
            Education = education;
            Profession = profession;
            HighestProfessionRank = highestProfessionRank;
        }
    }
}
