using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public void Sleep()
        {
            Console.WriteLine("ZZZzzZzZ...");
        }
        public abstract void AnimalNoise();
        public abstract void food();

    }
}
