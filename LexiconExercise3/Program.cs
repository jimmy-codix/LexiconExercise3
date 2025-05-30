using LexiconExercise3.Pokemons;

namespace LexiconExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
            var charamander = new Charmander();
            charamander.Attacks.Add(flamethrower);
            charamander.Attacks.Add(ember);

            var drown = new Attack("Drown", ElementType.Water, 12);
            var oceanwave = new Attack("Ocean Wave", ElementType.Water, 6);
            var squirtle = new Pikachu();
            squirtle.Attacks.Add(drown);
            squirtle.Attacks.Add(oceanwave);

            var thunder = new Attack("Thunder", ElementType.Electric, 12);
            var bolt = new Attack("Bolt", ElementType.Electric, 6);
            var pikachu = new Pikachu();
            pikachu.Attacks.Add(thunder);
            pikachu.Attacks.Add(bolt);

            pokemons.Add(charamander);
            pokemons.Add(squirtle);
            pokemons.Add(pikachu);

            foreach (var pokemon in pokemons)
            {
                pokemon.RandomAttack();
            }


        }
    }
}
