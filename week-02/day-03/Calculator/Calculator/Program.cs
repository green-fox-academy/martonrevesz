using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in the expression with integers: 'number' 'operetion' ' 'number'");
            string userInput = Console.ReadLine();
            string[] strings = userInput.Split(' ');
            int operand1 = Convert.ToInt32(strings[0]);
            string operation = strings[1];
            int operand2 = Convert.ToInt32(strings[2]); ;

            switch (operation)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Invalid operation. The universe collapsed.");
                        break;
                    }
                    Console.WriteLine(operand1 / operand2);
                    break;
                case "%":
                    Console.WriteLine(operand1 % operand2);
                    break;
            }
            Console.ReadLine();
        }
    }
}
