internal class Program
{
    private static void Main(string[] args)
    {
        int count, minimum, maximum;
        getNumber(out count, out minimum, out maximum);
        results(count, minimum, maximum);
    }

    static void getNumber(out int count, out int minimum, out int maximum)
    {
        int num;

        bool validInputNum;
        count = -1;
        minimum = 0;
        maximum = 0;

        do 
        {
            do
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();
                validInputNum = int.TryParse(input, out num);
                if(!validInputNum)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                    validInputNum = false;
                }
            }while(!validInputNum);

            if(num != -99)
            {
                if (count ==0)
                {
                    minimum = num;
                    maximum = num;
                }
                else 
                {
                    if(num < minimum)
                    {
                        minimum = num;
                    }
                    if(num > maximum)
                    {
                        maximum = num;
                    }
                }

            } count++;
        }while (num != -99);

    }

    static void results(int count, int minimum, int maximum)
    {
        Console.WriteLine($"Here is the actual count: {count}");
        Console.WriteLine($"Here is the minimun: {minimum}");
        Console.WriteLine($"Here is the maximum: {maximum}");
    }

}