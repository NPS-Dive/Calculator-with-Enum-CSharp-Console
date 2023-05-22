using System;

namespace Console_62_CalculatorWithEnum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n---IPBSES.com---\nCalculatorWithEnum\n");

            Console.Write("Enter Second number: ");
            double inputA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second number: ");
            double inputB = Convert.ToDouble(Console.ReadLine());

            while(true)
            {
                Console.Write("Enter operator (Sum for '+' | '-' | 'x' for  multiply| '/' for divide | '+-' for Exit): ");
                String inputOperator = Console.ReadLine();

                switch (inputOperator)
                {
                    case "+":
                        Console.WriteLine("Sum: --> " + Calculator(inputA, inputB, Operators.Sum));
                        break;
                    case "-":
                        Console.WriteLine("Subtract: --> " + Calculator(inputA, inputB, Operators.Subtract));
                        break;
                    case "x":
                        Console.WriteLine("Multiply: --> " + Calculator(inputA, inputB, Operators.Multiply));
                        break;
                    case "/":
                        Console.WriteLine("Divide: -->" + Calculator(inputA, inputB, Operators.Divide));
                        break;
                    case "+-":
                        return;
                }
            }


            Console.ReadKey();
        }

        public enum Operators
        {
            Sum,
            Subtract,
            Multiply,
            Divide
        }

        public static double Calculator(double a, double b, Operators operators)
        {
            double result = 0;

            switch (operators)

            {
                case Operators.Sum:
                    result = a + b;
                    break;
                case Operators.Subtract:
                    result = a - b;
                    break;
                case Operators.Multiply:
                    result = a * b;
                    break;
                case Operators.Divide:
                    result = a / b;
                    break;
            }

            return result;
        }
    }
}