using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal class Shield : Item
    {
        public override void Use(Character target)
        {
            target.AddDefense(Power);
        }
        public Shield(decimal Power) : base(Power) { }
    }
}
