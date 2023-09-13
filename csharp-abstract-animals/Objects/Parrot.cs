using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Parrot : Animal, IFlyer
    {
        public Parrot(string name) : base(name)
        {
        }

        public override void AnimalNoise()
        {
            Console.WriteLine("Qual'è il tuo verso?...CipCip, CipCipCip!");
        }

        public void Fly()
        {
            Console.WriteLine("Qual'è la tua abilità?...Riesco a svolazzare qua e la!");
        }

        public override void food()
        {
            Console.WriteLine("Di cosa ti nutri?...Mi nutro sopratutto di vermi e semi ");
        }
    }
}
