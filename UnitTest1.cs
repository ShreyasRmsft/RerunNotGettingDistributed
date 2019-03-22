using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RerunNotGettingDistributed
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod5()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod6()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod7()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod8()
        {
            Thread.Sleep(20000);
            Assert.Fail();
        }
    }
}
