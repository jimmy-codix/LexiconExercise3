using LexiconExercise3.Pokemons.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3.Pokemons.Chars
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(List<Attack> attacks) : base(attacks) {}

        public void Evolve()
        {
            string prevName = Name;
            Name = "Raichu";
            Level = Level * 10;
            //TODO fix Console
            Console.WriteLine($"{prevName} is evolving...Not it´s {Name}! Level {Level}");
        }
    }
}
