using CheckoutKata.Lib.Items;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata.Lib
{
    public class Basket
    {
        private readonly ICollection<IItem> _items;

        public Basket()
        {
            _items = new List<IItem>();
        }

        public void AddItem(IItem item)
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

        public ICollection<IItem> GetItems() => _items;
    }
}
