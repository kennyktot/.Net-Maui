using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter an operator (+, -, *, /, %): ");
            string oper = (Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    double sum = num1 + num2;
                    Console.WriteLine($"The result is {sum:F1}");
                    break;
                case "-":
                    double diff = num1 - num2;
                    Console.WriteLine($"The result is {diff:F1}");
                    break;
                case "*":
                    double mult = num1 * num2;
                    Console.WriteLine($"The result is {mult:F1}");
                    break;
                case "/":
                    double qoutient = num1 / num2;
                    Console.WriteLine($"The result is {qoutient:F1}");
                    break;
                case "%":
                    double modulo = num1 % num2;
                    Console.WriteLine($"The result is {modulo}");
                    break;
                default:
                    Console.WriteLine("Please input valid operator.");
                    break;

            }
        }
    }
}
