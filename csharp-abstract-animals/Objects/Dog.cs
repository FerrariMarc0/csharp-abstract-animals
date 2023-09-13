using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void AnimalNoise()
        {
            Console.WriteLine("Qual'è il tuo verso?...Woooff woof bau!!");
        }

        public override void food()
        {
            Console.WriteLine("Di cosa ti nutri?...Mi nutro di tutto ciò che capita sotto al mio naso, anche le tue ciabatte!! Soprattutto le tue ciabatte.");
        }
    }
}
