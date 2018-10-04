using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringOperators s = new StringOperators();
            string x = s.concatonate("Hello", "World");
            string y = "Hello World";
            Assert.AreEqual(x, y);
        }

        [TestMethod]
        public void TestMethod2()
        {
            StringOperators s = new StringOperators();
            bool x = s.comparison("Hello", "Helldo");
            bool y = true;
            Assert.AreEqual(x, y);
        }

        [TestMethod]
        public void TestMethod3()
        {
            StringOperators s = new StringOperators();
            string x = s.copystring("Hello");
            string y = "Hello";
            Assert.AreEqual(x, y);
        }

        [TestMethod]
        public void TestMethod4()
        {
            StringOperators s = new StringOperators();
            bool x = s.empty("");
            bool y = true;
            Assert.AreEqual(x, y);
        }
    }
}
