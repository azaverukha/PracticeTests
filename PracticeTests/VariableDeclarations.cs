using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class VariableDeclarations
    {
        [TestMethod]
        public void DoubleDeclarationTests()
        {
            double typeD;

            var varedD = 0.1d;

            var structed = new Double();
        }

        [TestMethod]
        public void IntDeclarationTests()
        {
            var integer1 = new int();

            var integer2 = new Int32();
        }

        [TestMethod]
        public void ChainedDeclaration()
        {
            {
                int a, b, c;
            }
            {
                char a = 'a', b= 'b', c= 'c';
            }
        }
    }
}
