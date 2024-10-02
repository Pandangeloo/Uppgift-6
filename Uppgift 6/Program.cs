
//Detta är en branch




namespace NameSorter
{
    class Program
    {   
        static List<string> names = new List<string> { "Anna", "John", "Alice", "Berit" };

        
        public static void Main(string[] args)
        {
            
           
            Console.WriteLine("Original List:");

            foreach (var name in names)
            {
                Console.WriteLine(name);

            }

            

            


            Console.ReadKey();

            AddNewNames();
            SearchNames();
            SortNames();




            

        }

        private static void SortNames()
        {
            names.Sort(); //Sortera alfabetiskt
            Console.WriteLine("\nSorted list:");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }




        //Metod för att söka namn.  
        private static void SearchNames()
        {
           Console.WriteLine("Enter name to search");
            string searchName = Console.ReadLine();

            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list");
            }
        }

        private static void AddNewNames()
        {
            Console.WriteLine("Skriv namnet på den du vill lägga till:");
            string newName = Console.ReadLine();
            names.Add(newName);
            Console.WriteLine($"Du har nu lagt till namn {newName}");
        }
    }
}
