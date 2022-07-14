using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question9
    {
        public void GrossSalary()
        {

            Console.WriteLine("Enter your basicSalary:");
            string ii = Console.ReadLine();
            int Salary = int.Parse(ii);
            double houserent;
            double allownces;
            double GS;
            if(Salary < 1500)
            {
                houserent = Salary * 0.1;
                allownces = Salary * 0.9;

            }
            else
            {
                houserent = Salary * 0.2;
                allownces = Salary * 0.95;

            }
            GS = Salary + houserent + allownces; 
            Console.WriteLine("your grossSalary is:" +GS);
            Console.ReadKey();
        }
    }
}
