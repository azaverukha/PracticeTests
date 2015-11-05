using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class NullableTests
    {
        [TestMethod]
        public void NullableIntPlayground()
        {
            int? nullable = default(int?);

            Assert.IsFalse(nullable.HasValue);
            Assert.AreEqual(null, nullable);
            // Assert.IsNull(nullable);

            nullable = 1;
            Assert.IsTrue(nullable.HasValue);
            Assert.AreEqual(1, nullable);

            nullable += 2;
            Assert.AreEqual(3, nullable);
        }

        [TestMethod]
        public void NullableNotBoom()
        {
            int? nullable = default(int?);
            Assert.AreEqual(null, nullable);

            nullable = null + 2;
            Assert.AreEqual(null, nullable);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NullableOfT()
        {
            var a = default(Nullable<decimal>);
            var b = default(Nullable<decimal>);

            decimal c = a.Value + b.Value;

            Assert.Fail();
        }

        [TestMethod]
        public void Method()
        {
            var path = "\tC:\\Projects";

            Debug.WriteLine(path);

            var anotherPath = @"C:\Projects";

            Debug.WriteLine(path);
        }
    }
}
