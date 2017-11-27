using System.Collections.Generic;

namespace ShoppingCartKata
{
    public class ShoppingCart
    {
        private int _total;

        private readonly Dictionary<string, int> _items;

        public ShoppingCart(Dictionary<string, int> items)
        {
            _items = items;
        }

        public void Scan(string item)
        {
            if (_items.ContainsKey(item))
                _total += _items[item];
        }

        public int Total()
        {
            return _total;
        }
    }
}
