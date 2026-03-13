using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal class Warrior : Character
    {
        public override decimal SetSpecialAttack()
        {
            Console.WriteLine("Warrior Special Attack: Sword Slash ");
            return AttackPower * 5;
        }
        public Warrior(String Name, decimal Health, decimal AttackPower, decimal Defense) 
            : base(Name, Health, AttackPower, Defense)
        {

        }
    }
}
