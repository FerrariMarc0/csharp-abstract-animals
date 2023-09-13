namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Animal> animals = new();
            animals.Add(new Dog("Franco Cane"));
            animals.Add(new Parrot("Geronimo Passerotto"));
            animals.Add(new Eagle("Carlo Aquila"));
            animals.Add(new Dolphin("Curious Delfino"));

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Sig {animal.Name}:");
                animal.AnimalNoise();
                animal.food();

                if (animal is IFlyer flyer)
                    Fly(flyer);
                else if(animal is ISwimmer swimmer)
                    Swim(swimmer);
                animal.Sleep();
                Console.WriteLine();
            }
            /*Console.WriteLine("Tutti quanti in coro tirate fuori il vostro verso...");

            Console.Write("Cane: ");
            dog.AnimalNoise();
            Console.Write("Passerotto: ");
            parrot.AnimalNoise();
            Console.Write("Aquila: ");
            eagle.AnimalNoise();
            Console.Write("Delfino: ");
            dolphin.AnimalNoise();

            Console.WriteLine();
            Console.WriteLine("Bene, bene, bene. Adesso ditemi, di cosa vi nutrite?...");

            Console.Write("Cane: ");
            dog.food();
            Console.Write("Passerotto: ");
            parrot.food();
            Console.Write("Aquila: ");
            eagle.food();
            Console.Write("Delfino: ");
            dolphin.food();

            Console.WriteLine();
            Console.WriteLine("Bene grazie a tutti, adesso riposo.");
            Console.Write("Cane: ");
            dog.Sleep();
            Console.Write("Passerotto: ");
            parrot.Sleep();
            Console.Write("Aquila: ");
            eagle.Sleep();
            Console.Write("Delfino: ");
            dolphin.Sleep();*/
        }

        private static void Swim(object swimmer)
        {
            throw new NotImplementedException();
        }

        public static void Fly(IFlyer animal)
        {
            animal.Fly();
        }
        public static void Swim(ISwimmer animal)
        {
            animal.Swim();
        }
    }
}