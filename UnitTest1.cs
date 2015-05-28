using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fractions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Fraction f1 = new Fraction(1, 3);
        Fraction f2 = new Fraction("1/3");
        Fraction f3 = new Fraction("2/3");
        Fraction f4 = new Fraction(1, 2);

        [TestMethod]

        public void TestMethod1()
        {
            Fraction f5 = f1 + f2;

            Assert.AreEqual("2/3",f5.ToString());

        }
        [TestMethod]

        public void TestMethod2()
        {
            Fraction f6 = f3 - f4;

            Assert.AreEqual("1/6", f6.ToString());

        }
        [TestMethod]

        public void TestMethod3()
        {
            Fraction f7 = f1 * f2;

            Assert.AreEqual("1/9", f7.ToString());

        }
        [TestMethod]

        public void TestMethod4()
        {
            Fraction f8 = f1/f2;

            Assert.AreEqual("1/1", f8.ToString());

        }
        [TestMethod]

        public void TestMethod5()
        {
            

            Assert.AreEqual(f1, f2);

        }
        [TestMethod]

        public void TestMethod6()
        {
            

            Assert.AreNotEqual(f1, f3);

        }
    }
}
