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
            var charamander = new Charmander(new List<Attack>() { flamethrower, ember })
            {
                Name = "Charamander",
                Level = 1
            };

            var drown = new Attack("Drown", ElementType.Water, 12);
            var oceanwave = new Attack("Ocean Wave", ElementType.Water, 6);
            var squirtle = new Squirtle(new List<Attack>() { drown, oceanwave })
            {
                Name = "Squirtle",
                Level = 1
            };

            var thunder = new Attack("Thunder", ElementType.Electric, 12);
            var bolt = new Attack("Bolt", ElementType.Electric, 6);
            var pikachu = new Pikachu(new List<Attack>() { thunder, bolt })
            {
                Name = "Pikachu",
                Level = 1
            };

            pokemons.Add(charamander);
            pokemons.Add(squirtle);
            pokemons.Add(pikachu);

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"Pokemon {pokemon.Name} prepares for an attack!");
                pokemon.Attack();
                pokemon.RaiseLevel();
                Console.WriteLine($"Pokemon {pokemon.Name} prepares for an random attack!");
                pokemon.RandomAttack();
                if (pokemon is IEvolvable)
                    (pokemon as IEvolvable)!.Evolve();
            }


        }
    }
}
