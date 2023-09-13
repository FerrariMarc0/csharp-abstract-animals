namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new();
            Parrot parrot = new();
            Eagle eagle = new();
            Dolphin dolphin = new();

            Console.WriteLine("Tutti quanti in coro tirate fuori il vostro verso...");

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
            dolphin.Sleep();
        }
    }
}