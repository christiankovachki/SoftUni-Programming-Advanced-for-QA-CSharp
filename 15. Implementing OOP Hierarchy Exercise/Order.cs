using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> _items = new List<MenuItem>();
        public IReadOnlyCollection<MenuItem> Items => _items.AsReadOnly();

        public void AddItem(MenuItem item)
        { 
            _items.Add(item);
        }

        public decimal GetTotal()
        { 
            decimal totalPrice = 0m;

            foreach (MenuItem item in _items)
            {
                totalPrice += item.Price;
            }

            return totalPrice;
        }
    }
}