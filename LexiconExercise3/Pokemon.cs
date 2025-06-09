using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LexiconExercise3
{
    internal abstract class Pokemon
    {
        //TODO validation
        private string _name = string.Empty;
        private int _level = 0;
        public string Name
        {
            get { return _name; }
            set
            {
                if ((value.Length > 1) && (value.Length < 16))
                    _name = value;
                else
                    throw new ArgumentException("Charachter name needs to be between 2 and 15 chars.");
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                if (value >= 1)
                    _level = value;
                else
                    throw new ArgumentException("Level needs to be 1 or more.");
            }
        }
        public ElementType Type { get; set; }
        public List<Attack> Attacks { get; private set; }

        public Pokemon(List<Attack> attacks)
        {
            Attacks = attacks;
        }


        public void RandomAttack()
        {
            int rnd = new Random().Next(0, Attacks.Count);
            Attacks[rnd].Use(Level);
        }

        public void Attack()
        {
            OutPutMenu();
            int sel = MenuSelect();
            Attacks[sel-1].Use(Level);
        }
        //TODO: This should not be in this class.
        private void OutPutMenu()
        {
            //TODO: Use a ToString() instead
            Console.WriteLine($"Please select an attack:");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Attacks[i].Name}");
            }
        }

        //TODO: This should not be in this class.
        private int MenuSelect()
        {
            string errorText= "Wrong attack. Please select an attack:";
            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result >= 1 && result <= (Attacks.Count))
                        return result;
                    else
                        Console.WriteLine(errorText);
                }
                else { Console.WriteLine(errorText); }
            } while (true);
        }

        public void RaiseLevel()
        {
            Level++;
            Console.WriteLine($"{Name} leveled up to {Level}!");
        }
    }
}
