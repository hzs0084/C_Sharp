using System;

namespace ezFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input for the integers
            
            Console.WriteLine("Enter the first number.");
            double num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the second number.");
            double num2 = Convert.ToInt32(Console.ReadLine());

            //Call the method for output
            double answer = Divide(num1, num2);
            Console.WriteLine(answer);

        }

        //This method multiplies the integers
        static double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }
    }
}