using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public override string ToString()
        {
            return String.Format("R:{0} G:{1} B:{2}", R, G, B);
        }
    }

    [TestClass]
    public class Structures
    {
        [TestMethod]
        public void TestToStringMethod()
        {
            var color = new Color
            {
                R = 1,
                G = 2,
                B = 3
            };

            Debug.WriteLine(color.ToString());
        }
    }
}
