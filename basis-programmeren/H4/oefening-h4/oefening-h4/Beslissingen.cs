using System;
using System.ComponentModel.Design;
using System.Threading.Channels;


namespace oefening_h4
{
    internal class Beslissingen
    {
        public static void ShoeSeller()
        {
            int numOfItems;
            int basicPrice = 50;
            string yesOrNO;

            Console.WriteLine("Heb je een klantenkaart? (ja of nee)");
            yesOrNO = Console.ReadLine();
            
            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            numOfItems = Convert.ToInt32(Console.ReadLine());


            if (numOfItems > 2 && yesOrNO == "ja")
            {
                Console.WriteLine($"De prijs voor {numOfItems} paar schoenen is {(basicPrice * numOfItems) - ((basicPrice * numOfItems) * 0.1)} euro.");
            }
            else
            {
                Console.WriteLine($"De prijs voor {numOfItems} paar schoenen is {basicPrice * numOfItems} euro.");
            }

        }

        public static void EvenOrOdd()
        {
            int userInput;

            Console.WriteLine("Geef een getal:");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"Het getal {userInput} is even");
            }
            else
            {
                Console.WriteLine($"Het getal {userInput} is oneven");
            }
        }

        public static void PositiveNegativeZero()
        {
            int userInput;

            Console.WriteLine("Geef een getal:");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > 0)
            {
                Console.WriteLine($"Het getal {userInput} is positief.");
            }
            else if(userInput < 0)
            {
                Console.WriteLine($"Het getal {userInput} is negatief.");
            }
            else
            {
                Console.WriteLine($"Het getal {userInput} is nul.");
            }
        }

        public static void BMICalculator()
        {
            double personWeight, personHeight, personBMI;


            Console.WriteLine("Wat is je gewicht?");
            personWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je lengte in meter?");
            personHeight = Convert.ToDouble(Console.ReadLine());

            personBMI = personWeight / (personHeight * personHeight);

            if (personBMI < 18.8)
            {
                Console.WriteLine($"Je hebt een BMI van {Math.Round(personBMI, 1)}. Je bent ondergewicht.");
            }
            else if(personBMI >= 18.5 && personBMI < 25)
            {
                Console.WriteLine($"Je hebt een BMI van {Math.Round(personBMI, 1)}.Je hebt een normaal gewicht.");
            }
            else if (personBMI >= 25 && personBMI < 25)
            {
                Console.WriteLine($"Je hebt een BMI van {Math.Round(personBMI, 1)}. Je hebt een overgewicht.");
            }
            else if (personBMI >= 30 && personBMI < 30)
            {
                Console.WriteLine($"Je hebt een BMI van {Math.Round(personBMI, 1)}. Je hebt een zwaarlijvig.");
            }
            else
            {
                Console.WriteLine($"Je hebt een BMI van {Math.Round(personBMI, 1)}. Je hebt een ernstige obesitas.");
            }
        }

        public static void LargestNumberOfThree()
        {
            int num1, num2, num3;

            Console.Write("Geeft het eerste getal in:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geeft het tweede  getal in:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geeft het derde getal in:");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Het eerste getal {num1} is het grootste.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"Het tweede getal {num2} is het grootste.");
            }
            else
            {
                Console.WriteLine($"Het derde getal {num3} is het grootste.");
            }
        }


        public static void Exams()
        {
            int firstGrade, secondGrade, thirdGrade, totalGrade, failingGradeCount;

            Console.Write("Geef het resultaat in van het eerste examen: ");
            firstGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef het resultaat in van het tweede examen: ");
            secondGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef het resultaat in van het derde examen: ");
            thirdGrade = Convert.ToInt32(Console.ReadLine());


            totalGrade = firstGrade + secondGrade + thirdGrade;
            failingGradeCount = 0;

            if (firstGrade < 50)
            {
                failingGradeCount++;
            }
            if (secondGrade < 50)
            {
                failingGradeCount++;
            }
            if (thirdGrade < 50)
            {
                failingGradeCount++;
            }

            if (totalGrade > 150 && failingGradeCount <= 1)
            {
                Console.WriteLine("Je bent geslaagd!");
            }
            else
            {
                Console.WriteLine("Je bent niet geslaagd!");
            }
        }

        public static void OhmsLaw()
        {
            string userInput;
            double resistance, current, voltage;

            Console.WriteLine("Wat wil je berekenen:spanning, weerstand of stroomsterkte?");
            userInput = Console.ReadLine();


            if (userInput == "spanning")
            {
                Console.Write("Wat is de weerstand? ");
                resistance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Wat is de stroomsterkte? ");
                current = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"De spanning is {(resistance * current):f2}.");


            } else if (userInput == "weerstand")
            {
                Console.Write("Wat is de spanning? ");
                voltage = Convert.ToDouble(Console.ReadLine());

                Console.Write("Wat is de stroomsterkte? ");
                current = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"De weerstand  is {(voltage/current):f2}.");
            }
            else
            {
                Console.Write("Wat is de weerstand? ");
                current = Convert.ToDouble(Console.ReadLine());

                Console.Write("Wat is de spanning? ");
                voltage = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"De stroomsterkte is {(voltage / current):f2}.");
            }

        }

        public static void LeapYear()
        {
            double userInput;

            Console.Write("Geef het jaartal in: ");
            userInput = Convert.ToDouble(Console.ReadLine());

            if (userInput % 4 == 0 && userInput % 100 != 0 && userInput % 400 != 0)
            {
                Console.WriteLine($"{userInput} is een schrikkel jaar");
            }
            else if (userInput % 4 == 0 && userInput % 100 == 0 && userInput % 400 == 0)
            {
                Console.WriteLine($"{userInput} is een schrikkel jaar");
            }
            else
            {
                Console.WriteLine($"{userInput} is niet een schrikkel jaar");
            }
        }

        public static void PocketMoney()
        {
            double userPoints;
            double initialPocketMoney = 20;

            Console.WriteLine("Wat waren je punten op 20?");
            userPoints = Convert.ToDouble(Console.ReadLine());

            if (userPoints > 15)
            {
                Console.WriteLine($"Je zakgeld bedraagt {(initialPocketMoney + (initialPocketMoney * 0.6)) :f1} euro.");
            }
            else if (userPoints > 10 && userPoints <= 15)
            {
                Console.WriteLine($"Je zakgeld bedraagt {(initialPocketMoney + ((userPoints - 10) * 2)):f1} euro.");
            }
            else if (userPoints == 10)
            {
                Console.WriteLine($"Je zakgeld bedraagt {initialPocketMoney:f1} euro.");
            }
            else if (userPoints < 10 && userPoints > 7)
            {
                Console.WriteLine($"Je zakgeld bedraagt {(initialPocketMoney - (initialPocketMoney * 0.3)):f1} euro.");
            }
            else if (userPoints < 7 && userPoints > 5)
            {
                Console.WriteLine($"Je zakgeld bedraagt {(initialPocketMoney - ((10 - userPoints) * 3)):f1} euro.");
            }
            else
            {
                Console.WriteLine($"Je zakgeld bedraagt 0,0 euro.");
            }
        }


    }
}
