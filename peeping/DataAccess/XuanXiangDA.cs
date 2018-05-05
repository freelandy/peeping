using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using peeping.Helpers;
using peeping.Entity;

namespace peeping.DataAccess
{
    public class XuanXiangDA
    {
        private readonly AccessHelper dbHelper;

        public XuanXiangDA(string dbName, string dbPassword)
        {
            this.dbHelper = new AccessHelper(dbName, dbPassword);
        }

        public List<XuanXiang> GetList(int qid)
        {
            string sql = "select * from KGDAAN where SSSHITI=" + qid + " order by A_ID";

            OleDbDataReader dr = this.dbHelper.ExecuteReader(sql, null);
            List<XuanXiang> list = new List<XuanXiang>();
            int cnt = 0;
            while(dr.Read())
            {
                //暂时只有4个答案，避免出错，指定大小
                if (cnt>=4)
                {
                    break;
                }

                XuanXiang entity = new XuanXiang();
                entity.SSShiTi = int.Parse(dr["ssshiti"].ToString());
                entity.WBDaAn = Base64Helper.Base64Decode(Encoding.GetEncoding("GB2312"), dr["wbdaan"].ToString());
                entity.ZQDaAn = int.Parse(dr["zqdaan"].ToString());

                list.Add(entity);
                cnt++;
            }

            if(!dr.IsClosed)
            {
                dr.Close();
            }

            return list;
        }
    }
}
