namespace CheckoutKata.Lib.Items
{
    public class ItemC : Item
    {
        public override int CalculatePrice() => NumberOfItems * 40;
    }
}