internal class Program
{
    //Global Constant Variables
    const double packageCost = 100;
    const double twentyPercent = 0.20;
    const double thirtyPercent = 0.30;
    const double fourtyPercent = 0.40;
    const double fiftyPercent = 0.50;

    //Gets the user input
    static double userInput()
    {
         Console.Write("Please enter the number of packages purchased: ");
         double numberOfPackages = Convert.ToDouble(Console.ReadLine());
         return numberOfPackages;
        // double numberOfPackages = Convert.ToDouble(Console.ReadLine());
        // return numberOfPackages;
        // double discount = packageCost * numberOfPackages;
        // return discount;
    }

     static double dicountClassTwenty()
    {
        //Console.Write("Please enter the number of packages purchased: ");
        double numberOfPackages = userInput();//Convert.ToDouble(Console.ReadLine());
        double discount = packageCost * numberOfPackages - (numberOfPackages * twentyPercent);
        Console.WriteLine("The amount of discount applied to the purchase: 20%");
        Console.WriteLine($"Total Amount: ${discount:F2}");
        return discount;
         
    } 

         static double dicountClassThirty()
    {
        double numberOfPackages = userInput();//Convert.ToDouble(Console.ReadLine());
        double discount = packageCost * numberOfPackages - (numberOfPackages * thirtyPercent);
        Console.WriteLine("The amount of discount applied to the purchase: 30%");
        Console.WriteLine($"Total Amount: ${discount:F2}");
        return discount;
         
    } 

         static double dicountClassFourty()
    {
        double numberOfPackages = userInput();//Convert.ToDouble(Console.ReadLine());
        double discount = packageCost * numberOfPackages - (numberOfPackages * fourtyPercent);
        Console.WriteLine("The amount of discount applied to the purchase: 40%");
        Console.WriteLine($"Total Amount: ${discount:F2}");
        return discount;
         
    } 

         static double dicountClassFifty()
    {
        double numberOfPackages = userInput();//Convert.ToDouble(Console.ReadLine());
        double discount = packageCost * numberOfPackages - (numberOfPackages * fiftyPercent);
        Console.WriteLine("The amount of discount applied to the purchase: 50%");
        Console.WriteLine($"Total Amount: ${discount:F2}");
        return discount;
         
    } 
    //Displays discount that was applied to the purchase
    // static void discount()
    // {
    //     Console.WriteLine("The amount of discount applied to the purchase: ");
    // }


    private static void Main(string[] args)
    {
        
        

        if (userInput() > 9)
        {
            //double totalAmount20 = packagesSold * packageCost - (packageCost * twentyPercent);
            dicountClassTwenty();
        }
        else if (userInput() > 19)
        {
             dicountClassThirty();
        }
        else if (userInput() > 49)
        {
              dicountClassFourty();
        }
        else if (userInput() > 99)
        {
              dicountClassFifty();
        }
        // else if (packagesSold > 100)
        // {
        //     double totalAmount10 = packagesSold * packageCost;    
        // }
        else
        {
            double totalAmount = userInput() * packageCost;
            Console.WriteLine($"Total Amount: ${totalAmount:F2}");
        }
        
         
        
    }
}