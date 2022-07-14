using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question8
    {
        public void Triangle()
        {
            Console.WriteLine("Enter the length of first leg:");
            string ii = Console.ReadLine();
            Console.WriteLine("Enter the lenght of second leg:");
            string jj = Console.ReadLine();
            double leg1 = double.Parse(ii);
            double leg2 = double.Parse(jj);
            double area;
            double hypotenuse;
            area =( leg1 * leg2) /2;
            Console.WriteLine("Area is:"+area);
            hypotenuse = Math.Sqrt((leg1 * leg1) + (leg2 * leg2));
            Console.WriteLine("hypotenuse is: " + hypotenuse);
            Console.ReadKey();

        }
    }
}
