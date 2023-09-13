using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Eagle : Animal, IFlyer
    {
        public Eagle(string name) : base(name)
        {
        }

        public override void AnimalNoise()
        {
            Console.WriteLine("Qual'è il tuo verso?...gni, gni, gniii Gianluca!");
        }

        public void Fly()
        {
            Console.WriteLine("Qual'è la tua abilità?...So volare!");
        }

        public override void food()
        {
            Console.WriteLine("Di cosa ti nutri?...Mi nutro di volpi, lepri, marmotte, conigli e qualunque mammifero mi capiti sotto becco!! Sicuramente non delle tue ciabatte.");
        }
    }
}
