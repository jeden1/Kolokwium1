using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static double[] podziel(int[]tab1, int[] tab2)
        {
            double[] wynik = new double[tab1.Length];
            for (int i = 0; i < tab1.Length; i++)
            {
                double x1 = double.Parse(tab1[i].ToString());
                double x2 = double.Parse(tab2[i].ToString());
                //double x2 = tab2[i];
                wynik[i] = x1/x2;
            }
            return wynik;
        }
        static void Main(string[] args)
        {
            int[] tabA = new int[5];
            int[] tabB = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Podaj {0} element tablicy A: ", i + 1);
                tabA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj {0} element tablicy B: ", i + 1);
                tabB[i] = int.Parse(Console.ReadLine());
            }
            double[] tabC = podziel(tabA, tabB);
            foreach(int x in tabC)
            {
                Console.WriteLine(x + ", ");
            }
        }
    }
}
