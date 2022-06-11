using System;
using System.Collections.Generic;

namespace rownanie_kwardratowe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int[]> dane = new List<int[]>();
            dane.Add(new int[] { 1, 2, 3 });
            dane.Add(new int[] { -10, 5, 7 });

            for (int i = 0; i < dane.Count; i++)
            {
                double deltaWynik = Delta(dane[i][0], dane[i][1], dane[i][2]);
                policzPierwiastki(dane[i][0], dane[i][1], deltaWynik);
            }
        }

        private static double Delta(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        private static void policzPierwiastki(double a, double b, double deltaWynik)
        {
            if (deltaWynik > 0)
            {
                double pierDelta = Math.Sqrt(deltaWynik);
                Console.WriteLine("Mamy dwa rozwiązania");
                Console.WriteLine("X1 wynosi: " + ((-b - pierDelta) / (2 * a)));
                Console.WriteLine("X1 wynosi: " + ((-b + pierDelta) / (2 * a)));
            }
            else if (deltaWynik == 0)
            {
                Console.WriteLine("Mamy jedno rozwiązanie");
                Console.WriteLine("X1 wynosi: " + (-b / (2 * a)));
            }
            else
                Console.WriteLine("Brak rozwiązań");
        }
    }
}