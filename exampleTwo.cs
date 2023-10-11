//Varibles for the Circumference formula

const double pi = 3.14;
//double diameter;
string diameterPrompt = "Enter the diameter for the circle: ";
//double circumference;

//Capture Diameter inputed

Console.WriteLine(diameterPrompt);
double diameter = Convert.ToDouble(Console.ReadLine());

//Perform Calculations

double circumference = pi * diameter;

//Output Caculations
Console.WriteLine("Here is the circumference of your circle: " + circumference);
// Console.WriteLine(circumference);