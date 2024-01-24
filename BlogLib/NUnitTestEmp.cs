using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    [TestFixture]
    class NUnitTestEmp
    {
        [TestCase]
        public void EmailId()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual("sonali@gmail.com", "sonali@gmail.com");
        }

        [TestCase]
        public void PassCode()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual(12345,12345);
        }
    }
}


