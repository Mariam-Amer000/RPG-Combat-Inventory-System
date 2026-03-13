using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RPG_Combat___Inventory_System
{
    internal class Battle
    {
        private Character _CharacterOne;
        private Character _CharacterTwo;
        public bool CharacterOneTurn;
        public bool CharacterTwoTurn;
        private int _CountoUseSpecialAttack;
        public Battle(Character CharacterOne, Character CharacterTwo, int Start, int usingSpecialAttack)
        {
            this._CharacterOne = CharacterOne;
            this._CharacterTwo = CharacterTwo;
            if (Start == 1)
            {
                CharacterOneTurn = true;
                CharacterTwoTurn = false;
            }
            else if(Start == 2)
            {
                CharacterOneTurn = false;
                CharacterTwoTurn = true;
            }
            else
            {
                throw new Exception("Invalid Start number");
            }

            _CountoUseSpecialAttack =usingSpecialAttack;
        }
        public void Start()
        {

            while (_CharacterOne.Health > 0 && _CharacterTwo.Health > 0)
            {
                if (CharacterOneTurn)
                {
                    decimal Attack = ApplyTurn(_CharacterOne);
                    Console.WriteLine($"Total power = {Attack}");
                    _CharacterTwo.TakeDamage(Attack);
                    CharacterOneTurn = false;
                    CharacterTwoTurn = true;
                }
                else if (CharacterTwoTurn)
                {
                    decimal Attack = ApplyTurn(_CharacterTwo);
                    Console.WriteLine($"Total power = {Attack}");
                    _CharacterOne.TakeDamage(Attack);
                    CharacterOneTurn = true;
                    CharacterTwoTurn = false;
                }
            }
            Console.WriteLine("\n========================");
            if (_CharacterOne.Health > 0)
                Console.WriteLine($"GAME OVER! {_CharacterOne.Name} is the WINNER!");
            else
                Console.WriteLine($"GAME OVER! {_CharacterTwo.Name} is the WINNER!");
            Console.WriteLine("========================\n");
        }
        
        public decimal ApplyTurn(Character character)
        {
            Console.WriteLine($"{character.GetType()} Turn");
            decimal Attack = 0 ;
            if (_CountoUseSpecialAttack == 0)
            {
                Attack = character.SetSpecialAttack();
                Console.WriteLine($"{character.GetType} using Special Attack");
                Console.WriteLine($"Total power = {Attack}");
                _CountoUseSpecialAttack = 3;
            }
            _CountoUseSpecialAttack--;
            bool Chooise = UsingItem();
            if (Chooise)
            {
                ChooseandUseItem(character);
            }
            else
            {
                Attack = character.AttackPower;

            }
            Console.WriteLine($"Total power = {Attack}");
            return Attack;
        }
        public bool UsingItem()
        {
            Console.Write("Do You want to use an Item [Y|N]");
            String input = Console.ReadLine().ToLower();
            if (input == "y")
                return true;
            else if (input == "n")
                return false;
            else
            
                throw new Exception("invalied input");
        }
        public void ChooseandUseItem(Character character)
        {
            Console.WriteLine("Choose one of this");
            character.MyInventory.DisplayItems();
            Console.Write("Enter Your Chosie:");
            int.TryParse(Console.ReadLine(), out int input);
            character.UseItem(input - 1);
        }
    }
}
