using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal class Archer:Character
    {
        public override void SetSpecialAttack()
        {
            Console.WriteLine("Archer Special Attack: Arrow Rain ");
            AttackPower *= 7;
        }
        public Archer(String Name, decimal Health, decimal AttackPower, decimal Defense)
          : base(Name, Health, AttackPower, Defense)
        {

        }
    }
}
