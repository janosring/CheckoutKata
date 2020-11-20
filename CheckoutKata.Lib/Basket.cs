using CheckoutKata.Lib.Items;
using System.Collections.Generic;
using System.Linq;

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
            var itemInTheBasket = _items.FirstOrDefault(x => x.GetType() == item.GetType());
            if (itemInTheBasket != null)
            {
                itemInTheBasket.NumberOfItems++;
                return;
            }

            item.NumberOfItems = 1;

            _items.Add(item);
        }

        public int CalculatePrice()
        {
            return _items.Sum(item => item.CalculatePrice());
        }

        public ICollection<Item> GetItems() => _items;
    }
}
