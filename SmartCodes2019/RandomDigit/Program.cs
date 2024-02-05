using System;
using static System.Math;

namespace RandomDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double losuj_liczbę, zgadnij_liczbę;

            Console.WriteLine("Program losuje liczbę od 0 do 9. Zgadnij ją.");

            losuj_liczbę = Round(10 * (r.NextDouble()));
            zgadnij_liczbę = double.Parse(Console.ReadLine());

            if (zgadnij_liczbę == losuj_liczbę)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gratulacje! Zgadłeś liczbę!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bardzo mi przykro, ale wylosowana liczba to {0}.", losuj_liczbę);
                Console.ResetColor();
            }
        }
    }
}
