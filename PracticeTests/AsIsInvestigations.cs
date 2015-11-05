using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class AsIsInvestigations
    {
        [TestMethod]
        public void NegativeIsOperatorTest()
        {
            object value = "Hi, I'm string!";

            // ---
            var valueIsDouble = value is Double;

            Assert.IsFalse(valueIsDouble);
        }

        [TestMethod]
        public void PositiveIsOperatorTest()
        {
            object value = "Hi, I'm string!";

            // ---
            var valueIsDouble = value is String;

            Assert.IsTrue(valueIsDouble);

            var valueAsString = (String)value;
            Assert.AreEqual(value, valueAsString);
        }

        [TestMethod]
        public void AsOperatorTest()
        {
            object value = 123d;

            // ---
            var valueAsString = value as String;

            Assert.IsNull(valueAsString);
        }

        [TestMethod]
        public void GetValueWithAsOperatorTest()
        {
            var expected = "Hello!";
            object value = expected;

            // ---
            var valueAsString = value as String;

            Assert.IsNotNull(valueAsString);
            Assert.AreEqual(expected, valueAsString);
        }

        [TestMethod]
        public void CoalesceOperatorTest()
        {
            var defaultValue = "Hi!";
            string valueFromInput = null;

            valueFromInput = valueFromInput ?? defaultValue;

            Assert.AreEqual(defaultValue, valueFromInput);
        }
    }
}
