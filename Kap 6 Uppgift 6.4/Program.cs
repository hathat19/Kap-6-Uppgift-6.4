using System;
using System.Collections.Generic;
namespace Uppgift6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------

            Console.WriteLine(BeräknaPotens(0.95,5));
        }

        static double BeräknaPotens(double bas, int exponent)
        {
            if (exponent == 0) return 1;

            double product = 1;
            for (int i = 0; i < exponent; i++)
            {
                product *= bas;
            }
            return product;
        }
    }
}
/*Skapa ett program som innehåller en metod som kan användas för att beräkna
potenser, t.ex. 3^2  eller 6,2^4 . Du kan förutsätta att potensens exponent är ett positivt*/