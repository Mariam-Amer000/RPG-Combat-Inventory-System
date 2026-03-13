using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal class Mage : Character
    {
        public override decimal SetSpecialAttack()
        {
            Console.WriteLine("Mage Special Attack: Fireball ");
            return AttackPower * 3;
        }
        public Mage(String Name, decimal Health, decimal AttackPower, decimal Defense)
           : base(Name, Health, AttackPower, Defense)
        {

        }
    }
}
