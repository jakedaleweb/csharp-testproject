using System;
using System.Collections.Generic;

namespace PointOfSaleTerminal
{
    public class ShoppingItem
    {
        public string ProductKey;
        public int Count = 0;
        private decimal _standardPrice;
        private decimal _bulkPrice;
        private int _bulkQuantity;

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
            _standardPrice = price;
            _bulkPrice = bulkPrice;
            _bulkQuantity = bulkQuantity;
        }

        public decimal CalculateCost()
        {
            if (_bulkQuantity.Equals(0) || Count < _bulkQuantity)
            {
                return Count * _standardPrice;
            }

            // The number of times the bulk quantity has been achieved
            decimal bulkQualifiers = Math.Round((decimal)Count / (decimal)_bulkQuantity);
            // The number of items that don't qualify for bulk discount
            decimal standardQualifiers = Count - ((decimal)bulkQualifiers * (decimal)_bulkQuantity);

            decimal standardCost = standardQualifiers * _standardPrice;
            decimal bulkCost = bulkQualifiers * _bulkPrice;

            return bulkCost + standardCost;
        }
    }
}