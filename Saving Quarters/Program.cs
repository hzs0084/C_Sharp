internal class Program
{
    private static void Main(string[] args)
    {
        calculateQuarters(getDays);
    }


    //Get the user input for the number of days to measure the amount of pennies saved
    static int getDays()
    {
        int numOfDays;
        bool validInputDays;
        do
        {
            Console.Write("Enter the number of days to measure the amount of pennies saved: ");
            string input = Console.ReadLine();
            validInputDays = int.TryParse(input, out numOfDays);
            //Checking for integer input
            if (!validInputDays || numOfDays < 1 || numOfDays > 3)

            {
                Console.WriteLine("Invalid input. Please try again.");
                validInputDays = false;
            }
        } while (!validInputDays);

        return numOfDays;
            
    }

    static void calculateQuarters(Func<int> getDays)
    {
        int days = getDays();
        double oneQuarter = 0.25;
        double totalQuarters = oneQuarter;

        Console.WriteLine("Day \t Amount");
        Console.WriteLine("-------------------");

        for (int i = 1; i <= days; i++)
        {
            Console.WriteLine($"{i}\t {totalQuarters:F2}");
            totalQuarters *= 2;
        }

    }

}