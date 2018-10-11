using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;
using NUnit.Framework;

namespace Lab3
{ 

    [TestFixture]
    public class StringTest
    {
        [Test]
        public void testConcatonate()
        {
            StringTesting source = new StringTesting();
            string result = source.concatonate("Hello", "World");
            Assert.AreEqual(result, "HelloWorld");
        }

        [Test]
        public void testComparison()
        {
            StringTesting source = new StringTesting();
            bool result2 = source.comparison("Hello", "Hello");
            Assert.AreEqual(result2, true);
        }

        [Test]
        public void testEmpty()
        {
            StringTesting source = new StringTesting();
            bool result3 = source.empty("notempty");
            Assert.AreEqual(result3, false);
        }

        [Test]
        public void testCopy()
        {
            StringTesting source = new StringTesting();
            string result4 = source.copystring("copied");
            Assert.AreEqual(result4, "copied");
        }


    }
    public class Class1
    {
    }
}
