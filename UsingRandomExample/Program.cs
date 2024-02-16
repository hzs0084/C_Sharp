internal class Program
{
    private static void Main(string[] args)
    {
        //Instantiate random number generator and variables
        Random random = new();
        double num1 = random.Next(1, 999);
        double num2 = random.Next(1, 999);

        //call the modules

        displayNum(num1, num2);
        getSum(num1, num2);
        showResults(getSum(num1, num2), getAnswer());
    }
    
    static double getAnswer()
    {
        double answer;
        bool validInput;

        do 
        {
            Console.WriteLine("Enter the sum of the numbers: ");
            string input = Console.ReadLine();
            validInput = double.TryParse(input, out answer);
            if (!validInput)
            {
                Console.WriteLine("Invalid Input. Please try again.");
            }
        }while(!validInput);

        return answer;
    }

    static void showResults(double sum, double answer)
    {
        if (sum == answer)
        {
            Console.WriteLine("Correct Answer. Good Work!");
        }
        else 
        {
            Console.WriteLine($"Incorrect answer. The correct answer is {sum}");
        }
    }

    static double getSum(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }

    static void displayNum(double num1, double num2)
    {
        Console.WriteLine($"The first number is {num1}");
        Console.WriteLine($"The second number is {num2}");
    }

}