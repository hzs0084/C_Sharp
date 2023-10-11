// internal class Program
// {

//     //Global constants variables

//     const int baseHours = 40;
//     const double OT_Multi = 1.5;

//     //Get hours module
//     static int getHours()
//     {
//         Console.Write("Enter the number of hours worked: ");
//         int hoursWorked = Convert.ToInt32(Console.ReadLine());
//         return hoursWorked;
//     }

//     //Get pay rate 
//     static double payRateCapture()
//     {
//         Console.Write("Enter the hourly pay rate: ");
//         double payRate = Convert.ToDouble(Console.ReadLine());
//         return payRate;
//     }

//     //Calculations
    
//     // static void calGross(double baseHours, double hrPay)
//     // {
//     //     double grossPay = baseHours * hrPay;
//     //     Console.Write($"Gross Pay is: ${grossPay}");
//     // }
//     static void calGross(double baseHours, double hrPay)
//     {
//         double grossPay = baseHours * hrPay;
//         Console.Write($"Gross Pay is: ${grossPay}");
//     }

//     //Calculates the overtime
//     static void calPayOT(double hours, double payRate, double OT_Multi)
//     {
//         double OTHours = hours - baseHours;
//         //Console.WriteLine("Print" + OTHours);
//         double OTPay = OT_Multi * OTHours * payRate;
//         double gross = baseHours * payRate + OTPay;
//         Console.WriteLine($"Gross Pay: ${gross}");
//     }

    
//     private static void Main(string[] args)
//     {
//         int hoursWorked = getHours();
//         double payRate = payRateCapture();

//         //Check to see if hours are greater than 40, if so then run OT module

//         if (hoursWorked > baseHours)
//         {
//             calPayOT(hoursWorked, payRate, OT_Multi);
//         }
        
//         else
//         {
//             calGross(hoursWorked,payRate);
//         }
    

//     }

    
//}
using System.Security;
internal class Program

{
    //Global constants 
    const double pi = 3.14;
    //Get radius of circle
    static double getRadiusA()
    {
        Console.WriteLine("Enter the radius of Circle A: ");
        double radiusA = Convert.ToDouble(Console.ReadLine());
        return radiusA;
    }   
    static double getRadiusB()
    {
        Console.WriteLine("Enter the radius of Circle B: ");
        double radiusB = Convert.ToDouble(Console.ReadLine());
        return radiusB;
    }

    //Calculation
    static double calCircle_A(double pi, double radiusA)
    {
        double areacalA = pi * Math.Pow(radiusA, 2);
        Console.WriteLine($"Area of Circle A is: {areacalA}");
        return areacalA;
    }
    static double calCircle_B(double pi, double radiusB)
    {
        double areacalB = pi * Math.Pow(radiusB, 2);
        Console.WriteLine($"Area of Circle B is: {areacalB}");
        return areacalB;
    }
    private static void Main(string[] args)
    {
        double areaA = getRadiusA();
        double areaB = getRadiusB();
        if (areaA > areaB)
        {
            calCircle_A(pi, areaA);
            //calCircle_B(pi, areaB);
        }
        else if (areaB > areaA)
        {
            calCircle_B(pi,areaB);
        }
        else
        {
            calCircle_A(pi, areaA);
            calCircle_B(pi, areaB);
            Console.WriteLine("Areas are the same.");
        }
    }

}

// internal class Program
// {
//     //declare const variable
//     const double PI_num = 3.14;

//     static double getcircle1Rad()
//     {
//         Console.WriteLine("Enter the radius of circle 1: ");
//         double rad1 = Convert.ToDouble(Console.ReadLine());
//         return rad1;
//     }
//     static double getcircle2Rad()
//     {
//         Console.WriteLine("Enter the radius of circle 2: ");
//         double rad2 = Convert.ToDouble(Console.ReadLine());
//         return rad2;
//     }

//     //calculate 
//     static void circle1Area(double rad1)
//     {
//         double area1 = rad1 * rad1 * PI_num;
//         Console.WriteLine($"Circle 1 has a greater area of {Math.Round(area1,2)}");
//     }
//     static void circle2Area(double rad2)
//     {
//         double area2 = rad2 * rad2 * PI_num;
//         Console.WriteLine($"Circle 2 has a greater area of {Math.Round(area2,2)}");
//     }
//     private static void Main(string[] args)
//     {
//         double  rad1 = getcircle1Rad();
//         double rad2 = getcircle2Rad();


//         if (rad1 == rad2)
//         {
//            Console.WriteLine("Circle 1 and 2 have the same area.");
//         }


//         else 
//         {
//             circle1Area(rad1);
//             circle2Area(rad2);
//         }
//     }
// }