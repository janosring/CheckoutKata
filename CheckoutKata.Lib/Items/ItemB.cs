namespace CheckoutKata.Lib.Items
{
    public class ItemB : IItem
    {
        public int NumberOfItems { get; set; }

        public int CalculatePrice()
        {
            var numberOfDiscounts = NumberOfItems / 3;
            var normalPriceItems = NumberOfItems % 3;

            return numberOfDiscounts * 40 + normalPriceItems * 15;
        }
    }
}