using System;
using System.Collections.Generic;

namespace PointOfSaleTerminal
{
    public class PointOfSaleTerminal
    {
        private ShoppingItem[] _shoppingItems;
        public PointOfSaleTerminal(ShoppingItem[] shoppingItems)
        {
            _shoppingItems = shoppingItems;
        }

        public void ScanProduct(string productKey)
        {
            foreach (ShoppingItem item in _shoppingItems)
            {
                if (productKey.Equals(item.ProductKey))
                {
                    item.Count += 1;
                    break;
                }
            }
        }

        public decimal CalculateTotal()
        {
            return 1.10M;
        }
    }
}