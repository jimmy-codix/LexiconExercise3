using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3
{
    internal class Attack
    {
        protected string Name { get; private set; } = String.Empty;
        protected ElementType Type { get; private set; }
        protected int BasePower { get; private set; }

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public void Use(int level)
        {
            //TODO Fix this
            Console.WriteLine($"{Name} hits with total power {BasePower + level}");
        }

    }
}
