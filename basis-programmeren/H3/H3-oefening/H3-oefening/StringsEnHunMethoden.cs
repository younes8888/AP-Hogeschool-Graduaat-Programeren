using System;
using System.Collections.Generic;
using System.Text;

namespace H3_oefening
{
    internal class StringsEnHunMethoden
    {
        public static void CapitalLetters()
        {
            Console.WriteLine("Welke tekst moet ik omzetten?");

            string output = Console.ReadLine().ToUpper();
            Console.WriteLine(output);
        }

        public static void MultiplicationTablesStringInterpolation()
        {
            int num = 411;

            //Console.ReadLine();
            //Console.Clear();
            Console.WriteLine($"1 * {num} is {num * 1}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"2 * {num} is {num * 2}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"3 * {num} is {num * 3}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"4 * {num} is {num * 4}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"5 * {num} is {num * 5}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"6 * {num} is {num * 6}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"7 * {num} is {num * 7}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"8 * {num} is {num * 8}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"9 * {num} is {num * 9}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"10 * {num} is {num * 10}");
        }
        public static void SpaceStringInterpolation()
        {
            float weight = 69;

            float Mercurius = 0.38f;
            float Venus = 0.91f;
            float Aarde = 1.00f;
            float Mars = 0.38f;
            float Jupiter = 2.34f;
            float Saturnus = 1.06f;
            float Uranus = 0.92f;
            float Neptunus = 1.19f;
            float Pluto = 0.06f;

            Console.WriteLine($"Op Mercurius voel je je alsof je {Mercurius * weight}kg weegt.");
            Console.WriteLine($"Op Venus  voel je je alsof je {Venus * weight}kg weegt.");
            Console.WriteLine($"Op Aarde  voel je je alsof je {Aarde * weight}kg weegt.");
            Console.WriteLine($"Op Mars  voel je je alsof je {Mars * weight}kg weegt.");
            Console.WriteLine($"Op Jupiter  voel je je alsof je {Jupiter * weight}kg weegt.");
            Console.WriteLine($"Op Saturnus  voel je je alsof je {Saturnus * weight}kg weegt.");
            Console.WriteLine($"Op Uranus  voel je je alsof je {Uranus * weight}kg weegt.");
            Console.WriteLine($"Op Neptunus  voel je je alsof je {Neptunus * weight}kg weegt.");
            Console.WriteLine($"Op Pluto  voel je je alsof je {Pluto * weight}kg weegt.");
        }

        public static void VATCalculation()
        {
            int sum, btwPercentage;

            Console.Write("Geef het bedrag in: ");
            sum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef BTW percentage in: ");
            btwPercentage = Convert.ToInt32(Console.ReadLine());

            double totalSum = sum * btwPercentage / 100 + sum;

            Console.WriteLine($"Het bedrag {sum} met {btwPercentage}% btw bedraagt {totalSum}");
        }
    }
}
