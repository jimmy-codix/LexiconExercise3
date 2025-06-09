using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3.Pokemons.Types
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon(List<Attack> attacks) : base(attacks)
        {
            Type = ElementType.Water;        
        }
    }
}
