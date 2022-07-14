using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question3
    {
        public void GetRoot() 
        {
            
            int Root;
            Console.WriteLine("Enter first value");
            string ii = Console.ReadLine();
            Console.WriteLine("Enter second value");
            string jj = Console.ReadLine();
            Console.WriteLine("Enter third value");
            string kk = Console.ReadLine();
            int a = int.Parse(ii);
            int b = int.Parse(jj);
            int c = int.Parse(kk);
            Root = b * b - 4 * a * c;
            if(Root == 0)
                Console.WriteLine("the root is equal.");
            else if(Root < 0)
                Console.WriteLine("the root is not real.");
            else
                Console.WriteLine("the root is real.");
            Console.ReadKey();


        }
    }
}
