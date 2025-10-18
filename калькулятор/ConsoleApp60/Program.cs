using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public decimal X { get; private set; }
        public decimal Y { get; private set; }
        public Calculator(decimal x,decimal y) 
        {
            this.X = x; 
            this.Y = y; 
        } 
        public decimal Add(decimal x, decimal y)
        {
            return x + y;   
        }
        public decimal Subtract(decimal x, decimal y)
        {
            return x - y;
        }
        public decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }
        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Деление на ноль!");
            }
            return x / y;
        }
        public decimal Power()
        {
            if (Y == 0) return 1;
            if (X == 0 && Y > 0) return 0;
            return (decimal)Math.Pow((double)X, (double)Y);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
