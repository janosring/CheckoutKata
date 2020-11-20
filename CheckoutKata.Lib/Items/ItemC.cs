namespace CheckoutKata.Lib.Items
{
    public class ItemC : IItem
    {
        public int NumberOfItems { get; set; }
        public int CalculatePrice() => NumberOfItems * 40;
    }
}