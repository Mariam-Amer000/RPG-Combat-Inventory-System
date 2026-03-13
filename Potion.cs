using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal class Potion : Item
    {
        public override void Use(Character target)
        {
            target.Heal(Power);
        }
        public Potion(decimal Power) : base(Power) { }
    }
}
