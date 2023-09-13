using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dolphin : Animal, ISwimmer
    {
        public Dolphin(string name) : base(name)
        {
        }

        public override void AnimalNoise()
        {
            Console.WriteLine("Qual'è il tuo verso?...Chiiirps!");
        }

        public override void food()
        {
            Console.WriteLine("Di cosa ti nutri?...Mi nutro di pesci, crstacei, calamari e roba cosi.");
        }

        public void Swim()
        {
            Console.WriteLine("Qual'è la tua abilità?...Riesco, maestosamente, a nuotare!");
        }
    }
}
