using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class ArrayInvestigations
    {
        [TestMethod]
        public void SingleDimensionalArray()
        {
            var items = new[] {1, 2, 3};

            Assert.AreEqual(3, items.Length);
            Assert.AreEqual(1, items.Rank);
            Assert.AreEqual(3, items.GetLength(0));
        }

        [TestMethod]
        public void ThreeDimensionalArray()
        {
            var items = new int[3, 2]
            {
                {1, 2},
                {2, 3},
                {1, 1}
            };

            Assert.AreEqual(6, items.Length);
            Assert.AreEqual(2, items.Rank);

            Assert.AreEqual(3, items.GetLength(0));
            Assert.AreEqual(2, items.GetLength(1));
        }

        [TestMethod]
        public void JaggedArray()
        {
            var items = new []
            {
                new[] {1, 2, 3},
                new[] {1}
            };

            Assert.AreEqual(3, items[0][2]);

            Assert.AreEqual(2, items.Length);
            Assert.AreEqual(1, items.Rank);
            Assert.AreEqual(2, items.GetLength(0));
        }
    }
}