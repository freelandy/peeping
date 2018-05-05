using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using peeping.Entity;
using peeping.Helpers;

namespace peeping.DataAccess
{
    public class TiKuDA
    {
        private readonly AccessHelper dbHelper;
        private readonly XuanXiangDA xuangxiangDA;

        public TiKuDA(string dbName,string dbPassword)
        {
            this.dbHelper = new AccessHelper(dbName, dbPassword);
            this.xuangxiangDA = new XuanXiangDA(dbName, dbPassword);
        }

        public List<TiKu> GetList(string condition)
        {
            string sql = "select Q_ID,TMDAIMA,ZHANGMINGCHENG,JIEMINGCHENG,ZHISHIDIANMINGCHENG,TXMINGCHENG,TGWENBEN,PDDAAN ";
            //sql += "max(case )"
            sql += "from KGTIKU,ZHANG,JIE,ZHISHIDIAN,TIXING ";
            sql += "where KGTIKU.ZHANG=ZHANG.ZHANG_ID and KGTIKU.JIE=JIE.JIE_ID and KGTIKU.ZSDIAN=ZHISHIDIAN.ZHISHIDIAN_ID and KGTIKU.TIXING=TIXING.TIXING_ID ";
            sql += "order by Q_ID";

            if(condition.Trim() != "")
            {
                sql += " and " + condition;
            }

            List<TiKu> list = new List<TiKu>();

            OleDbDataReader dr = this.dbHelper.ExecuteReader(sql, null);
            while(dr.Read())
            {
                TiKu entity = new TiKu();
                entity.JieMingCheng = dr["jiemingcheng"].ToString();
                entity.PDDaAn = int.Parse(dr["pddaan"].ToString());
                entity.QID = int.Parse(dr["q_id"].ToString());
                entity.TGWenBen = Base64Helper.Base64Decode(Encoding.GetEncoding("GB2312"),dr["tgwenben"].ToString());
                entity.TiXingMingCheng = dr["txmingcheng"].ToString();
                entity.TMDaima = dr["tmdaima"].ToString();
                entity.ZhangMingCheng = dr["zhangmingcheng"].ToString();
                entity.ZhiShiDianMingCheng = dr["zhishidianmingcheng"].ToString();

                // 搞到选项，以及正确答案
                string rightAnswer = "";
                if (entity.TiXingMingCheng == "单项选择题" || entity.TiXingMingCheng == "多项选择题")
                {
                    List<XuanXiang> xuanxiang = this.xuangxiangDA.GetList(entity.QID);
                    // 暂时只有4个选项
                    try
                    {
                        entity.A = xuanxiang[0].WBDaAn;
                        if (xuanxiang[0].ZQDaAn == 1)
                        {
                            rightAnswer += "A";
                        }

                        entity.B = xuanxiang[1].WBDaAn;
                        if (xuanxiang[1].ZQDaAn == 1)
                        {
                            rightAnswer += "B";
                        }

                        entity.C = xuanxiang[2].WBDaAn;
                        if (xuanxiang[2].ZQDaAn == 1)
                        {
                            rightAnswer += "C";
                        }

                        entity.D = xuanxiang[3].WBDaAn;
                        if (xuanxiang[3].ZQDaAn == 1)
                        {
                            rightAnswer += "D";
                        }
                    }
                    catch
                    {
                        
                    }
                }

                // 搞到判断题正确答案
                if(entity.TiXingMingCheng == "判断题")
                {
                    if (entity.PDDaAn == 1)
                    {
                        rightAnswer = "正确";
                    }
                    else
                    {
                        rightAnswer = "错误";
                    }
                }

                entity.DaAn = rightAnswer;
                
                list.Add(entity);
            }

            if(!dr.IsClosed)
            {
                dr.Close();
            }

            return list;
        }
    }
}
