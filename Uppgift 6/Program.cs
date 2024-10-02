
//Detta är en branch






namespace NameSorter
{
    class Program
    {   
        static List<string> names = new List<string> { "Anna", "John", "Alice", "Berit" };

        
        public static void Main(string[] args)
        {
            bool programWorks = true;

            while (programWorks) 
            {
                Console.WriteLine();
                ShowMenu();

                char menuChoice = Console.ReadKey().KeyChar;

                switch (menuChoice) 
                {
                    case '1':
                        ShowList();
                        break;
                    case '2':
                        SortNames();
                        break;
                    case '3':
                        AddNewNames();
                            break;
                    case '4':
                        SearchNames();
                        break;
                    case '5':
                        Console.WriteLine("Det är uppfattat, jag avslutar nu programmet. Hejdå!");
                        programWorks = false;
                        break;

                    default:
                        Console.WriteLine("Nu valde du något som inte fanns, försök igen.");
                        Console.WriteLine();
                        continue;       

                                       
                }
                                   


            Console.ReadKey();
                continue;


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

        //Visa listan som den är
        private static void ShowList()
        {
            Console.WriteLine("Original List:");

            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
        }

        //Visa en sorterad Lista
        private static void SortNames()
        {
            names.Sort(); //Sortera alfabetiskt
            Console.WriteLine("\nSorted list:");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }




        //Söka efter ett namn
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

        //Lägga till nytt namn
        private static void AddNewNames()
        {
            Console.WriteLine("Skriv namnet på den du vill lägga till:");
            string newName = Console.ReadLine();
            names.Add(newName);
            Console.WriteLine($"Du har nu lagt till namn {newName}");
        }
    }
}
