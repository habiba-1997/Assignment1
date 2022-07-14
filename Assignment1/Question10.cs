using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question10
    {
        public void Year()
        {
            string input = "2022";
            while (input != "1")
            {

                Console.WriteLine("Year:");

                input = Console.ReadLine();
                int year = int.Parse(input);

                int givenYear = 2000;
                int differnceYear = year - givenYear;

                int leapYear = differnceYear /4;
                leapYear =  year % 4 ==0 ? leapYear - 1 : leapYear;
                
                int totaldays = (differnceYear * 365) + leapYear+1;
                int days = (totaldays % 7) - 1;
                Console.WriteLine("=>" + DateTime.Parse($"1/1/{year}").DayOfWeek.ToString());
                if (days == 1)
                    Console.WriteLine("monday");
                else if (days == 2)
                    Console.WriteLine("Tuesday");
                else if (days == 3)
                    Console.WriteLine("Wednesday");
                else if (days == 4)
                    Console.WriteLine("Thursday");
                else if (days == 5)
                    Console.WriteLine("Friday");
                else if (days == 6)
                    Console.WriteLine("Saturday");
                else
                    Console.WriteLine("Sunday");
            }
            Console.ReadKey();
        }
    }
}
