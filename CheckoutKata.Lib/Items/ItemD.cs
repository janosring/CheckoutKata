namespace CheckoutKata.Lib.Items
{
    public class ItemD : IItem
    {
        public int NumberOfItems { get; set; }
        public int CalculatePrice() => 55;
    }
}