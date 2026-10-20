using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace oefeningen_05
{
    internal class Loops
    {
        public static void CountDown()
        {
            int num;
            Console.Write("Geef een getal in: ");

            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                Console.WriteLine(num);
                num = num - 1;
            }
            Console.WriteLine("Start!");
        }

        public static void Password()
        {
            string passWord;
            int countTries = 0;


            do
            {
                countTries = countTries + 1;
                Console.Write("Geef het wachtwoord in: ");
                passWord = Console.ReadLine();

            } while (passWord != "AP");

            Console.WriteLine("Wachtwoord in orde!");
            Console.WriteLine($"aantal pogingen: {countTries}");

        }

        public static void Average()
        {
            double userInput;
            double TotalSum = 0;
            int count = 0;
            do
            {
                Console.Write("Geef het volgende getal in (stoppen met 0) ");
                userInput = Convert.ToDouble(Console.ReadLine());
                TotalSum = TotalSum + userInput;
                count = count + 1;
            } while (userInput != 0);

            Console.WriteLine($"Het gemiddelde: {TotalSum / (count - 1)}");
        }

        public static void Party()
        {
            string listOfAttendees = "";
            string yesOrNo = "nee";
            string name = "";
            int totalAttendees = 0;

            while (yesOrNo != "ja")
            {
                Console.Write("Wil je een volgende persoon inschrijven? (ja of nee) ");
                yesOrNo = Console.ReadLine();

                if (yesOrNo == "ja")
                {
                    Console.Write("Geef de naam: ");
                    name = Console.ReadLine();
                    listOfAttendees = listOfAttendees + " " + name;
                    totalAttendees = totalAttendees + 1;
                    yesOrNo = "nee";
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Lijst van aanwezigen: {listOfAttendees}");
            Console.WriteLine($"Er zijn {totalAttendees} personen aanwezig");

        }

        public static void NumberOfDigits()
        {
            int num;
            int numOfDigits = 0;

            Console.Write("Geef een geheel getal in: ");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                num = num / 10;
                numOfDigits = numOfDigits + 1;
            } while (num > 0);


            Console.Write($"Het ingegeven getal bestaat uit {numOfDigits} cijfers");
        }

        public static void Lions()
        {
            double totalNumberOfLions = 50;
            int yearsCount = 0;

            do
            {
                yearsCount = yearsCount + 1;
                totalNumberOfLions = totalNumberOfLions + (totalNumberOfLions * 0.15);
                Console.WriteLine($"Na {yearsCount} jaar zijn er {Math.Round(totalNumberOfLions)} leeuwen");
            } while (totalNumberOfLions <= 100);
        }

        public static void SumOfEvenNumbers()
        {
            int num, sum, isEvenNum;

            sum = 0;
            isEvenNum = 1;

            Console.Write("Geef n in: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (isEvenNum <= num)
            {
                if (isEvenNum % 2 == 0)
                {
                    sum = sum + isEvenNum;
                    Console.WriteLine($"Even getal {isEvenNum}. De som van de getallen tot nu is: {sum}");
                }
                isEvenNum = isEvenNum + 1;
            }
        }

        public static void Factors()
        {

            int num;
            string listOfFactors = "";
            int candidateNumber = 1;

            Console.WriteLine("Geef een getal (groter dan 1):");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("Invalid  input.");
            }
            else
            {
                while (candidateNumber <= num)
                {
                    if (num % candidateNumber == 0)
                    {
                        listOfFactors = listOfFactors + candidateNumber.ToString();
                        if (candidateNumber != num)
                        {
                            listOfFactors = listOfFactors + ", ";
                        }
                    }
                    candidateNumber = candidateNumber + 1;
                }

                Console.WriteLine($"Factoren zijn:{listOfFactors}");
            }

        }

        public static void RNATranscription()
        {
            string userInput;
            string transcribedString = "";

            do
            {
                Console.WriteLine("Geef de letter in (stoppen met 'stop')");
                userInput = Console.ReadLine();

                if (userInput.Length == 1)
                {

                    if (userInput == "G")
                    {
                        transcribedString = transcribedString + "C";
                    }
                    else if (userInput == "C")
                    {
                        transcribedString = transcribedString + "G";
                    }
                    else if (userInput == "T")
                    {
                        transcribedString = transcribedString + "A";
                    }
                    else if (userInput == "A")
                    {
                        transcribedString = transcribedString + "U";
                    }
                }

            } while (userInput != "stop");

            Console.Write($"De RNA string is: {transcribedString}");
        }

        public static void Accountant()
        {
            int userInput;
            int totalBalance = 0;
            int sumOfNegativeNumber = 0;
            int sumOfPositiveNumber = 0;
            int average = 0;
            int index = 0;

            do
            {

                Console.WriteLine("Geef een getal");
                userInput = Convert.ToInt32(Console.ReadLine());

                totalBalance = totalBalance + userInput;

                if (userInput >= 0)
                {
                    sumOfPositiveNumber = sumOfPositiveNumber + userInput;
                }
                else
                {
                    sumOfNegativeNumber = sumOfNegativeNumber + userInput;
                }

                index = index + 1;
                average = totalBalance / index;

                Console.WriteLine($"De balans is {totalBalance}");
                Console.WriteLine($"De som van de positieve getallen is {sumOfPositiveNumber}");
                Console.WriteLine($"De som van de negatieve getallen is {sumOfNegativeNumber}");
                Console.WriteLine($"Het gemiddelde is {average}");


            } while (true);
        }

        public static void Minus100Plus100()
        {
            Console.WriteLine("Basis");
            for (int i = -100; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Extended");
            for (int i = -100; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void AMultiplicationTable()
        {
            int num;

            Console.WriteLine("Van welk getal wil je de tafel van vermenigvuldiging zien?");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
            }
        }

        public static void Multiples6And8()
        {


            for (int i = 1; i <= 100; i++)
            {
                if(i % 6 == 0 || i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Fibonacci()
        {
            int userInput;
            int previousOne, previousTwo;
            int num;
            Console.Write("Geef het aantal getallen op die je wil zien van de reeks: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("De fibonacci lijst is: ");
    

            previousOne = 0;
            previousTwo = 1;
            Console.Write(previousOne + " ");
            
            for (int i = 1; i < userInput - 1; i++)
            {
                num = previousOne + previousTwo;
                Console.Write(num + " ");

                previousOne = previousTwo;
                previousTwo = num;
            }
        }

        public static void PrimeNumberChecker()
        {
            int userInput;
            int countPrime = 0;
   

            Console.WriteLine("Geef getal in:");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                if(userInput % i == 0)
                {
                    countPrime++;
                }
            }

            if (countPrime == 2)
            {
                Console.WriteLine($"{userInput} is priemgetal");
            }
            else
            {
                Console.WriteLine($"{userInput} is geen priemgetal");
            }
        }

        public static void PrimeNumberCheckerTwo()
        {
            int userInput;
            int countPrime = 0;


            Console.WriteLine("Geef getal in:");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                if (userInput % i == 0)
                {
                    countPrime++;
                }
            }

            if (countPrime == 2)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine($"not prime");
            }
        }
        public static void PrimeNumberGenerator()
        {
            int start, end, countPrime;

            Console.WriteLine("Priemgetallen van (laagste getal):");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("tot en met (hoogste getal):");
            end = Convert.ToInt32(Console.ReadLine());

            while(start <= end)
            {
                countPrime = 0;
                for (int i = 1; i <= start; i++)
                {
                    if (start % i == 0)
                    {
                        countPrime++;
                    }
                }

                if (countPrime == 2)
                {
                    Console.Write(start + " ");
                }
                start++;
            }

        }
    }
}
