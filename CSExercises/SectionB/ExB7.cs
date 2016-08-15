using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            Console.Write("input how many miles you have driven !");
            double d = Convert.ToDouble(Console.ReadLine());
            double fare = CalculateFare(d);
            Console.Write("the total fare is {0:$0.00}!",fare);
          

        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            return distance = 2.40 + distance * 0.4;

        }
    }
}
