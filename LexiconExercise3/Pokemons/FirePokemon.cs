using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3.Pokemons
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon(List<Attack> attacks) : base(attacks)
        {
            Type = ElementType.Fire;
        }
    }
}
