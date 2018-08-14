using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MockExample;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<User> M = new Mock<User>();
            M.Setup(x=>x.UserId()).Returns(10);
            Class1 cl = new Class1();
            Assert.AreEqual(10,cl.print(M.Object), "success");
            //Mock<User> M = new Mock<User>();
            //// M.Setup(x=>x.UserId()).Returns(10);
            // Class1 cl = new Class1();
            // int a=cl.print();
            // Assert.AreEqual(5,a, a.ToString()+"success");
        }
    }
}
