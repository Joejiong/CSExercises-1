using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("please input the temperature in Centigrade!");
            double c = Convert.ToDouble(Console.ReadLine());
            double F = ConvertToFahrenheit(c);
            Console.WriteLine("the temperature in Fahrenheit is {0} !",F);
        }

        public static double ConvertToFahrenheit(double c)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            
            return 1.8*c + 32;

        }
    }
}
