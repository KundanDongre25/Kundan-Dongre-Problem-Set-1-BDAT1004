using System;

//Implement function triangleArea(a, b, c) that takes as input the lengths of the 3 sides of a triangle and returns the area of the triangle. By Heron's formula, the area of a triangle with side lengths a, b, and c is s(s - a)(s - b)(s - c), where s = (a + b + c) / 2.

namespace ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double s, area;
            double a, b, c;

            a = 2;
            b = 2;
            c = 2;

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Area = {0}", area);
        }
    }
}

