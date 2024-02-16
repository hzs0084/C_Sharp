internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of semesters attending the university: ");
        int semesters = int.Parse(Console.ReadLine());
        

        //Convert input to lowercase to handle case-insensitve comparisons

        switch(semesters)
        {
            case int s when s >= 0 && s<= 2:
                Console.WriteLine("7 meals per week for $560 per semester");
                break;
            case int s when s > 2 && s<= 4:
                Console.WriteLine("14 meals per week for $1095 per semester");
                break;
            case int s when s > 4 && s<= 12:
            Console.WriteLine("Unlimited meals per week for $1500 per semester");
            break;

            default:
                Console.WriteLine("Invalid number of semesters");
                break;
        }
        Console.ReadKey(); //Pause the console to see the result
    }

    
}

