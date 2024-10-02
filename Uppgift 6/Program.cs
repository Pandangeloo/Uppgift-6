
//Detta är en branch


namespace NameSorter
{
    class Program
    {   
        
        
        public static void Main(string[] args)
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
                Console.WriteLine($"{searchName} is not in the list");
            }


            Console.ReadKey();

            AddNewNames();

//Metod för att lägga till nytt namn
             void AddNewNames()
            {
                Console.WriteLine("Skriv namnet på den du vill lägga till:");
                string newName = Console.ReadLine();
                names.Add(newName);
                Console.WriteLine($"Du har nu lagt till namn {newName}");
            }


            

        }
        
        
        
        
       
    }
}
