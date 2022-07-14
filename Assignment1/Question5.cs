using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question5
    {
        public void MinMax()
        {
            Console.WriteLine("Enter first value");
            string ii = Console.ReadLine();
            Console.WriteLine("Enter second value");
            string jj = Console.ReadLine();
            Console.WriteLine("Enter third value");
            string kk = Console.ReadLine();
            int N1 = int.Parse(ii);
            int N2 = int.Parse(jj);
            int N3 = int.Parse(kk);
            if (N1 > N2 && N1 > N3)
            {
                if (N2 < N3)
                    Console.WriteLine("N1 is maximum and N2 is minimum.");
                else
                    Console.WriteLine("N1 is maximum and N3 is minimum.");
            }
            else if (N2 > N1 && N2 > N3)
            {
                if (N1 < N3)
                    Console.WriteLine("N2 is maximum and N1 is minimum.");
                else
                    Console.WriteLine("N2 is maximum and  N3 is minimum.");
            }
            else if (N3 > N1 && N3 > N2)
            {
                if (N1 < N2)
                    Console.WriteLine("N3 is maximum and N1 is minimum.");
                else
                    Console.WriteLine("N3 is maximum and N2 is minimum.");
            }
            else
                Console.WriteLine("All numbers are equal.");
            Console.ReadKey();

        }
    }
}
