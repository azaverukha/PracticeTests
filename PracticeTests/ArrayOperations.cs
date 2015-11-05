using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class ArrayOperations
    {
        [TestMethod]
        public void FindLastIndexOfItem()
        {
            // arrange
            var items = new[] {1, 2, 3, 4, 5};
            
            const int itemIndex = 2;
            var itemToSearchFor = items[itemIndex];
            items[0] = items[itemIndex];

            // act
            var lastIndex = items.Length - 1;

            for (; lastIndex >= 0; lastIndex--)
            {
                if (items[lastIndex] == itemToSearchFor)
                    break;
            }

            var firstIndex = Array.IndexOf(items, itemToSearchFor);

            // assert
            Assert.AreEqual(itemIndex, lastIndex);
            Assert.AreEqual(0, firstIndex);
        }

        [TestMethod]
        public void SortItems()
        {
            // arrange
            var items = new[] { 3, 2, 1 };
            
            // act
            Array.Sort(items);

            // assert
            Assert.AreEqual(1, items[0]);
            Assert.AreEqual(2, items[1]);
            Assert.AreEqual(3, items[2]);
        }

        [TestMethod]
        public void ArrayClone()
        {
            // arrange
            var original = new[] { 3, 2, 1 };
            var copy = new int[original.Length];

            // act
            Array.Copy(original, copy, original.Length);

            // assert
            Assert.AreEqual(original[0], copy[0]);
            Assert.AreEqual(original[1], copy[1]);
            Assert.AreEqual(original[2], copy[2]);
        }
    }
}
