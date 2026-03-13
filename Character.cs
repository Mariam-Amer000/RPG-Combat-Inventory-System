using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Combat___Inventory_System
{
    internal abstract class Character
    {
        public string Name { get; private set; } 
        public decimal Health { get; protected set; }
        public decimal AttackPower { get; protected set; }
        public decimal Defense { get; protected set; }
        // public Inventory SelfInventory;
       
        public void Heal(decimal Health)
        {
            this.Health += Health;
        }
        public void AddStrength(decimal AttackPower)
        {
            this.AttackPower += AttackPower;
        }
        public void AddDefense(decimal Defense)
        {
            this.Defense += Defense;
        }
        public void TakeDamage(decimal Health)
        {
            decimal damageAfterDefense = Health - Defense;
            if (damageAfterDefense < 0) damageAfterDefense = 0;
            this.Health -= damageAfterDefense;
        }

        //public void UseItem(int index)
        //{

        //}

        public abstract void SetSpecialAttack();


       public Character()
        {
            Name = "";
            Health = 0;
            AttackPower = 0;
            Defense = 0;
        }
       public Character(String Name,decimal Health,decimal AttackPower,decimal Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Defense = Defense;
        }
    }
}
