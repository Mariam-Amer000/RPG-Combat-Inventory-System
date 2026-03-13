using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal class Weapon : Item
    {
        public override void Use(Character target)
        {
            target.AddStrength(Power);
        }
        public Weapon(decimal Power) : base(Power) { }
    }
}
