using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program rozwiazujacy ax^2-3x+2c=0");
            Console.Write("Podaj liczbę a: ");
            double a = double.Parse(Console.ReadLine());
            double b = -3;
            Console.Write("Podaj liczbę b: ");
            double c = double.Parse(Console.ReadLine());
            double delta = (b*b) - (4 * a * 2 * c);
            if (Math.Sqrt(delta) < 0)
                Console.WriteLine("Równanie nie ma rozwiązania");
            else
            {
                if (Math.Sqrt(delta) == 0)
                    Console.WriteLine("Równanie ma jedno rowziązanie: {0}", (b*-1)/(2*2*c));
                else
                {
                    double x1 = ((b * -1) - Math.Sqrt(delta) / 2 * a);
                    Console.WriteLine("Pierwsze rozwiązanie rónania: {0}", x1);
                    Console.WriteLine("Drugie rozwiązanie rónania: {0}", ((b * -1 )+ Math.Sqrt(delta))/(2*a));
                }
            }
        }
    }
}
