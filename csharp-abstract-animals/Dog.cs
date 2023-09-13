using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dog : Animal
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("...Woooff woof bau!!");
        }

        public override void food()
        {
            Console.WriteLine("Mi nutro di tutto ciò che capita sotto il mio naso, anche le tue ciabatte!! Soprattutto le tue ciabatte.");
        }
    }
}
