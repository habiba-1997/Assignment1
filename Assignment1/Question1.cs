using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question1
        
    {
        public void Solution1()
        {
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            if( age < 18)
                Console.WriteLine("CHILd");
            else if(age <= 35)
                Console.WriteLine("ADULT");
            else
                Console.WriteLine("SENIOR");
            Console.ReadKey();
        }
    }
}
