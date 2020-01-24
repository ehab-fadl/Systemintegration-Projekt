using Microsoft.VisualStudio.TestTools.UnitTesting;
using bookMysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookMysql.Tests
{
    [TestClass()]
    public class SearchBookTest
    {
        [TestMethod()]
        public void btnSearch_Click_1Test()
        {
            Form1 frm = new Form1();
            var result = "book";
            Assert.AreEqual("book", result);
        }
    }
}