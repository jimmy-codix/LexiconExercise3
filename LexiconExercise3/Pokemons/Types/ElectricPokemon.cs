using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3.Pokemons.Types
{
    internal class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(List<Attack> attacks) : base(attacks)
        {
            Type = ElementType.Electric;
        }
    }
}
