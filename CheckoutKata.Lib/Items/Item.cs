namespace CheckoutKata.Lib.Items
{
    public interface IItem
    {
        public int NumberOfItems { get; set; }
        public int CalculatePrice();
    }
}