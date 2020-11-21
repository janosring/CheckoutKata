namespace CheckoutKata.Lib.Items
{
    public class ItemA : Item
    {
        public override double CalculatePrice() => NumberOfItems * 10;
    }
}