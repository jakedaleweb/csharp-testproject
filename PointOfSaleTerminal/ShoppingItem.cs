using System;
using System.Collections.Generic;

namespace PointOfSaleTerminal
{
    public class ShoppingItem
    {
        public string ProductKey;
        public decimal StandardPrice;
        public decimal BulkPrice;
        public int BulkQuantity;
        public int Count = 0;

        public ShoppingItem(
            string productKey,
            decimal price,
            decimal bulkPrice = 0,
            int bulkQuantity = 0
        )
        {
            if (productKey == "" || price < 0.0M)
            {
                throw new System.ArgumentException("productKey and price cannot be empty");
            }

            ProductKey = productKey;
            StandardPrice = price;
            BulkPrice = bulkPrice;
            BulkQuantity = bulkQuantity;
        }
    }
}