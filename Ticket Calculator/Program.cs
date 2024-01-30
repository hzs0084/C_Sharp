internal class Program
{
    private static void Main(string[] args)
    {
        displayCosts(getCostA, getCostB, getCostC);
    }

    static int getCostA()
    {
        Console.Write("How many class A tickets were sold: ");
        int classA = Convert.ToInt32(Console.ReadLine());
        int classAticket = 500;
        int costA = classA * classAticket;
        return costA;
    }

    static int getCostB()
    {
        Console.Write("How many class B tickets were sold: ");
        int classB = Convert.ToInt32(Console.ReadLine());
        int classBticket = 300;
        int costB = classB * classBticket;
        return costB;
    }

    static int getCostC()
    {
        Console.Write("How many class C tickets were sold: ");
        int classC = Convert.ToInt32(Console.ReadLine());
        int classCticket = 150;
        int costC = classC * classCticket;
        return costC;
    }

    // static int calculateCostA(int classA)
    // {
    //     int classAticket = 500;
    //     int costA = classA * classAticket;
    //     return costA;
    // }

    static void displayCosts(Func<int> getCostA, Func<int> getCostB, Func<int> getCostC)
    {
        
        Console.WriteLine("Welcome to the ticket sales program!");
        int classACost = getCostA();
        int classBCost = getCostB();
        int classCCost = getCostC();
        int totalTicketCost = classACost + classBCost + classCCost;
        Console.WriteLine($"Class A ticket costs: $ {classACost:F2}");
        Console.WriteLine($"Class B ticket costs: $ {classBCost:F2}");
        Console.WriteLine($"Class C ticket costs: $ {classCCost:F2}");
        Console.WriteLine($"The total ticket costs are $ {totalTicketCost:F2}");
    }
}

