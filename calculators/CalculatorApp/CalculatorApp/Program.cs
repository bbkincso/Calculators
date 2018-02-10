using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        const string Add = "1";
        const string Subtract = "2";
        const string Multiply = "3";
        const string Divide = "4";
        const string Combination = "5";
        const string Square = "6";
        const string SquareRoot = "7";
        const string Cube = "8";
        const string CubeRoot = "9";
        const string Exponentiate = "10";
        const string Exit = "999";

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tWELCOME TO EASY CALCULATOR\n");
            Console.WriteLine("=============================================\n");

            string userChoice = "0";
            while (!userChoice.Equals(Exit))
            {
                Console.WriteLine(Calculate(userChoice));
                userChoice = DisplayMenu(userChoice);
            }
            Console.WriteLine("Good bye!");
            Console.ReadLine();
        }



        public static string DisplayMenu(string userChoice)
        {
            Console.Write("\tPlease select operation\n!");
            Console.WriteLine("\tAddition\t => 1");
            Console.WriteLine("\tSubtraction\t => 2");
            Console.WriteLine("\tMultiplication\t => 3");
            Console.WriteLine("\tDivision\t => 4");
            Console.WriteLine("\tCombination\t\n\tPermutation => 5");
            Console.WriteLine("\tSquare\t\t => 6");
            Console.WriteLine("\tSquare root\t => 7");
            Console.WriteLine("\tCube\t\t => 8");
            Console.WriteLine("\tCube root\t => 9");
            Console.WriteLine("\tExponentiate\t => 10");
            Console.WriteLine("\tExit\t\t => 999");
            Console.Write("\t");
            userChoice = Console.ReadLine();
            return userChoice;
        }

        public static string Calculate(string userChoice)
        {
            Operations operation = new Operations();
            double num1 = 0;
            double num2 = 0;
            string answer = "";
            try
            {
                switch (userChoice)
                {
                    case Add:
                        Console.Write("\tEnter Addend:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\tEnter Addend:");
                        num2 = double.Parse(Console.ReadLine());
                        answer = "\tThe sum is:" + operation.AddTwoNumbers(num1, num2);
                        break;
                    case Subtract:
                        Console.Write("\tEnter minuend:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\tEnter subtrahend:");
                        num2 = double.Parse(Console.ReadLine());
                        answer = "\tThe difference is:" + operation.SubtractTwoNmbers(num1, num2);
                        break;
                    case Multiply:
                        Console.Write("\tEnter factor:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\tEnter factor:");
                        num2 = double.Parse(Console.ReadLine());
                        answer = "\tThe product is:" + operation.MultipleTwoNmbers(num1, num2);
                        break;
                    case Divide:
                        Console.Write("\tEnter dividend:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\tEnter divisor:");
                        num2 = double.Parse(Console.ReadLine());
                        answer = "\tThe quotient is:" + operation.Divison(num1, num2);
                        break;
                    case Combination:
                        Console.Write("\tEnter the number of items or choices: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\tEnter the number of items to be selected: ");
                        num2 = double.Parse(Console.ReadLine());

                        answer = "The combination of "+num1+" objets taken "+num2+" at a time is equal to "+ operation.Combination(num1, num2)+
                                    "\nThe permutation of "+ num1 +" objets taken "+num2 +" at a time is equal to "+operation.Permutation(num1, num2);
                        break;
                    case Exponentiate:
                        Console.Write("\tEnter base:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\tEnter exponent:");
                        num2 = double.Parse(Console.ReadLine());
                        answer = "\tThe result is:" + operation.Exponentiate(num1, num2);
                        break;
                    case Square:
                        Console.Write("\tEnter base:");
                        num1 = double.Parse(Console.ReadLine());
                        answer = "\tThe square of your number is:" + operation.Square(num1);
                        break;
                    case SquareRoot:
                        Console.Write("\tEnter square:");
                        num1 = double.Parse(Console.ReadLine());
                        answer = "\tThe Square root of your number is:" + operation.SquareRoot(num1);
                        break;
                    case Cube:
                        Console.Write("\tEnter base:");
                        num1 = double.Parse(Console.ReadLine());
                        answer = "\tThe cube of your number is:" + operation.Cube(num1);
                        break;
                    case CubeRoot:
                        Console.Write("\tEnter cube:");
                        num1 = double.Parse(Console.ReadLine());
                        answer = "\tThe cube root of your number is:" + operation.CubeRoot(num1);
                        break;
                    default:
                        answer = "\tInvalid input";
                        break;
                }
            }
            catch 
            {
                answer = "\tInvalid input";
            }

            return answer;
        }
    }
}

