using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal abstract class Item
    {
        public decimal Power { get; protected set; }
        public abstract void Use(Character target);
        public Item()
        {
            Power = 0;
        }
        public Item(decimal Power)
        {
            this.Power = Power; 
        }
    }
}
