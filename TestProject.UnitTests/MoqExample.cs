using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using testproject;

namespace TestProject.UnitTests
{
    [TestClass]
    public class MoqExample
    {

        [TestMethod]
        public void TestMethod1()
        {
            var m1 = new Mock<IGreetings>();
            m1.SetupAllProperties();
            m1.Setup(p => p.from).Returns("SS");
            m1.SetupSequence(p => p.to)
                .Returns("GK")
                .Returns("K");
            m1.Setup(p => p.msg).Returns("Happy Independence Day");
            m1.Setup(p => p.msgType).Returns("SMS");
            Action act = () =>
            {
                var ig = new ActualGreetings(m1.Object);
                Assert.AreEqual("SS", ig.data1());
                Assert.AreEqual("GK", ig.data2());
                Assert.AreEqual("K", ig.data2());
                Assert.AreEqual("Happy Independence Day", ig.data3());
                Assert.AreEqual("SMS", ig.data4());
            };
            act.Invoke();
        }
    }
}
