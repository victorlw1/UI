using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilySys
{
    public class FamilyGraph
    {
        FamilyGraphNode 我;
        FamilyGraphNode me_startPoi;
        FamilyGraphNode curr;
        int memberCount;
        public enum HowToQuery { ByNAME, ByENCODE };
        public enum HowToDel { ByNAME, ByENCODE };
        public enum HowToAlt { ByNAME, ByENCODE };

        public FamilyGraph()
        {
            initializeGraph();
            me_startPoi = null;
            curr = null;
            memberCount = 0;
        }

        public void initializeGraph()//基本关系：爸 妈 兄 弟 姐 妹 儿 女
        {
            我 = new FamilyGraphNode("我");
            FamilyGraphNode 爸爸 = new FamilyGraphNode("爸爸");
            FamilyGraphNode 妈妈 = new FamilyGraphNode("妈妈");
            FamilyGraphNode 哥哥 = new FamilyGraphNode("哥哥");
            FamilyGraphNode 弟弟 = new FamilyGraphNode("弟弟");
            FamilyGraphNode 姐姐 = new FamilyGraphNode("姐姐");
            FamilyGraphNode 妹妹 = new FamilyGraphNode("妹妹");
            FamilyGraphNode 儿子 = new FamilyGraphNode("儿子");
            FamilyGraphNode 女儿 = new FamilyGraphNode("女儿");
            FamilyGraphNode 爷爷 = new FamilyGraphNode("爷爷");
            FamilyGraphNode 奶奶 = new FamilyGraphNode("奶奶");
            FamilyGraphNode 伯父 = new FamilyGraphNode("伯父");//爸爸的哥哥
            FamilyGraphNode 叔父 = new FamilyGraphNode("叔父");//爸爸的弟弟
            FamilyGraphNode 姑姑 = new FamilyGraphNode("姑姑");//爸爸的姐妹
            FamilyGraphNode 外公 = new FamilyGraphNode("外公");
            FamilyGraphNode 外婆 = new FamilyGraphNode("外婆");
            FamilyGraphNode 舅舅 = new FamilyGraphNode("舅舅");//妈妈的兄弟
            FamilyGraphNode 姨妈 = new FamilyGraphNode("姨妈");//妈妈的姐妹
            FamilyGraphNode 侄子 = new FamilyGraphNode("侄子");//兄弟的儿子
            FamilyGraphNode 侄女 = new FamilyGraphNode("侄女");//兄弟的女儿
            FamilyGraphNode 外甥 = new FamilyGraphNode("外甥");//姐妹的儿子
            FamilyGraphNode 外甥女 = new FamilyGraphNode("外甥女");//姐妹的女儿
            FamilyGraphNode 孙子 = new FamilyGraphNode("孙子");//儿子的儿子
            FamilyGraphNode 孙女 = new FamilyGraphNode("孙女");//儿子的女儿
            FamilyGraphNode 外孙 = new FamilyGraphNode("外孙");//女儿的儿子
            FamilyGraphNode 外孙女 = new FamilyGraphNode("外孙女");//女儿的女儿
            FamilyGraphNode 伯祖父 = new FamilyGraphNode("伯祖父");//爷爷的哥哥
            FamilyGraphNode 叔祖父 = new FamilyGraphNode("叔祖父");//爷爷的弟弟
            FamilyGraphNode 姑奶奶 = new FamilyGraphNode("姑奶奶");//爷爷的姐妹
            FamilyGraphNode 舅爷爷 = new FamilyGraphNode("舅爷爷");//奶奶的兄弟
            FamilyGraphNode 姨奶奶 = new FamilyGraphNode("姨奶奶");//奶奶的姐妹
            FamilyGraphNode 堂兄弟 = new FamilyGraphNode("堂兄弟");//伯父/叔父的儿子
            FamilyGraphNode 堂姐妹 = new FamilyGraphNode("堂姐妹");//伯父/叔父的女儿
            FamilyGraphNode 表兄弟 = new FamilyGraphNode("表兄弟");//姑姑/舅舅/姨妈的儿子
            FamilyGraphNode 表姐妹 = new FamilyGraphNode("表姐妹");//姑姑/舅舅/姨妈的女儿
            FamilyGraphNode 伯外祖父 = new FamilyGraphNode("伯外祖父");//外公的哥哥
            FamilyGraphNode 叔外祖父 = new FamilyGraphNode("叔外祖父");//外公的弟弟
            FamilyGraphNode 姑姥姥 = new FamilyGraphNode("姑姥姥");//外公的姐妹
            FamilyGraphNode 舅老爷 = new FamilyGraphNode("舅老爷");//外婆的兄弟
            FamilyGraphNode 姨姥姥 = new FamilyGraphNode("姨姥姥");//外婆的姐妹
            FamilyGraphNode 侄孙 = new FamilyGraphNode("侄孙");//侄子的儿子
            FamilyGraphNode 侄孙女 = new FamilyGraphNode("侄孙女");//侄子的女儿
            FamilyGraphNode 外侄孙子= new FamilyGraphNode("外侄孙子");//侄女的儿子
            FamilyGraphNode 外侄孙女 = new FamilyGraphNode("外侄孙女");//侄女的女儿
            FamilyGraphNode 甥孙 = new FamilyGraphNode("甥孙");//外甥的儿子
            FamilyGraphNode 甥孙女 = new FamilyGraphNode("甥孙女");//外甥的女儿
            FamilyGraphNode 甥外孙 = new FamilyGraphNode("甥外孙");//外甥女的儿子
            FamilyGraphNode 甥外孙女 = new FamilyGraphNode("甥外孙女");//外甥女的女儿

            我._father = 爸爸;
            我._mother = 妈妈;
            我._elderBrother = 哥哥;
            我._elderSister = 姐姐;
            我._littleBrother = 弟弟;
            我._littleSister = 妹妹;
            我._son = 儿子;
            我._daughter = 女儿;

            爸爸._father = 爷爷;
            爸爸._mother = 奶奶;
            爸爸._elderBrother = 伯父;
            爸爸._elderSister = 姑姑;
            爸爸._littleBrother = 叔父;
            爸爸._littleSister = 姑姑;
            爸爸._son = 哥哥;        //findRelation的代码不会出现这种情况，不过以防万一，假设：我就是个弟弟
            爸爸._daughter = 姐姐;

            妈妈._father = 外公;
            妈妈._mother = 外婆;
            妈妈._elderBrother = 舅舅;
            妈妈._elderSister = 姨妈;
            妈妈._littleBrother = 舅舅;
            妈妈._littleSister = 姨妈;
            妈妈._son = 哥哥;
            妈妈._daughter = 姐姐;

            哥哥._father = 爸爸;
            哥哥._mother = 妈妈;
            哥哥._elderBrother = 哥哥;
            哥哥._elderSister = 姐姐;
            哥哥._littleBrother = 哥哥;
            哥哥._littleSister = 姐姐;
            哥哥._son = 侄子;
            哥哥._daughter = 侄女;

            弟弟._father = 爸爸;
            弟弟._mother = 妈妈;
            弟弟._elderBrother = 哥哥;
            弟弟._elderSister = 姐姐;
            弟弟._littleBrother = 弟弟;
            弟弟._littleSister = 妹妹;
            弟弟._son = 侄子;
            弟弟._daughter = 侄女;

            姐姐._father = 爸爸;
            姐姐._mother = 妈妈;
            姐姐._elderBrother = 哥哥;
            姐姐._elderSister = 姐姐;
            姐姐._littleBrother = 哥哥;
            姐姐._littleSister = 姐姐;
            姐姐._son = 外甥;
            姐姐._daughter = 外甥女;

            妹妹._father = 爸爸;
            妹妹._mother = 妈妈;
            妹妹._elderBrother = 哥哥;
            妹妹._elderSister = 姐姐;
            妹妹._littleBrother = 弟弟;
            妹妹._littleSister = 妹妹;
            妹妹._son = 外甥;
            妹妹._daughter = 外甥女;

            儿子._father = 我;
            儿子._mother = 我;
            儿子._elderBrother = 儿子;
            儿子._elderSister = 女儿;
            儿子._littleBrother = 儿子;
            儿子._littleSister = 女儿;
            儿子._son = 孙子;
            儿子._daughter = 孙女;

            女儿._father = 我;
            女儿._mother = 我;
            女儿._elderBrother = 儿子;
            女儿._elderSister = 女儿;
            女儿._littleBrother = 儿子;
            女儿._littleSister = 女儿;
            女儿._son = 外孙;
            女儿._daughter = 外孙女;

            爷爷._father = null;
            爷爷._mother = null;
            爷爷._elderBrother = 伯祖父;
            爷爷._elderSister = 姑奶奶;
            爷爷._littleBrother = 叔祖父;
            爷爷._littleSister = 姑奶奶;
            爷爷._son = 爸爸;
            爷爷._daughter = 姑姑;

            奶奶._father = null;
            奶奶._mother = null;
            奶奶._elderBrother = 舅爷爷;
            奶奶._elderSister = 姨奶奶;
            奶奶._littleBrother = 舅爷爷;
            奶奶._littleSister = 姨奶奶;
            奶奶._son = 舅舅;
            奶奶._daughter = 妈妈;

            伯父._father = 爷爷;
            伯父._mother = 奶奶;
            伯父._elderBrother = 伯父;
            伯父._elderSister = 姑姑;
            伯父._littleBrother = 伯父;
            伯父._littleSister = 姑姑;
            伯父._son = 堂兄弟;
            伯父._daughter = 堂姐妹;

            叔父._father = 爷爷;
            叔父._mother = 奶奶;
            叔父._elderBrother = 伯父;
            叔父._elderSister = 姑姑;
            叔父._littleBrother = 叔父;
            叔父._littleSister = 姑姑;
            叔父._son = 堂兄弟;
            叔父._daughter = 堂姐妹;

            姑姑._father = 爷爷;
            姑姑._mother = 奶奶;
            姑姑._elderBrother = 伯父;
            姑姑._elderSister = 姑姑;
            姑姑._littleBrother = 伯父;
            姑姑._littleSister = 姑姑;
            姑姑._son = 表兄弟;
            姑姑._daughter = 表姐妹;

            外公._father = null;
            外公._mother = null;
            外公._elderBrother = 伯外祖父;
            外公._elderSister = 姑姥姥;
            外公._littleBrother = 叔外祖父;
            外公._littleSister = 姑姥姥;
            外公._son = 舅舅;
            外公._daughter = 妈妈;

            外婆._father = null;
            外婆._mother = null;
            外婆._elderBrother = 舅老爷;
            外婆._elderSister = 姨姥姥;
            外婆._littleBrother = 舅老爷;
            外婆._littleSister = 姨姥姥;
            外婆._son = 舅舅;
            外婆._daughter = 妈妈;

            舅舅._father = 外公;
            舅舅._mother = 外婆;
            舅舅._elderBrother = 舅舅;
            舅舅._elderSister = 姨妈;
            舅舅._littleBrother = 舅舅;
            舅舅._littleSister = 姨妈;
            舅舅._son = 表兄弟;
            舅舅._daughter = 表姐妹;

            姨妈._father = 外公;
            姨妈._mother = 外婆;
            姨妈._elderBrother = 舅舅;
            姨妈._elderSister = 姨妈;
            姨妈._littleBrother = 舅舅;
            姨妈._littleSister = 姨妈;
            姨妈._son = 表兄弟;
            姨妈._daughter = 表姐妹;

            侄子._father = 哥哥;
            侄子._mother = null;
            侄子._elderBrother = 侄子;
            侄子._elderSister = 侄女;
            侄子._littleBrother = 侄子;
            侄子._littleSister = 侄女;
            侄子._son = 侄孙;
            侄子._daughter = 侄孙女;

            侄女._father = 哥哥;
            侄女._mother = null;
            侄女._elderBrother = 侄子;
            侄女._elderSister = 侄女;
            侄女._littleBrother = 侄子;
            侄女._littleSister = 侄女;
            侄女._son = 外侄孙子;
            侄女._daughter = 外侄孙女;

            外甥._father = null;
            外甥._mother = 姐姐;
            外甥._elderBrother = 外甥;
            外甥._elderSister = 外甥女;
            外甥._littleBrother = 外甥;
            外甥._littleSister = 外甥女;
            外甥._son = 甥孙;
            外甥._daughter = 甥孙女;

            外甥女._father = null;
            外甥女._mother = 姐姐;
            外甥女._elderBrother = 外甥;
            外甥女._elderSister = 外甥女;
            外甥女._littleBrother = 外甥;
            外甥女._littleSister = 外甥女;
            外甥女._son = 甥外孙;
            外甥女._daughter = 甥外孙女;
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
        public string compressRelation(string code)
        {
            FamilyGraphNode p = 我;
            string res = "我";
            string temp_code;
            string temp_res = "";
           
            for (;code.Length>0 ;code=code.Substring(2,code.Length-2))
            {
                
                temp_code = code.Substring(0, 2);
                switch (temp_code)
                {
                    case "00": break;
                    case "01": temp_res = p.Name; p = p._father; break;
                    case "02": temp_res = p.Name; p = p._mother; break;
                    case "11": temp_res = p.Name; p = p._son; break;
                    case "12": temp_res = p.Name; p = p._daughter; break;
                    case "21": temp_res = p.Name; p = p._elderBrother; break;
                    case "22": temp_res = p.Name; p = p._elderSister; break;
                    case "31": temp_res = p.Name; p = p._littleBrother; break;
                    case "32": temp_res = p.Name; p = p._littleSister; break;
                }
                if (p == null)
                {
                    res = res + "的" + temp_res;
                    p = 我;
                    switch (temp_code)
                    {
                        case "00": break;
                        case "01": temp_res = p.Name; p = p._father; break;
                        case "02": temp_res = p.Name; p = p._mother; break;
                        case "11": temp_res = p.Name; p = p._son; break;
                        case "12": temp_res = p.Name; p = p._daughter; break;
                        case "21": temp_res = p.Name; p = p._elderBrother; break;
                        case "22": temp_res = p.Name; p = p._elderSister; break;
                        case "31": temp_res = p.Name; p = p._littleBrother; break;
                        case "32": temp_res = p.Name; p = p._littleSister; break;
                    }
                }
            }
            res = res + "的" + p.Name;
            res = res.Substring(2, res.Length-2);
            return res;
        }
        FamilyGraphNode first(FamilyGraphNode startPoi)
        {
            FamilyGraphNode p = null;
            if (startPoi._father != null)
            {
                p = startPoi._father;
            }
            else if (startPoi._mother != null)
            {
                p = startPoi._mother;
            }
            else if (startPoi._son != null)
            {
                p = startPoi._son;
            }
            else if (startPoi._daughter != null)
            {
                p = startPoi._daughter;
            }
            else if (startPoi._elderBrother != null)
            {
                p = startPoi._elderBrother;
            }
            else if (startPoi._elderSister != null)
            {
                p = startPoi._elderSister;
            }
            else if (startPoi._littleBrother != null)
            {
                p = startPoi._littleBrother;
            }
            else if (startPoi._littleSister != null)
            {
                p = startPoi._littleSister;
            }
            else if (startPoi._husband != null)
            {
                p = startPoi._husband;
            }
            else if (startPoi._wife != null)
            {
                p = startPoi._wife;
            }
            return p;
        }
        FamilyGraphNode next(FamilyGraphNode startPoi, FamilyGraphNode nextPoi)
        {
            if (nextPoi == null)
            {
                return null;
            }
            else if (startPoi._father == nextPoi)
            {
                if (startPoi._mother != null)
                {
                    nextPoi = startPoi._mother;
                }
                else if (startPoi._son != null)
                {
                    nextPoi = startPoi._son;
                }
                else if (startPoi._daughter != null)
                {
                    nextPoi = startPoi._daughter;
                }
                else if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._mother == nextPoi)
            {
                if (startPoi._son != null)
                {
                    nextPoi = startPoi._son;
                }
                else if (startPoi._daughter != null)
                {
                    nextPoi = startPoi._daughter;
                }
                else if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._son == nextPoi)
            {
                if (startPoi._daughter != null)
                {
                    nextPoi = startPoi._daughter;
                }
                else if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._daughter == nextPoi)
            {
                if (startPoi._elderBrother != null)
                {
                    nextPoi = startPoi._elderBrother;
                }
                else if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._elderBrother == nextPoi)
            {
                if (startPoi._elderSister != null)
                {
                    nextPoi = startPoi._elderSister;
                }
                else if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._elderSister == nextPoi)
            {
                if (startPoi._littleBrother != null)
                {
                    nextPoi = startPoi._littleBrother;
                }
                else if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._littleBrother == nextPoi)
            {
                if (startPoi._littleSister != null)
                {
                    nextPoi = startPoi._littleSister;
                }
                else if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._littleSister == nextPoi)
            {
                if (startPoi._husband != null)
                {
                    nextPoi = startPoi._husband;
                }
                else if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._husband == nextPoi)
            {
                if (startPoi._wife != null)
                {
                    nextPoi = startPoi._wife;
                }
                else
                {
                    nextPoi = null;
                }
            }
            else if (startPoi._wife == nextPoi)
            {
                nextPoi = null;
            }
            return nextPoi;
        }//目前亲戚编码只支持两层

        #region//深度遍历和广度遍历
        void DFS_withSetVisited(FamilyGraphNode startPoi, List<FamilyGraphNode> result)
        {
            if (getMark(startPoi) == false)
            {
                result.Add(startPoi);
                setMark(startPoi, true);
            }
            else
            {
                return;
            }
            for (FamilyGraphNode nextPoi = first(startPoi); nextPoi != null; nextPoi = next(startPoi, nextPoi))
            {
                DFS_withSetVisited(nextPoi, result);
            }
        }
        void DFS_withoutSetVisited(FamilyGraphNode startPoi, List<FamilyGraphNode> result)
        {
            DFS_withSetVisited(startPoi, result);
            cleanMark(startPoi);
        }
        void BFS_withSetVisited(FamilyGraphNode startPoi, List<FamilyGraphNode> result)
        {
            Queue<FamilyGraphNode> help_queue = new Queue<FamilyGraphNode>();
            if (getMark(startPoi) == false)
            {
                help_queue.Enqueue(startPoi);
                setMark(startPoi, true);
            }
            while (help_queue.Count() != 0)
            {
                FamilyGraphNode out_queue_item = help_queue.Dequeue();
                result.Add(out_queue_item);

                for (FamilyGraphNode nextPoi = first(out_queue_item); nextPoi != null; nextPoi = next(out_queue_item, nextPoi))
                {
                    if (getMark(nextPoi) == false)
                    {
                        help_queue.Enqueue(nextPoi);
                        setMark(nextPoi, true);
                    }
                }
            }
        }
        void BFS_withoutSetVisited(FamilyGraphNode startPoi, List<FamilyGraphNode> result)
        {
            BFS_withSetVisited(startPoi, result);
            cleanMark(startPoi);
        }
        #endregion
        #region//设置访问标记
        void cleanMark(FamilyGraphNode startPoi)//待改进，算法还会有重复访问
        {
            FamilyGraphNode p = startPoi;
            if (p._me != null)
            {
                p.IsVisited = false;
            }
            if (p._father != null)
            {
                cleanMark(p._father);
            }
            if (p._mother != null)
            {
                cleanMark(p._mother);
            }
            if (p._son != null)
            {
                cleanMark(p._son);
            }
            if (p._daughter != null)
            {
                cleanMark(p._daughter);
            }
            if (p._elderBrother != null)
            {
                cleanMark(p._elderBrother);
            }
            if (p._elderSister != null)
            {
                cleanMark(p._elderSister);
            }
            if (p._littleBrother != null)
            {
                cleanMark(p._littleBrother);
            }
            if (p._littleSister != null)
            {
                cleanMark(p._littleSister);
            }
            if (p._husband != null)
            {
                cleanMark(p._husband);
            }
            if (p._wife != null)
            {
                cleanMark(p._wife);
            }
        }
        void setMark(FamilyGraphNode p, bool mark)
        {
            p._me.IsVisited = mark;
        }
        bool getMark(FamilyGraphNode p)
        {
            return p._me.IsVisited;
        }
        #endregion

        #region//编码解码以及根据编码移动指针
        public static void decode(string encodeStr, ref string decodeResult,ref string finalResult)
        {
            String decode = "";//迭代关系
            String result = "";//最终称呼
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 0;)
            {
                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                switch (unit_0)
                {
                    case "00"://自己
                        {
                            decode = result = "自己";
                            break;
                        }
                    case "01"://父亲
                        {
                            decode += "父亲";
                            result = "父亲";
                            if (encodeStr.Length == 0)
                            {
                                break ;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "爷爷";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "奶奶";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "自己（男）、大哥、小弟";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "自己（女）、大姐、小妹";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "伯父";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "姑妈";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "叔叔";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姑";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "母亲";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "02"://母亲
                        {
                            decode += "母亲";
                            result = "母亲";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0;)
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "外公";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "外婆";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "自己（男）、大哥、小弟";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "自己（女）、大姐、小妹";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大舅";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "小舅";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "大姨";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姨";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "父亲";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "11"://儿子
                        {
                            decode += "儿子";
                            result = "儿子";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "自己（男）、丈夫";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "自己（女）、妻子";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "孙子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "孙女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "儿子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "女儿";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "儿子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "女儿";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "儿媳妇";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "12"://女儿
                        {
                            decode += "女儿";
                            result = "女儿";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "自己（男）、丈夫";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "自己（女）、妻子";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "孙子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "孙女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "儿子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "女儿";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "儿子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "女儿";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "女婿";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "21"://大哥
                        {
                            decode += "大哥";
                            result = "大哥";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "侄子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "侄女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大哥";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姐";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "自己（男）、大哥、小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "自己（女）、大姐、小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "嫂子";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "22"://大姐
                        {
                            decode += "大姐";
                            result = "大姐";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "外甥";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "外甥女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大哥";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姐";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "自己（男）、大哥、小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "自己（女）、大姐、小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "姐夫";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "31"://小弟
                        {
                            decode += "小弟";
                            result = "小弟";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "侄子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "侄女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "自己（男）、大哥、小弟";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "自己（女）、大姐、小妹";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "弟妹";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "32"://小妹
                        {
                            decode += "小妹";
                            result = "小妹";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "父亲";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "母亲";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "外甥";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "外甥女";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "自己（男）、大哥、小弟";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "自己（女）、大姐、小妹";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小弟";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小妹";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "妹夫";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "41"://丈夫
                        {
                            decode += "丈夫";
                            result = "丈夫";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "公公";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "婆婆";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "儿子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "女儿";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大伯子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姑子";

                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小叔子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姑子";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "自己（女）";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "42"://妻子
                        {
                            decode += "妻子";
                            result = "妻子";
                            if (encodeStr.Length == 0)
                            {
                                break;
                            }
                            for (string unit_1 = encodeStr.Substring(0, 2); encodeStr.Length > 0; )
                            {
                                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                                switch (unit_1)
                                {
                                    case "01":
                                        {
                                            decode += "的父亲";
                                            result = "岳父";
                                            break;
                                        }
                                    case "02":
                                        {
                                            decode += "的母亲";
                                            result = "岳母";
                                            break;
                                        }
                                    case "11":
                                        {
                                            decode += "的儿子";
                                            result = "儿子";
                                            break;
                                        }
                                    case "12":
                                        {
                                            decode += "的女儿";
                                            result = "女儿";
                                            break;
                                        }
                                    case "21":
                                        {
                                            decode += "的大哥";
                                            result = "大舅子";
                                            break;
                                        }
                                    case "22":
                                        {
                                            decode += "的大姐";
                                            result = "大姨子";
                                            break;
                                        }
                                    case "31":
                                        {
                                            decode += "的小弟";
                                            result = "小舅子";
                                            break;
                                        }
                                    case "32":
                                        {
                                            decode += "的小妹";
                                            result = "小姨子";
                                            break;
                                        }
                                    case "41":
                                        {
                                            decode += "的丈夫";
                                            result = "自己（男）";
                                            break;
                                        }
                                    case "42":
                                        {
                                            decode += "的妻子";
                                            result = "好像有什么不对";
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                }
            }
            decodeResult = decode;
            finalResult = result;
        }
        FamilyGraphNode setCurrToEncodeStrPos(string encodeStr)
        {
            FamilyGraphNode p = me_startPoi;
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 0;)
            {
                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                switch (unit_0)
                {
                    case "00"://自己
                        {
                            p = p._me;
                            break;
                        }
                    case "01"://父亲
                        {
                            p = p._father;
                            break;
                        }
                    case "02"://母亲
                        {
                            p = p._mother;
                            break;
                        }
                    case "11"://儿子
                        {
                            p = p._son;
                            break;
                        }
                    case "12"://女儿
                        {
                            p = p._daughter;
                            break;
                        }
                    case "21"://大哥
                        {
                            p = p._elderBrother;
                            break;
                        }
                    case "22"://大姐
                        {
                            p = p._elderSister;
                            break;
                        }
                    case "31"://小弟
                        {
                            p = p._littleBrother;
                            break;
                        }
                    case "32"://小妹
                        {
                            p = p._littleSister;
                            break;
                        }
                    case "41"://丈夫
                        {
                            p = p._husband;
                            break;
                        }
                    case "42"://妻子
                        {
                            p = p._husband;
                            break;
                        }
                }
                if (encodeStr.Length > 2)
                {
                    unit_0 = encodeStr.Substring(0, 2);
                }
            }
            return p;
        }
        FamilyGraphNode setCurrToEncodeStrPosGoingToAdd(string encodeStr)
        {
            FamilyGraphNode p = me_startPoi;
            for (string unit_0 = encodeStr.Substring(0, 2); encodeStr.Length > 2;)
            {
                encodeStr = encodeStr.Substring(2, encodeStr.Length - 2);
                switch (unit_0)
                {
                    case "00"://自己
                        {
                            p = p._me;
                            break;
                        }
                    case "01"://父亲
                        {
                            p = p._father;
                            break;
                        }
                    case "02"://母亲
                        {
                            p = p._mother;
                            break;
                        }
                    case "11"://儿子
                        {
                            p = p._son;
                            break;
                        }
                    case "12"://女儿
                        {
                            p = p._daughter;
                            break;
                        }
                    case "21"://大哥
                        {
                            p = p._elderBrother;
                            break;
                        }
                    case "22"://大姐
                        {
                            p = p._elderSister;
                            break;
                        }
                    case "31"://小弟
                        {
                            p = p._littleBrother;
                            break;
                        }
                    case "32"://小妹
                        {
                            p = p._littleSister;
                            break;
                        }
                    case "41"://丈夫
                        {
                            p = p._husband;
                            break;
                        }
                    case "42"://妻子
                        {
                            p = p._husband;
                            break;
                        }
                }
                if (encodeStr.Length > 2)
                {
                    unit_0 = encodeStr.Substring(0, 2);
                }
            }
            return p;
        }
        #endregion

        //增加
        private FamilyGraphNode creatPerson()
        {

            //输入Person信息
            string name = null;
            int age = -1;
            string gender = null;
            bool isDead = false;
            string encodeStr = null;

            FamilyGraphNode p = new FamilyGraphNode(name, age, gender, isDead, encodeStr);
            return p;
        }//输入模块
        public bool initMe()
        {
            me_startPoi = addPerson("00");
            return true;
        }
        public FamilyGraphNode addPerson(string encodeStr)
        {
            FamilyGraphNode p = creatPerson();
            curr = setCurrToEncodeStrPosGoingToAdd(encodeStr);
            string unit = encodeStr.Substring(0, 2);
            switch (unit)
            {
                case "00":
                    {
                        break;
                    }
                case "01":
                case "02":
                    {
                        FamilyGraphNode.setParentAndKid(p, curr);
                        break;
                    }
                case "11":
                case "12":
                    {
                        FamilyGraphNode.setParentAndKid(curr, p);
                        break;
                    }
                case "21":
                case "22":
                case "31":
                case "32":
                    {
                        FamilyGraphNode.setBrotherAndSister(curr, p);
                        break;
                    }
                case "41":
                case "42":
                    {
                        FamilyGraphNode.setHusbandAndWife(curr, p);
                        break;
                    }
            }
            memberCount++;
            return p;
        }
        //查找
        public bool queryPerson(HowToQuery howToQuery, string input, List<FamilyGraphNode> queryedPersons)
        {
            if (howToQuery == HowToQuery.ByNAME)
            {
                string name = input;
                List<FamilyGraphNode> BFSresult = new List<FamilyGraphNode>();
                BFS_withoutSetVisited(me_startPoi, BFSresult);
                foreach (var i in BFSresult)
                {
                    if (i.Name == input)
                    {
                        queryedPersons.Add(i);
                    }
                }
                return true;
            }
            else if (howToQuery == HowToQuery.ByENCODE)
            {
                string encodeStr = input;
                List<FamilyGraphNode> BFSresult = new List<FamilyGraphNode>();
                BFS_withoutSetVisited(me_startPoi, BFSresult);
                foreach (var i in BFSresult)
                {
                    if (i.EncodeStr == input)
                    {
                        queryedPersons.Add(i);
                    }
                }
                return true;
            }
            return false;
        }
        //private void showOnePersonMessage(Person p)
        //{
        //    Console.WriteLine(p.Name);
        //    Console.WriteLine(p.Gender);
        //    Console.WriteLine(p.Age);
        //    Console.WriteLine(p.birthday);
        //    if (p.IsDead == true)
        //    {
        //        Console.WriteLine(p.deathday);
        //    }
        //    //Console.WriteLine(p.IsDead);
        //    if (p.bornPlace != null)
        //    {
        //        Console.WriteLine(p.bornPlace);
        //    }
        //    if (p.eduBackground != null)
        //    {
        //        Console.WriteLine(p.eduBackground);
        //    }
        //    if (p.profession != null)
        //    {
        //        Console.WriteLine(p.profession);
        //    }
        //    if (p.highestProfessionRank != null)
        //    {
        //        Console.WriteLine(p.highestProfessionRank);
        //    }
        //    if (p.level != null)
        //    {
        //        Console.WriteLine(p.level);
        //    }
        //    if (p.EncodeStr != null)
        //    {
        //        Console.WriteLine(p.EncodeStr);
        //    }
        //    //Console.WriteLine(p.IsVisited);
        //}
        //private void showAllPersonMessage(List<Person> persons)
        //{
        //    foreach (var i in persons)
        //    {
        //        showOnePersonMessage(i);
        //    }
        //}
        //删除
        public bool delPerson(HowToDel howToDel, string input)
        {
            if (howToDel == HowToDel.ByNAME)
            {
                List<FamilyGraphNode> queryedPersons = new List<FamilyGraphNode>();
                queryPerson(HowToQuery.ByNAME, input, queryedPersons);
                foreach (var i in queryedPersons)
                {
                    FamilyGraphNode p = setCurrToEncodeStrPosGoingToAdd(i.EncodeStr);
                    FamilyGraphNode q = setCurrToEncodeStrPos(i.EncodeStr);
                    if (p == q && q == me_startPoi)
                    {
                        me_startPoi = null;
                    }
                    else
                    {
                        if (FamilyGraphNode.isHusbandAndWife(p, q))
                        {
                            FamilyGraphNode.unsetHusbandAndWife(p, q);
                        }
                        if (FamilyGraphNode.isParentAndKid(p, q))
                        {
                            FamilyGraphNode.unsetParentAndKid(p, q);
                        }
                        if (FamilyGraphNode.isBrotherAndSister(p, q))
                        {
                            FamilyGraphNode.unsetBrotherAndSister(p, q);
                        }
                    }
                }
                if (memberCount > 0)
                {
                    memberCount--;

                }
                return true;
            }
            else if (howToDel == HowToDel.ByENCODE)
            {
                List<FamilyGraphNode> queryedPersons = new List<FamilyGraphNode>();
                queryPerson(HowToQuery.ByNAME, input, queryedPersons);
                foreach (var i in queryedPersons)
                {
                    FamilyGraphNode p = setCurrToEncodeStrPosGoingToAdd(i.EncodeStr);
                    FamilyGraphNode q = setCurrToEncodeStrPos(i.EncodeStr);
                    if (p == q && q == me_startPoi)
                    {
                        me_startPoi = null;
                    }
                    else
                    {
                        if (FamilyGraphNode.isHusbandAndWife(p, q))
                        {
                            FamilyGraphNode.unsetHusbandAndWife(p, q);
                        }
                        if (FamilyGraphNode.isParentAndKid(p, q))
                        {
                            FamilyGraphNode.unsetParentAndKid(p, q);
                        }
                        if (FamilyGraphNode.isBrotherAndSister(p, q))
                        {
                            FamilyGraphNode.unsetBrotherAndSister(p, q);
                        }
                    }
                }
                if (memberCount > 0)
                {
                    memberCount--;

                }
                return true;
            }


            return false;
        }
    }
}
