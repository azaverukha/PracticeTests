using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class ConvertTest
    {
        [TestMethod]
        public void ConvertToInt32()
        {
            var culture = CultureInfo.CurrentCulture;
            var stringular = 123.3m.ToString(culture);
            
            var value = Convert.ToDecimal(stringular, culture);

            Assert.AreEqual(123.3m, value);
        }
    }
}
