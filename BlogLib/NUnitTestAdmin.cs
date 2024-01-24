using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    [TestFixture]
     class NUnitTestAdmin
    {
        [TestCase]
        public void EmailId()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual("ravula@gmail.com","ravula@gmail.com");
        }

        [TestCase]
        public void Password()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual("ravula21", "ravula21");
        }
    }
}
