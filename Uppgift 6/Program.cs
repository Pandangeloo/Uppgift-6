
//Detta är en branch






namespace NameSorter
{
    class Program
    {   
        static List<string> names = new List<string> { "Anna", "John", "Alice", "Berit" };

        
        public static void Main(string[] args)
        {


            while (true) { 
            

            

            


            Console.ReadKey();

            AddNewNames();
            SearchNames();
            SortNames();
            ShowList();
                ShowMenu();

            Console.ReadKey();


            }

        }

        private static void ShowMenu()
        {
            Console.WriteLine("Hej och VÄLKOMMEN till min lista med olika namn." +
                "\n Gör ett av följande val:" +
                "\n 1. Visa listan" +
                "\n 2. Visa en sorterad lista" +
                "\n 3. Lägg till ett namn" +
                "\n 4. Sök efter ett namn i listan" +
                "\n 5. Avsluta programmet");
        }

        private static void ShowList()
        {
            Console.WriteLine("Original List:");

            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
        }

        //metod för att sortera namnen i listan
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
