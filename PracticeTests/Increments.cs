using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class Increments
    {
        [TestMethod]
        public void DoubleIncrement()
        {
            var i = 0;

            i++;
            ++i;

            Assert.AreEqual(2, i);
        }

        [TestMethod]
        public void ComplexDoubleIncrement()
        {
            int i = 0, j = 0;

            var suffixed = i++;
            var prefixed = ++j;

            Assert.AreEqual(0, suffixed);
            Assert.AreEqual(1, prefixed);
        }

        [TestMethod]
        public void NeverDoThatIncrement()
        {
            int a = 0;

            a++;
            a += ++a;

            Assert.AreEqual(3, a);
        }
    }
}
