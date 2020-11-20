namespace CheckoutKata.Lib.Items
{
    public class ItemA : Item
    {
        public override int CalculatePrice() => NumberOfItems * 10;
    }
}