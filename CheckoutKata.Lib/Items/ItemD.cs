namespace CheckoutKata.Lib.Items
{
    public class ItemD : Item
    {
        public override double CalculatePrice()
        {
            var numberOfDiscounts = NumberOfItems / 2;
            var normalPriceItems = NumberOfItems % 2;

            return numberOfDiscounts * (110 * 0.75) + normalPriceItems * 55;
        }
    }
}