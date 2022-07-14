using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class1
    {
        public void Year()
        {
            Console.WriteLine("Year:");
            string ii = Console.ReadLine();
            int year = int.Parse(ii);
            int givenYear =1900;
            int differnceYear = year - givenYear;
            int leapYear = differnceYear / 4;
            int remainingYear = differnceYear - leapYear;
            int totaldays = (remainingYear * 365) + (leapYear*366);
            int days = totaldays % 7;
            if (days == 0)
                Console.WriteLine("monday");
            else if (days == 1)
                Console.WriteLine("Tuesday");
            else if (days == 2)
                Console.WriteLine("Wednesday");
            else if (days == 3)
                Console.WriteLine("Thursday");
            else if (days == 4)
                Console.WriteLine("Friday");
            else if (days == 5)
                Console.WriteLine("Saturday");
            else
                Console.WriteLine("Sunday");
            Console.ReadKey();
        }
    }
}
