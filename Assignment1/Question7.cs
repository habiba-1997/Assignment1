using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question7
    {
        public void IntegerMaxMin()
        {
            Console.WriteLine("Enter first value");
            string ii = Console.ReadLine();
            int integer = int.Parse(ii);
            if( integer >= 0 && integer <= 100)
            {
                if(integer > 50)
                    Console.WriteLine("The integer is greater then 50.");
                else if(integer == 50)
                    Console.WriteLine("The inteer is equal to 50.");
                else
                    Console.WriteLine("the integer is less than 50.");
            }
            else
                Console.WriteLine("the number is greater then 100.");
        }
    }
}
