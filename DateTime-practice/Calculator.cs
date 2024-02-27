using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_practice
{
    class Calculator
    {
        public void Sum(int num1,int num2) {
            int result = num1 + num2;   
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
        public void Sub(int num1,int num2) { 
            int result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
        }

        public void Mul(int num1,int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
        }
        public void div(int num1,int num2)
        {
            int result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
        }
    }
}
