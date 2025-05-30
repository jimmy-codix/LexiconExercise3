using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3
{
    internal abstract class Pokemon
    {
        //TODO validation
        protected string Name { get; set; } = String.Empty;
        protected int Level { get; set; } = 0;
        protected ElementType Type { get; set; }
        public List<Attack> Attacks { get; set; } = new List<Attack>();

        public void RandomAttack()
        {
            // Picks a random attack from the list of attacks and invokes its .Use-method.
            //TODO FIX
            Attacks[0].Use(Level);
        }

        public void Attack()
        {
            // Lets the user pick an attack from the list of attacks and invoke its .Use-method.
        }

        public void RaiseLevel()
        {
            // That should increment the level of the given pokemon and print that the pokemon has leveled up.
        }
    }
}
