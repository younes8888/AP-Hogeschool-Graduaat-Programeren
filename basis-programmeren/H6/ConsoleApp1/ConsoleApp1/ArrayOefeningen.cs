namespace ConsoleApp1
{
    internal class ArrayOefeningen
    {
        public static void ArrayTrueFalse()
        {
            bool[] arr = new bool[30];

            Console.WriteLine("Maak een array gevuld met afwisselen true en false(lengte is 30)");

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = true;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    Console.Write($"{arr[i]}, ");

                }
                else
                {
                    Console.Write($"{arr[i]}");
                }
            }
        }

        public static void ArrayExercise()
        {
            int[] arr = new int[10];
            int userInput;
            Console.WriteLine("Voer 10 gehele getallen in");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("******");

            Console.WriteLine($"Som is {arr.Sum()}, Gemiddelde is {arr.Average()}, Grootste getal is {arr.Max()}");

            Console.WriteLine("******");

            Console.WriteLine("Geef minimum getal in?");

            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= userInput)
                {
                    if (i != arr.Length - 1)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                    else
                    {
                        Console.Write($"{arr[i]}");

                    }
                }
            }
        }

        public static void Shopping()
        {
            int NumOfItems;
            string itemAlreadyBought;
            string yesOrNo;

            Console.WriteLine("We gaan de boodschappenlijst samenstellen. Hoeveel items wil je opschrijven?");

            NumOfItems = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[NumOfItems];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Wat is item {i + 1} op je lijst?");
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine("Dit is je gesorteerde lijst:");
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {arr[i]}");
            }
            Console.WriteLine("Op naar de winkel!");

            Console.WriteLine("Welk item heb je gekocht?");
            itemAlreadyBought = Console.ReadLine();

            Console.WriteLine("Nog winkelen? (Ja of Nee)");
            yesOrNo = Console.ReadLine();
            if (yesOrNo == "nee")
            {
                Console.WriteLine("Naar huis met de boodschappen!");
                Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != itemAlreadyBought)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                }
            }

        }

        public static void ChristmasShopping()
        {
            int budget;
            int numOfGifts;

            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            budget = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel cadeautjes wil je kopen?");
            numOfGifts = Convert.ToInt32(Console.ReadLine());

            int[] arrOfPrices = new int[numOfGifts];

            for(int i = 0; i < arrOfPrices.Length; i++)
            {
                Console.WriteLine($"Prijs van cadeau {i + 1}?");

            }

        }

        public static void BinarySearch()
        {
            int num = 7;

            int low, high, len;

            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            len = arr.Length;

            low = 0;
            high = len - 1;

            while (low <= high)
            {
                int middle = low + (high - low) / 2;

                if (arr[middle] == num)
                {
                    Console.WriteLine(arr[middle]);
                }
                if (arr[middle] < num)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
        }
    }
}
