using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Parrot : Animal
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("...CipCip, CipCipCip!");
        }

        public override void food()
        {
            Console.WriteLine("Mi nutro sopratutto di vermi e semi ");
        }
    }
}
