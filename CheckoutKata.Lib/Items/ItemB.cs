﻿namespace CheckoutKata.Lib.Items
{
    public class ItemB : Item
    {
        public override double CalculatePrice()
        {
            var numberOfDiscounts = NumberOfItems / 3;
            var normalPriceItems = NumberOfItems % 3;

            return numberOfDiscounts * 40 + normalPriceItems * 15;
        }
    }
}