using CheckoutKata.Lib.Items;
using System.Collections.Generic;

namespace CheckoutKata.Lib
{
    public class Basket
    {
        private readonly ICollection<Item> _items;

        public Basket()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public int CalculatePrice()
        {
            return 0;
        }

        public ICollection<Item> GetItems() => _items;
    }
}
