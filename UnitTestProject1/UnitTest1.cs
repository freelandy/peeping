using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            peeping.DataAccess.TiKuDA da = new peeping.DataAccess.TiKuDA("wwjt1.mdb", "wwjt_wy_sg");
            peeping.DataAccess.XuanXiangDA xuanxiangDA = new peeping.DataAccess.XuanXiangDA("wwjt1.mdb", "wwjt_wy_sg");

            List<peeping.Entity.TiKu> list = da.GetList("");

            foreach(peeping.Entity.TiKu item in list)
            {
                Console.WriteLine(item.TGWenBen);
            }
        }
    }
}
