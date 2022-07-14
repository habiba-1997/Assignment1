using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question2
    {
        public void Solution2()
        {
            float N1; float N2; char N3;
            Console.WriteLine("Enter first value");
            string ii = Console.ReadLine();
            Console.WriteLine("Enter second value");
            string jj = Console.ReadLine();
            Console.WriteLine("Enter a character");
            string kk = Console.ReadLine();
            N1 = float.Parse(ii);
            N2 = float.Parse(jj);
            N3 = char.Parse(kk);



            codes subj = new codes();
            if (N3 == '+')
            {
                float Sum = subj.GetSum(N1, N2);
                Console.WriteLine("Sum of " + N1 + " and " + N2 + " = " + Sum);
            }
            else if (N3 == '_')
            {
                float Sub = subj.GetSub(N1, N2);
                Console.WriteLine("sub of " + N1 + " and " + N2 + " = " + Sub);
            }
            else if (N3 == '*')
            {
                float Mul = subj.GetMul(N1, N2);
                Console.WriteLine("mul of " + N1 + " and " + N2 + " = " + Mul);
            }
            else
            {
                float Div = subj.GetDiv(N1, N2);
                Console.WriteLine("Div of " + N1 + " and " + N2 + " = " + Div);
            }
            Console.ReadKey();
        }
    }
}
