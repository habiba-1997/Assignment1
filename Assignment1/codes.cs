using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class codes
    {
        public float GetSum(float s, float t)
        {
            float Sum = s + t;
            return Sum;
        }
        public float GetSub(float a, float b)
        {
            float Sub = a - b;
            return Sub;
        }
        public float GetMul(float c, float d)
        {
            float mul = c * d;
            return mul;
        }
        public float GetDiv(float f, float g)
        {
            float div;
            if (f < g)
                div = g / f;
            else
                div = f / g;
            return div;
        }
        public int GetIntInput(string instruction)
        {
            string IntInput = GetStringInput(instruction);
            int x = int.Parse(IntInput);
            return x;
        }
        public string GetStringInput(string instruction)
        {
            Console.WriteLine(instruction);
            string w = Console.ReadLine();
            return w;
        }
    }
}
