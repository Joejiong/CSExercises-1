using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("input how many miles you have driven !");
            double d = Convert.ToDouble(Console.ReadLine());
            double fare = CalculateFare(d);
            double fare1 = CalculateFare1(d);
            Console.Write("the total fare is {0:$0.0},{1},{2}!", fare,fare,fare1);
        }
           
        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            
            return distance = Math.Round((2.40 + distance * 0.4),1);
         

        }
        public static double CalculateFare1(double distance)
        {
            //YOUR CODE HERE
            return distance = (2.40 + distance * 0.4);


        }
    }
}
