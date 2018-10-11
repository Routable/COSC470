using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3P2;
using NUnit.Framework;

namespace Lab3P2
{
    [TestFixture]
    public class Testing
    {
        [Test]
        public void testLogin()
        {
            Program source = new Program();
            string result = source.Login("Admin", "Admin");
            Assert.AreEqual(result, "Welcome User/Admin");
        }

        [Test]
        public void testListFirst()
        {
            Program source = new Program();
            List<StudentDetails> result = source.AllUsers();
            StudentDetails result2 = result.First();
            Assert.AreEqual("steven", result2.getName());
        }

        [Test]
        public void testLoop()
        {
            Program source = new Program();
            List<StudentDetails> result = source.AllUsers();

            foreach (var x in result)
            {
                Assert.AreEqual(x.getId(), 300168440);
            }
        }

        [Test]
        public void testListNull()
        {
            Program source = new Program();
            List<StudentDetails> result = source.AllUsers();

            foreach (var x in result)
            {
                Assert.IsNotNull(x.getName());
            }
        }
    

    }
}
