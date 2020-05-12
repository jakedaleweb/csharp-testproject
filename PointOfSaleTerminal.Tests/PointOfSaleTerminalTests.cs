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
            _terminal = new PointOfSaleTerminal();
        }
    }
}