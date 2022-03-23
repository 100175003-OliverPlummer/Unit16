using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// to be able to convert distance  
    /// </summary>
    /// <author>
    ///oliver plummer 
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;
        public void run()
        {
            OutputHeading();
            inputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("   convert Miles to Feet");
            Console.WriteLine(     "by Oliver Plummer");
            Console.WriteLine("------------------------------\n");
        }

        private void inputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280; 
        
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is" + feet + "feet!");
        } 
    }
}
