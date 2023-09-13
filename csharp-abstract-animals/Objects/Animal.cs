using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public void Sleep()
        {
            Console.WriteLine("Riposo:...ZZZzzZzZ...!!");
        }
        public abstract void AnimalNoise();
        public abstract void food();

    }
}
