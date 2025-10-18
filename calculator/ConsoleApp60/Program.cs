using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static decimal Subtract(decimal x, decimal y)
        {
            return x - y;
        }
        public static decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }
        public static decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Деление на ноль!");
            }
            return x / y;
        }
        public static decimal Power(decimal x, decimal y)
        {
            if (y == 0) return 1;
            if (x == 0 && y > 0) return 0;
            if (x == 0 && y < 0) throw new ArgumentException("0 в отрицательной степени не определено");

            return (decimal)Math.Pow((double)x, (double)y);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
