using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Operations
    {
        //Returns the sum of two numbers
        public double AddTwoNumbers(double num1, double num2)
        {
           double result = num1 + num2;
            return result;
        }

        //Returns the difference of two numbers
        public double SubtractTwoNmbers(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        //Returns the product of two numbers
        public double MultipleTwoNmbers(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        //Returns the quotient of two numbers
        public double Divison(double num1, double num2)
        {
            double result = 0;
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by 0 is not allowed");
            }
            return result;

        }

        //Returns the factorial of two numbers
        public double Factorial(double num1)
        {
            double total = 1;
            for(int i=1; i<= num1; i++)
            {
                total *= i;
            }
            return total;
        }

        //Returns the combination of given numbers of objets at a given time.
        public double Combination(double n,double r)
        {
            double result = Factorial(n)/(Factorial(n-r)*Factorial(r));
            return result;

        }

        //Returns the permutation of given numbers of objets at a given time.
        public double Permutation(double n, double r)
        {
            double result = Factorial(n) / Factorial(n - r);
            return result;
        }

        //Returns the square of two numbers
        public double Square(double num)
        {
            double result = num * num;
            return result;
        }

        //Returns the SquareRoot of two numbers
        public double SquareRoot(double num)
        {
            double result = Math.Sqrt(num);
            return result;
        }

        //Returns the Cube of two numbers
        public double Cube(double num)
        {
            double result = num * num * num;
            return result;
        }

        //Returns the CubeRoot of two numbers
        public double CubeRoot(double num)
        {
            double result = Math.Pow(num, (1.0 / 3.0));
            return result;
        }

        //Returns the Exponentiate of two numbers
        public double Exponentiate(double numBase, double numExponent)
        {
            //return Math.Pow(numBase, numExponent);

            double result = numBase;
            for (int i = 1; i < numExponent; i++)
            {
                result = result * numBase;
            }
            return result;
        }
    }
}
