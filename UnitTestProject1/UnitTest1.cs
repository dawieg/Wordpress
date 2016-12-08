using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAuto;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Class1();
            c.go();
        }
    }
}
