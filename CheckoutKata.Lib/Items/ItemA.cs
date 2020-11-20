namespace CheckoutKata.Lib.Items
{
    public class ItemA : IItem
    {
        public int NumberOfItems { get; set; }
        public int CalculatePrice() => NumberOfItems * 10;
    }
}