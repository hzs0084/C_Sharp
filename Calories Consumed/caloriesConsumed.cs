internal class Program
{
    private static void Main(string[] args)
    {
        // Develop a program that allows the user to enter the number of Oreo cookies eaten.
        // Then calculate the total number of calories consumed and number of servings consumed. 

        // 1 cookie  = 56 calories

        // 2 cookies  = 1 serving

        int oneCookie = 56;

        int oneServing = 2;

        Console.WriteLine("How many number of cookies did you eat?");
        double cookiesConsumed = Convert.ToDouble(Console.ReadLine());

        double totalCalories = cookiesConsumed * oneCookie;

        double totalServings = Convert.ToDouble(cookiesConsumed / oneServing);

        Console.WriteLine($"Here is the number of calories eaten: {totalCalories}");
        Console.WriteLine($"Here are the number of servings eaten: {totalServings}");


    }
}