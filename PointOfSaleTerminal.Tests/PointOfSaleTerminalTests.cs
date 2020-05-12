using NUnit.Framework;
using PointOfSaleTerminal;

namespace PointOfSaleTerminal.UnitTests.Services
{
    [TestFixture]
    public class PointOfSaleTerminal_IsPrimeShould
    {
        private PointOfSaleTerminal _terminal;

        [SetUp]
        public void SetUp()
        {
            ShoppingItem a = new ShoppingItem("A", 1.25M, 3.00M, 3);
            ShoppingItem b = new ShoppingItem("B", 4.25M);
            ShoppingItem c = new ShoppingItem("C", 1.00M, 5.00M, 6);
            ShoppingItem d = new ShoppingItem("D", 0.75M);
            _terminal = new PointOfSaleTerminal(new ShoppingItem[] { a, b, c, d });
        }

        [TestCase("ABCDABA", 13.25)]
        [TestCase("CCCCCCC", 6.0)]
        [TestCase("ABCD", 7.25)]
        public void Terminal_Scan_Should_Return_Total(string scan_items, decimal expected_total)
        {
            foreach (char ch in scan_items)
            {
                _terminal.ScanProduct(ch.ToString());
            }

            Assert.AreEqual(expected_total, _terminal.CalculateTotal());
        }
    }
}