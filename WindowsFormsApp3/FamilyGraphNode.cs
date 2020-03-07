using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilySys
{
    public class FamilyGraphNode
    {
        #region//属性
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public bool IsDead { get; set; }
        /*
        public string Birthday { get; set; }
        public string Deathday { get; set; }
        public string Birthplace { get; set; }//出生地
        public string Education { get; set; }//教育背景
        public string Profession { get; set; }
        public string HighestProfessionRank { get; set; }//职位
        public int Level { get; set; }//家庭地位等级？可用于树结构
        */
        public string EncodeStr { get; set; }//关系编码
        public bool IsVisited { get; set; }//该节点是否被访问过
        #endregion
        #region//亲戚关系
        public FamilyGraphNode _me;             //encode:00
        public FamilyGraphNode _father;         //encode:01
        public FamilyGraphNode _mother;         //encode:02
        public FamilyGraphNode _son;            //encode:11
        public FamilyGraphNode _daughter;       //encode:12
        public FamilyGraphNode _elderBrother;   //encode:21
        public FamilyGraphNode _elderSister;    //encode:22
        public FamilyGraphNode _littleBrother;  //encode:31
        public FamilyGraphNode _littleSister;   //encode:32
        public FamilyGraphNode _husband;        //encode:41
        public FamilyGraphNode _wife;           //encode:42
        #endregion
        #region//关系编码
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
         * 
         * 扩展关系：最短编码
         * 
         * 爷爷 父亲的父亲 0101
         * 奶奶 父亲的母亲 0102
         * 我（male）、大哥、小弟 父亲的儿子 0111
         * 我（female）、大姐、小妹 父亲的female儿 0112
         * 伯父 父亲的大哥 0121
         * 姑妈 父亲的大姐 0122
         * 叔叔 父亲的小弟 0131
         * 小姑 父亲的小妹 0132
         * 母亲 父亲的妻子 0142
         * 
         * 外公 母亲的父亲 0201
         * 外婆 母亲的母亲 0202
         * 我（male）、大哥、小弟 母亲的儿子 0211
         * 我（female）、大姐、小妹 母亲的female儿 0212
         * 大舅 母亲的大哥 0221
         * 小舅 母亲的大姐 0222
         * 大姨 母亲的小弟 0231
         * 小姨 母亲的小妹 0232
         * 父亲 母亲的丈夫 0241
         * 
         * 我(male)、老公 儿子的父亲 1101
         * 我(female)、老婆 儿子的母亲 1102
         * 孙子 儿子的儿子 1111
         * 孙female 儿子的female儿 1112
         * 儿子 儿子的大哥 1121
         * female儿 儿子的大姐 1122
         * 儿子 儿子的小弟 1131
         * female儿 儿子的小妹 1132
         * 儿媳妇 儿子的妻子 1142
         * 
         * 我(male)、老公 female儿的父亲 1201
         * 我(female)、老婆 female儿的母亲 1202
         * 孙子 female儿的儿子 1211
         * 孙female female儿的female儿 1212
         * 儿子 female儿的大哥 1221
         * female儿 female儿的大姐 1222
         * 儿子 female儿的小弟 1231
         * female儿 female儿的小妹 1232
         * female婿 female儿的丈夫 1241
         * 
         * 父亲 大哥的父亲 2101
         * 母亲 大哥的母亲 2102
         * 侄子 大哥的儿子 2111
         * 侄female 大哥的female儿 2112
         * 大哥 大哥的大哥 2121
         * 大姐 大哥的大姐 2122
         * 我（male）、大哥、小弟 大哥的小弟 2131
         * 我（female）、大姐、小妹 大哥的小妹 2132
         * 嫂子 大哥的妻子 2142
         * 
         * 父亲 大姐的父亲 2201
         * 母亲 大姐的母亲 2202
         * 外甥 大姐的儿子 2211
         * 外甥female 大姐的female儿 2212
         * 大哥 大姐的大哥 2221
         * 大姐 大姐的大姐 2222
         * 我（male）、大哥、小弟 大姐的小弟 2231
         * 我（female）、大姐、小妹 大姐的小妹 2232
         * 姐夫 大姐的丈夫 2241
         * 
         * 父亲 小弟的父亲 3101
         * 母亲 小弟的母亲 3102
         * 侄子 小弟的儿子 3111
         * 侄female 小弟的female儿 3112
         * 我（male）、大哥、小弟 小弟的大哥 3121
         * 我（female）、大姐、小妹 小弟的大姐 3122
         * 小弟 小弟的小弟 3131
         * 小妹 小弟的小妹 3132
         * 弟妹 小弟的妻子 3142
         * 
         * 父亲 小妹的父亲 3201
         * 母亲 小妹的母亲 3202
         * 外甥 小妹的儿子 3211
         * 外甥female 小妹的female儿 3212
         * 我（male）、大哥、小弟 小妹的大哥 3221
         * 我（female）、大姐、小妹 小妹的大姐 3222
         * 小弟 小妹的小弟 3231
         * 小妹 小妹的小妹 3232
         * 妹夫 小妹的丈夫 3241
         * 
         * 公公 丈夫的父亲 4101
         * 婆婆 丈夫的母亲 4102
         * 儿子 丈夫的儿子 4111
         * 小姑子 丈夫的female儿 4112
         * 大伯子 丈夫的大哥 4121
         * 大姑子 丈夫的大姐 4122
         * 小叔子 丈夫的小弟 4131
         * 小姑子 丈夫的小妹 4132
         * 我（female） 丈夫的妻子 4142
         *
         * 岳父 妻子的父亲 4201
         * 岳母 妻子的母亲 4202
         * 儿子 妻子的儿子 4211
         * female儿 妻子的female儿 4212
         * 大舅子 妻子的大哥 4221
         * 大姨子 妻子的大姐 4222
         * 小舅子 妻子的小弟 4231
         * 小姨子 妻子的小妹 4232
         * 我（male） 妻子的丈夫 4241
         */
        #endregion
        #region//构造方法
        public FamilyGraphNode()
        {
            _me = this;
            _father = null;
            _mother = null;
            _son = null;
            _daughter = null;
            _elderBrother = null;
            _elderSister = null;
            _littleBrother = null;
            _littleSister = null;
        }
        public FamilyGraphNode(string name)
        {
            this.Name = name;
            _me = this;
            _father = null;
            _mother = null;
            _son = null;
            _daughter = null;
            _elderBrother = null;
            _elderSister = null;
            _littleBrother = null;
            _littleSister = null;
        }
        public FamilyGraphNode(string name, int age, string gender, bool isDead, string encodeStr)
            : this()
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.IsDead = isDead;
            this.EncodeStr = encodeStr;
            this.IsVisited = false;
        }
        /*
        public Person(string Name, string Gender, string EncodeStr, string birthday, string deathday, string bornPlace = null, string eduBackground = null, string profession = null, string highestProfessionRank = null)
            : this()
        {
            this.IsDead = true;
            this.Name = Name;
            this.Gender = Gender;
            this.EncodeStr = EncodeStr;
            this.birthday = birthday;
            this.deathday = deathday;
            string birthyear = birthday.Substring(0, 4);
            string deathyear = deathday.Substring(0, 4);
            this.Age = int.Parse(deathyear) - int.Parse(birthyear);
            this.bornPlace = bornPlace;
            this.eduBackground = eduBackground;
            this.profession = profession;
            this.highestProfessionRank = highestProfessionRank;

            this.IsVisited = false;
        }
        public Person(string Name, string Gender, string EncodeStr, string birthday, string bornPlace = null, string eduBackground = null, string profession = null, string highestProfessionRank = null)
            : this()
        {
            this.IsDead = false;
            this.Name = Name;
            this.Gender = Gender;
            this.EncodeStr = EncodeStr;
            this.birthday = birthday;
            string birthyear = birthday.Substring(0, 4);
            string nowyear = DateTime.Now.Year.ToString();
            this.Age = int.Parse(nowyear) - int.Parse(birthyear);
            this.bornPlace = bornPlace;
            this.eduBackground = eduBackground;
            this.profession = profession;
            this.highestProfessionRank = highestProfessionRank;

            this.IsVisited = false;
        }
        */
        #endregion
        #region//设置亲戚关系
        private void setToBeFatherOf(FamilyGraphNode p)
        {
            p._father = this;
            if (p.Gender == "male")
            {
                this._son = p;
            }
            else if (p.Gender == "female")
            {
                this._daughter = p;
            }
        }
        private void setToBeMotherOf(FamilyGraphNode p)
        {
            p._mother = this;
            if (p.Gender == "male")
            {
                this._son = p; ;
            }
            else if (p.Gender == "female")
            {
                this._daughter = p; ;
            }
        }
        private void setToBeSonOf(FamilyGraphNode p)
        {
            p._son = this;
            if (p.Gender == "male")
            {
                this._father = p;
            }
            else if (p.Gender == "female")
            {
                this._mother = p;
            }
        }
        private void setToBeDaughterOf(FamilyGraphNode p)
        {
            p._daughter = this;
            if (p.Gender == "male")
            {
                this._father = p;
            }
            else if (p.Gender == "female")
            {
                this._mother = p;
            }
        }
        private void setToBeElderBrotherOf(FamilyGraphNode p)
        {
            p._elderBrother = this;
            if (p.Gender == "male")
            {
                this._littleBrother = p;
            }
            else if (p.Gender == "female")
            {
                this._littleSister = p;
            }
        }
        private void setToBeElderSisterOf(FamilyGraphNode p)
        {
            p._elderSister = this;
            if (p.Gender == "male")
            {
                this._littleBrother = p;
            }
            else if (p.Gender == "female")
            {
                this._littleSister = p;
            }
        }
        private void setToBeLittleBrotherOf(FamilyGraphNode p)
        {
            p._littleBrother = this;
            if (p.Gender == "male")
            {
                this._elderBrother = p;
            }
            else if (p.Gender == "female")
            {
                this._elderSister = p;
            }
        }
        private void setToBeLittleSisterOf(FamilyGraphNode p)
        {
            p._littleSister = this;
            if (p.Gender == "male")
            {
                this._elderBrother = p;
            }
            else if (p.Gender == "female")
            {
                this._elderSister = p;
            }
        }
        private void setToBeHusbandOf(FamilyGraphNode p)
        {
            this._wife = p;
            p._husband = this;
        }
        private void setToBeWifeOf(FamilyGraphNode p)
        {
            this._husband = p;
            p._wife = this;
        }
        #endregion
        #region//设置亲戚关系接口
        public static bool setHusbandAndWife(FamilyGraphNode husband, FamilyGraphNode wife)
        {
            if (husband.Gender == "male" && wife.Gender == "female")
            {
                husband.setToBeHusbandOf(wife);
                return true;
            }
            else if (husband.Gender == "female" && wife.Gender == "male")
            {
                husband.setToBeWifeOf(wife);
                return true;
            }
            else
            {
                Console.WriteLine("Person::setHusbandAndWife()输入有误");
                return false;
            }
        }
        public static bool setParentAndKid(FamilyGraphNode parent, FamilyGraphNode kid)
        {
            if (parent.Age >= kid.Age)
            {
                if (parent.Gender == "male")
                {
                    parent.setToBeFatherOf(kid);
                    return true;
                }
                else if (parent.Gender == "female")
                {
                    parent.setToBeMotherOf(kid);
                    return true;
                }
            }
            else if (parent.Age < kid.Age)
            {
                if (kid.Gender == "male")
                {
                    kid.setToBeFatherOf(parent);
                    return true;
                }
                else if (kid.Gender == "female")
                {
                    kid.setToBeMotherOf(parent);
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Person::setParentAndKid()输入有误");
                return false;
            }
            return false;
        }
        public static bool setBrotherAndSister(FamilyGraphNode elder, FamilyGraphNode younger)
        {
            if (elder.Age >= younger.Age)
            {
                if (elder.Gender == "male")
                {
                    elder.setToBeElderBrotherOf(younger);
                }
                else if (elder.Gender == "female")
                {
                    elder.setToBeElderSisterOf(younger);
                }
                return true;
            }
            else if (elder.Age < younger.Age)
            {
                if (elder.Gender == "male")
                {
                    elder.setToBeLittleBrotherOf(younger);
                }
                else if (elder.Gender == "female")
                {
                    elder.setToBeLittleSisterOf(younger);
                }
                return true;
            }
            //else if (elder.birthday != null && younger.birthday != null)
            //{
            //    if ((elder.birthday).CompareTo(younger.birthday) <= 0)
            //    {
            //        if (elder.Gender == "male")
            //        {
            //            elder.setToBeElderBrotherOf(younger);
            //        }
            //        else if (elder.Gender == "female")
            //        {
            //            elder.setToBeElderSisterOf(younger);
            //        }
            //        return true;
            //    }
            //    else if ((elder.birthday).CompareTo(younger.birthday) > 0)
            //    {
            //        if (elder.Gender == "male")
            //        {
            //            elder.setToBeLittleBrotherOf(younger);
            //        }
            //        else if (elder.Gender == "female")
            //        {
            //            elder.setToBeLittleSisterOf(younger);
            //        }
            //        return true;
            //    }
            //}
            else
            {
                Console.WriteLine("Person::setBrotherAndSister()输入有误");
                return false;
            }

        }
        #endregion
        #region//判断亲戚关系接口
        public static bool isHusbandAndWife(FamilyGraphNode husband, FamilyGraphNode wife)
        {
            if (husband.Gender == "male" && wife.Gender == "female")
            {
                if (husband._wife == wife)
                    return true;
            }
            else if (husband.Gender == "female" && wife.Gender == "male")
            {
                if (husband._husband == wife)
                    return true;
            }
            else
            {
                Console.WriteLine("Person::isHusbandAndWife()输入有误");
                return false;
            }
            return false;
        }
        public static bool isParentAndKid(FamilyGraphNode parent, FamilyGraphNode kid)
        {
            if (parent.Age >= kid.Age)
            {
                if (parent._son == kid || parent._daughter == kid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (parent.Age < kid.Age)
            {
                if (parent._father == kid || parent._mother == kid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //else if (parent.birthday != null && kid.birthday != null)
            //{
            //    if ((parent.birthday).CompareTo(kid.birthday) <= 0)
            //    {
            //        if (parent._son == kid || parent._daughter == kid)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else if ((parent.birthday).CompareTo(kid.birthday) > 0)
            //    {
            //        if (parent._father == kid || parent._mother == kid)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //}
            else
            {
                Console.WriteLine("Person::isParentAndKid()输入有误");
                return false;
            }
        }
        public static bool isBrotherAndSister(FamilyGraphNode elder, FamilyGraphNode younger)
        {
            if (elder.Age >= younger.Age)
            {
                if (elder._littleBrother == younger || elder._littleSister == younger)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (elder.Age < younger.Age)
            {
                if (elder._elderBrother == younger || elder._elderSister == younger)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //else if (elder.birthday != null && younger.birthday != null)
            //{
            //    if ((elder.birthday).CompareTo(younger.birthday) <= 0)
            //    {
            //        if (elder._littleBrother == younger || elder._littleSister == younger)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else if ((elder.birthday).CompareTo(younger.birthday) > 0)
            //    {
            //        if (elder._elderBrother == younger || elder._elderSister == younger)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //}
            else
            {
                Console.WriteLine("Person::isBrotherAndSister()输入有误");
                return false;
            }
        }
        #endregion
        #region//解除亲戚关系接口
        public static bool unsetHusbandAndWife(FamilyGraphNode husband, FamilyGraphNode wife)
        {
            if (husband.Gender == "male" && wife.Gender == "female")
            {
                husband._wife = null;
                wife._husband = null;
                return true;
            }
            else if (husband.Gender == "female" && wife.Gender == "male")
            {
                husband._husband = null;
                wife._wife = null;
                return true;
            }
            else
            {
                Console.WriteLine("Person::unsetHusbandAndWife()输入有误");
                return false;
            }
        }
        public static bool unsetParentAndKid(FamilyGraphNode parent, FamilyGraphNode kid)
        {
            if (parent.Age >= kid.Age)
            {
                if (parent.Gender == "male")
                {
                    if (kid.Gender == "male")
                    {
                        parent._son = null;
                        kid._father = null;
                    }
                    else if (kid.Gender == "female")
                    {
                        parent._daughter = null;
                        kid._father = null;
                    }
                    return true;
                }
                else if (parent.Gender == "female")
                {
                    if (kid.Gender == "male")
                    {
                        parent._son = null;
                        kid._mother = null;
                    }
                    else if (kid.Gender == "female")
                    {
                        parent._daughter = null;
                        kid._mother = null;
                    }
                    return true;
                }
            }
            else if (parent.Age < kid.Age)
            {
                if (parent.Gender == "male")
                {
                    if (kid.Gender == "male")
                    {
                        parent._father = null;
                        kid._son = null;
                    }
                    else if (kid.Gender == "female")
                    {
                        parent._mother = null;
                        kid._son = null;
                    }
                    return true;
                }
                else if (parent.Gender == "female")
                {
                    if (kid.Gender == "male")
                    {
                        parent._father = null;
                        kid._daughter = null;
                    }
                    else if (kid.Gender == "female")
                    {
                        parent._mother = null;
                        kid._daughter = null;
                    }
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Person::unsetParentAndKid()输入有误");
                return false;
            }
            return false;
        }
        public static bool unsetBrotherAndSister(FamilyGraphNode elder, FamilyGraphNode younger)
        {
            if (elder.Age >= younger.Age)
            {
                if (elder.Gender == "male")
                {
                    elder.setToBeElderBrotherOf(younger);
                }
                else if (elder.Gender == "female")
                {
                    elder.setToBeElderSisterOf(younger);
                }
                return true;
            }
            else if (elder.Age < younger.Age)
            {
                if (elder.Gender == "male")
                {
                    elder.setToBeLittleBrotherOf(younger);
                }
                else if (elder.Gender == "female")
                {
                    elder.setToBeLittleSisterOf(younger);
                }
                return true;
            }
            //else if ((elder.birthday).CompareTo(younger.birthday) <= 0)
            //{
            //    if (elder.Gender == "male")
            //    {
            //        elder.setToBeElderBrotherOf(younger);
            //    }
            //    else if (elder.Gender == "female")
            //    {
            //        elder.setToBeElderSisterOf(younger);
            //    }
            //    return true;
            //}
            //else if ((elder.birthday).CompareTo(younger.birthday) > 0)
            //{
            //    if (elder.Gender == "male")
            //    {
            //        elder.setToBeLittleBrotherOf(younger);
            //    }
            //    else if (elder.Gender == "female")
            //    {
            //        elder.setToBeLittleSisterOf(younger);
            //    }
            //    return true;
            //}
            else
            {
                Console.WriteLine("Person::unsetBrotherAndSister()输入有误");
                return false;
            }
        }
        #endregion
    }
}
