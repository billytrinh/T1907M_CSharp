using System;

namespace ConsoleApp1.Lab6
{
    public delegate int MathNumber(int a, int b);
    public class Calc
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public static MathNumber GetFunction(int choose)
        {
            switch (choose)
            {
                case 1: return Sum;
                case 2: return Sub;
                case 3: return Mul;
                case 4: return Div;
                default: return null;
            }
        }
    }
}