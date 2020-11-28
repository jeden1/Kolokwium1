using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static int trojkat(int[] tab)
        {
            Array.Sort(tab);
            if (tab[0] + tab[1] > tab[2])
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int[] odcinki = new int[3];
            Console.Write("Podaj długość oddcinka a: ");
            odcinki[0] = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość oddcinka b: ");
            odcinki[1] = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość oddcinka c: ");
            odcinki[2] = int.Parse(Console.ReadLine());
            Array.Sort(odcinki);
            if (trojkat(odcinki)==1)
                Console.WriteLine("Z odcinków {0}, {1} oraz {2} mozna zbudować trójkąt", odcinki[0], odcinki[1], odcinki[2]);
            else
                Console.WriteLine("Z odcinków {0}, {1} oraz {2} nie można zbudować trójkątu", odcinki[0], odcinki[1], odcinki[2]);
        }
    }
}
