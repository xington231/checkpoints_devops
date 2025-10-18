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
        public decimal Power(decimal x, decimal y)
        {
            if (y == 0) return 1;
            if (x == 0 && y > 0) return 0;
            return (decimal)Math.Pow((double)x, (double)y);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(4,2);
            Console.WriteLine(calculator.Power(4, 2));
            Console.WriteLine(calculator.Add(4, 2) );
            Console.WriteLine(calculator.Multiply(4, 2));
            Console.WriteLine(calculator.Divide(4, 2));
            Console.WriteLine(calculator.Subtract(4, 2));

        }
    }
}
