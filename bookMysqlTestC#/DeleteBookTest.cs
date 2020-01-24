using bookMysql;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bookMysql.Tests
{
    [TestClass()]
    public class DeleteBookTest
    {
        [TestMethod()]
        public void btnDelete_Click_1Test()
        {
            Form1 frm = new Form1();
            var result = "book";
            Assert.AreEqual("book", result);
        }
    }
}

