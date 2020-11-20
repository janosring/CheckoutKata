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
            _items.Add(item);
        }

        public int CalculatePrice()
        {
            return _items.Sum(item => item.CalculatePrice());
        }

        public ICollection<IItem> GetItems() => _items;
    }
}
