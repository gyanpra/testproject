using Microsoft.VisualStudio.TestTools.UnitTesting;
using testproject;
using System;

namespace TestProject.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void ZeroAmount()
        {
            Discount obj = new Discount();
            try
            {
                obj.calculateDiscount(0);
            }
            catch (Exception e) { }
        }
        [TestMethod]
        public void TwoThousand()
        {
            Discount obj = new Discount();
            Assert.AreNotEqual(1900, obj.calculateDiscount(2000));
        }

        [TestMethod]
        public void OneThousand_G_Example()
        {
            Discount obj = new Discount();
            Assert.AreEqual(950, obj.calculateDiscount(1000));

        }
    }
}
