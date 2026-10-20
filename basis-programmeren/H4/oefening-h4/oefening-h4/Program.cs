namespace oefening_h4
{
    internal class Program
    {
        public static void FirstChapter()
        {
            Console.Clear();
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - MijnEersteProgramma");
            Console.WriteLine("2 - Rommelzin");
            Console.WriteLine("3 - Gekleurde-rommelzin");
        }
        public static void SecondChapter()
        {
            Console.Clear();
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - MijnEersteProgramma");
            Console.WriteLine("2 - Rommelzin");
            Console.WriteLine("3 - Gekleurde-rommelzin");
        }
        public static void ThirdChapter()
        {
            Console.Clear();
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - MijnEersteProgramma");
            Console.WriteLine("2 - Rommelzin");
            Console.WriteLine("3 - Gekleurde-rommelzin");
        }
        public static void FourthChapter()
        {
            Console.Clear();
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - MijnEersteProgramma");
            Console.WriteLine("2 - Rommelzin");
            Console.WriteLine("3 - Gekleurde-rommelzin");
        }
        public static void SubMenu()
        {
            int choice;

            Console.WriteLine("Welke hoofdstuk kies je?");
            Console.WriteLine("1 - Hoofdstuk 1 - Werken met Visual Studio Code");
            Console.WriteLine("2 - Hoofdstuk 2 - Variabelen en datatypes");
            Console.WriteLine("3 - Hoofdstuk 3 - Strings en hun methoden");
            Console.WriteLine("4 - Hoofdstuk 4 - Beslissingen");

            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    {
                        FirstChapter();
                        break;
                    }
                case 2:
                    {
                        SecondChapter();
                        break;
                    }
                case 3:
                    {
                        ThirdChapter();
                        break;
                    }
                case 4:
                    {
                        FourthChapter();
                        break;
                    }

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Ongeldige keuze");
                        break;
                    }
            }

        }
        static void Main(string[] args)
        {
            //Beslissingen.ShoeSeller();
            //Beslissingen.EvenOrOdd();
            //Beslissingen.PositiveNegativeZero();
            //Beslissingen.BMICalculator();
            //Beslissingen.LargestNumberOfThree();
            //Beslissingen.Exams();
            //Beslissingen.OhmsLaw();
            //Beslissingen.LeapYear();
            //Beslissingen.PocketMoney();
            SubMenu();

            Console.ReadKey();
        }
    }
}
