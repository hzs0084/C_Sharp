using System;

using Microsoft.VisualBasic;

 

namespace payCal

{

  class Program

  {

    //Global Constant Varibles

         const int baseHours = 40;

        const double OT_Multi = 1.5;

        static void Main(string[] args)

{

    // Run Modules and store in variables

    int hoursWorked = getHours();

    double payRate = Math.Round(payrateCapture(),2);

   

    //Checking to see hours are greater than 40 if so, run OT module

    if (hoursWorked > baseHours)

    {

        calpayOT(hoursWorked, payRate, OT_Multi);

    }

    else

    {

            calGross(hoursWorked, payRate);

    }

 

    }  

 

    //Get Hours Module

  static int getHours()

        {

            Console.WriteLine("Enter the number of hours worked");

            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            return hoursWorked;

        }

    // Get pay rate module

    static double payrateCapture()

        {

            Console.WriteLine("Enter the hourly pay rate");

            double payRate = Convert.ToDouble(Console.ReadLine());

            return payRate;

        }

    // Calculate

    static void calGross(double baseHours, double hrPay)

        {

           double grossPay = baseHours*hrPay;

           Console.WriteLine($"Gross Pay is:${Math.Round(grossPay,2)}");

           

        }

    static void calpayOT(double hours, double payRate, double OT_Multi)

    {

        double OTHours = hours - baseHours;

        double OTPay = OTHours * payRate * OT_Multi;

        double gross = baseHours * payRate +OTPay;

        Console.WriteLine($"Gross Pay: {gross:F4}");

       

    }

   

  }

       

}