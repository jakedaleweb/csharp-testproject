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
            if (productKey.Equals("") || price < 0.0M)
            {
                throw new System.ArgumentException("productKey and price cannot be empty");
            }

            ProductKey = productKey;
            StandardPrice = price;
            BulkPrice = bulkPrice;
            BulkQuantity = bulkQuantity;
        }

        public decimal CalculateCost()
        {
            if (BulkQuantity.Equals(0) || Count < BulkQuantity)
            {
                return Count * StandardPrice;
            }

            // The number of time the bulk quantity has been achieved
            decimal bulkQualifiers = Math.Round((decimal)Count / (decimal)BulkQuantity);
            // The number of items that don't qualify for bulk discount
            decimal standardQualifiers = Count - ((decimal)bulkQualifiers * (decimal)BulkQuantity);

            decimal standardCost = standardQualifiers * StandardPrice;
            decimal bulkCost = bulkQualifiers * BulkPrice;

            return standardCost + standardCost;
        }
    }
}