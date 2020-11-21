namespace CheckoutKata.Lib.Items
{
    public abstract class Item
    {
        protected Item()
        {
            NumberOfItems = 1;
        }

        public int NumberOfItems { get; set; }
        public abstract double CalculatePrice();
    }
}