using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question6
    {
        public void PositiveDivisible()
        {
            Console.WriteLine("Enter first value");
            string ii = Console.ReadLine();
            Console.WriteLine("Enter second value");
            string jj = Console.ReadLine();
            int N1 = int.Parse(ii);
            int N2 = int.Parse(jj);
            if (N1 >= 0 && N2 >= 0)
            {
                    if (N1 > N2 && N1 % N2 == 0)
                        Console.WriteLine("N1 is greater and divisible by N2.");
                    else if (N1 > N2 && N1 % N2 != 0)
                        Console.WriteLine("N1 is greater but not divisible by N2.");
                    else if (N2 > N1 && N2 % N1 == 0)
                        Console.WriteLine("N2 is greater and  divisible by N1.");
                   else
                        Console.WriteLine("N2 is greater nut not divisible by N1.");
            }
            else
                Console.WriteLine("solution is not possible.");
                Console.ReadKey();
        }
    }
}
