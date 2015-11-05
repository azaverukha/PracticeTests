using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    public enum Result
    {
        Success = 0,
        Fail
    }

    [TestClass]
    public class Enumerations
    {
        [TestMethod]
        public void DefaultValueTest()
        {
            var result = default(Result);

            Debug.WriteLine(result);
        }

        [TestMethod]
        public void EqualityTest()
        {
            var result = Result.Fail;

            Assert.AreNotEqual(Result.Success, result);
        }

        [TestMethod]
        public void TypeEqualityTest()
        {
            var result = Result.Fail;

            Assert.AreSame(typeof(Result), result.GetType());
        }

        [TestMethod]
        public void ParseFromStringWorksForSuccessValue()
        {
            var expected = Result.Success;
            var stringResult = expected.ToString();

            Result parsed;
            var result = Enum.TryParse(stringResult, out parsed);

            Assert.IsTrue(result);
            Assert.AreEqual(expected, parsed);
        }
    }
}
