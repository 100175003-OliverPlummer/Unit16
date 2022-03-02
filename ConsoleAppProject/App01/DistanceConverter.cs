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
        private double miles;

        private double feet;
        public void run()
        {
            inputMiles();
            CalculateFeet();
            OutputFeet();
        }
        private void inputMiles()
        {
            Console.Write("please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            
        
        }
        private void OutputFeet()
        {

        } 
    }
}
