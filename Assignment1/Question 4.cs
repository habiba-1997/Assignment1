using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question_4
    {
        public void GetGrades()

        {
            codes subj = new codes();
            string i = subj.GetStringInput("Enter your obtained grades.");

            if (i == "A")
                Console.WriteLine("Excelent");
            else if (i == "B")
                Console.WriteLine("Good");
            else if (i == "C")
                Console.WriteLine("fair.");
            else if (i =="D")
                Console.WriteLine("Poor");
            else 
                Console.WriteLine("Failure");
            Console.ReadKey();
        }
    }
}
