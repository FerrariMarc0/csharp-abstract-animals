using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Eagle : Animal
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("...gni, gni, gniii Gianluca!");
        }

        public override void food()
        {
            Console.WriteLine("Mi nutro di volpi, lepri, marmotte, conigli e qualunque mammifero mi capiti sotto becco!! Sicuramente non delle tue ciabatte.");
        }
    }
}
