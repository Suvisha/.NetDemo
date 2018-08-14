using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitSample;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition_Twonum_returnSuccess()
        {
            UnitClass c = new UnitClass();
            Assert.AreEqual(11, c.Add(4, 7), "Addition Fail");                                                                                                                               
        }
        [TestMethod]
        public void Substraction_Twonum_returnSucess()
        {
            UnitClass c = new UnitClass();
            Assert.AreEqual(7, c.Sub(10, 5), " Substraction Fail");
        }
        [TestMethod]
        public void Division_Twonum_returnSucess()
        {
            UnitClass c = new UnitClass();
            Assert.AreEqual(3, c.Div(9, 3), "Division Fail");
        }
    }
}
