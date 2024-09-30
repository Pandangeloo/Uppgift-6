namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Anna", "John", "Alice", "Berit" };
            Console.WriteLine("Original List:");

            foreach (var name in names)
            {
                Console.WriteLine(name);

            }

            names.Sort(); //Sortera alfabetiskt
            Console.WriteLine("\nSorted list:");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Enter name to search");
            string searchName = Console.ReadLine();

            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list")
            }


            Console.ReadKey();





        }
    }
}
