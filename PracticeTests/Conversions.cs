using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class Conversions
    {
        [TestMethod]
        public void AutomaticExpressionConvertions()
        {
            long longArg = 1;
            short shortArg = 1;
            int intArg = 1;

            var result = shortArg + intArg + longArg;

            Assert.AreSame(longArg.GetType(), 
                           result.GetType());
        }

        [TestMethod]
        public void ManualExpressionConvertions()
        {
            long longArg = 1;
            short shortArg = 1;
            int intArg = 1;

            var result = shortArg 
                + intArg
                + (short)longArg;

            Assert.AreSame(intArg.GetType(), 
                           result.GetType());
        }

        [TestMethod]
        public void IncompatibleExpressionConvertions()
        {
            int x = 1;
            int y = 2;

            var result = (x*1d / y);

            Assert.AreEqual(0.5, result);
        }
    }
}
