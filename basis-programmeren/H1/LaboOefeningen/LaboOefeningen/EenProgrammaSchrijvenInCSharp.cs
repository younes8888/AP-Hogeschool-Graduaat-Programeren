using System;


namespace LaboOefeningen
{
    internal class EenProgrammaSchrijvenInCSharp
    {
        public static void MyFirstProgram()
        {
            string voorName;
            string achterName;

            Console.WriteLine("Dit is mijn eerste C#-programma");
            Console.WriteLine("...............................");


            Console.Write("Typ je voornaam: ");
            voorName = Console.ReadLine();

            Console.Write("Typ je achternaam: ");
            achterName = Console.ReadLine();

            Console.WriteLine("dus je naam is: " + voorName + " " + achterName);
            Console.WriteLine("of: {0} {1}", voorName, achterName);
        }

        public static void Rubbish()
        {
            string color;
            string eten;
            string auto;
            string film;
            string boek;

            Console.WriteLine("Wat is je favoriete kleur?");
            color = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete eten?");
            eten = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete auto?");
            auto = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete film?");
            film = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete boek?");
            boek = Console.ReadLine();

            Console.WriteLine("Je favoriete kleur is {0}. Je eet graag {1}. Je lievelingsfilm is {2} en je favoriete boek is {3}.", eten, auto, boek, film);
        }

        public static void ColoredRubbish()
        {
            string color;
            string eten;
            string auto;
            string film;
            string boek;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wat is je favoriete kleur?");
            Console.ResetColor();
            color = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wat is je favoriete eten?");
            Console.ResetColor();
            eten = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Wat is je favoriete auto?");
            Console.ResetColor();
            auto = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete film?");
            Console.ResetColor();
            film = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wat is je favoriete boek?");
            Console.ResetColor();
            boek = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Je favoriete kleur is {0}. Je eet graag {1}. Je lievelingsfilm is {2} en je favoriete boek is {3}.", eten, auto, boek, film);
            Console.ResetColor();
        }

        public static void AddressCard()
        {
            string name;
            string street;
            string houseNumber;
            string commmune;
            string postCode;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("◦◦◦◦◦◦◦◦◦◦◦");
            Console.WriteLine("Naamkaartje");
            Console.WriteLine("◦◦◦◦◦◦◦◦◦◦◦");

            Console.WriteLine();

            Console.Write("Wat is je naam? ");
            name = Console.ReadLine();

            Console.Write("Wat is je straat? ");
            street = Console.ReadLine();

            Console.Write("Wat is je huisnummer? ");
            houseNumber = Console.ReadLine();

            Console.Write("Wat is je gemeente? ");
            commmune = Console.ReadLine();

            Console.Write("Wat is je postcode? ");
            postCode = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine(street + " " + houseNumber );
            Console.WriteLine(postCode + " " + commmune);

        }
    }
}
