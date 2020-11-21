namespace CheckoutKata.Lib.Items
{
    public abstract class Item
    {
        public int NumberOfItems { get; set; }
        public abstract double CalculatePrice();
    }
}