namespace CheckoutKata.Lib.Items
{
    public class ItemC : Item
    {
        public override double CalculatePrice() => NumberOfItems * 40;
    }
}