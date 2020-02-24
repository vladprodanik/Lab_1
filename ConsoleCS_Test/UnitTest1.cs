using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectCS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int res = ConsoleCS.Program.fv(a, b, c);
            Assert.AreEqual(6, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int res = ConsoleCS.Program.fs(a, b, c);
            Assert.AreEqual(22, res);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 4;
            int b = 8;
            int c = 19;
            int res = ConsoleCS.Program.fv(a, b, c);
            Assert.AreEqual(608, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 4;
            int b = 8;
            int c = 19;
            int res = ConsoleCS.Program.fs(a, b, c);
            Assert.AreEqual(520, res);
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 11;
            int b = 2;
            int c = 6;
            int res = ConsoleCS.Program.fv(a, b, c);
            Assert.AreEqual(132, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 11;
            int b = 2;
            int c = 6;
            int res = ConsoleCS.Program.fs(a, b, c);
            Assert.AreEqual(200, res);
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 26;
            int b = 74;
            int c = 113;
            int res = ConsoleCS.Program.fv(a, b, c);
            Assert.AreEqual(217412, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 26;
            int b = 74;
            int c = 113;
            int res = ConsoleCS.Program.fs(a, b, c);
            Assert.AreEqual(26448, res);
        }
    }
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 4;
            int b = 4;
            int c = 4;
            int res = ConsoleCS.Program.fv(a, b, c);
            Assert.AreEqual(64, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 4;
            int b = 4;
            int c = 4;
            int res = ConsoleCS.Program.fs(a, b, c);
            Assert.AreEqual(96, res);
        }
    }

}
