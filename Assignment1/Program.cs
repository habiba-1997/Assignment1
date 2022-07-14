using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Question1 obj = new Question1();
            Question2 obj2 = new Question2();
            Question3 obj3 = new Question3();
            Question_4 obj4 = new Question_4();
            Question5 obj5 = new Question5();
            Question6 obj6 = new Question6();
            Question7 obj7 = new Question7();
            Question8 obj8 = new Question8();
            Question9 obj9 = new Question9();
            Question10 obj10 = new Question10();
            ShowManu();
            obj10.Year();
            obj.Solution1();
            obj2.Solution2();
            obj3.GetRoot();
            obj4.GetGrades();
            obj5.MinMax();
            obj6.PositiveDivisible();
            obj7.IntegerMaxMin();
            obj8.Triangle();
            obj9.GrossSalary();




        }
        static void ShowManu()
        {
            Console.WriteLine("Select from Manu:\n + : Sum\n - : Subtraction\n G/g for grades");
            Console.WriteLine("* : Multiply\n/ : Division\n G/g:show grades\n ");
        }


    }

}
