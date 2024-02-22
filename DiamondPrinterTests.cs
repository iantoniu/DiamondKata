using DiamondKata;
using System.Diagnostics;

namespace DiamondKataTests
{
    [TestClass]
    public class DiamondPrinterTests
    {
        [TestMethod]
        public void TestPrintDiamondWithA()
        {
            string result = DiamondPrinter.PrintDiamond('A');
            Assert.AreEqual("A\r\n", result);
        }

        [TestMethod]
        public void TestPrintDiamondWithB()
        {
            string result = DiamondPrinter.PrintDiamond('B');
            Debug.WriteLine(result);
            Assert.AreEqual("_A_\r\nB_B\r\n_A_\r\n", result);
        }

        [TestMethod]
        public void TestPrintDiamondWithC()
        {
            string result = DiamondPrinter.PrintDiamond('C');
            Debug.WriteLine(result);
            Assert.AreEqual("__A__\r\n_B_B_\r\nC___C\r\n_B_B_\r\n__A__\r\n", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPrintDiamondWithInvalidInputNotLetter()
        {
            DiamondPrinter.PrintDiamond('1');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPrintDiamondWithInvalidInputLowerCase()
        {
            DiamondPrinter.PrintDiamond('a');
        }
    }
}