using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal class Inventory
    {
        private List<Item> _items;
        public Inventory()
        {
            _items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
            Console.WriteLine($"{item.GetType().Name} added to inventory.");
        }
        public Item GetItem(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                return _items[index];
            }
            Console.WriteLine("invalid index");
            return null;
        }
        public void RemoveItem(int index)
        {
            _items.RemoveAt(index);
        }
        public void DisplayItems()
        {
            Console.WriteLine("\n--- Current Inventory ---");
            if (_items.Count == 0) Console.WriteLine("Empty");

            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i}. {_items[i].GetType().Name}");
            }
        }
    }
}
