using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPE_ABAS_Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ABAS_Hotels.Tests
{
    [TestClass()]
    public class GlobalsTests
    {
        [TestMethod()]
        public void LeadingZeroZeroTest()
        {
            var result = Globals.LeadingZero(0);
            Assert.AreEqual("00", result);
        }

        [TestMethod()]
        public void LeadingZeroOneTest()
        {
            var result = Globals.LeadingZero(1);
            Assert.AreEqual("01", result);
        }

        [TestMethod()]
        public void LeadingZero15Test()
        {
            var result = Globals.LeadingZero(15);
            Assert.AreEqual("15", result);
        }

        [TestMethod()]
        public void sendMailToNewClientTest()
        {
            var result = Globals.sendMailToNewClient("romain.valeye@gmail.com");
            Assert.IsTrue(result);
        }
    }
}