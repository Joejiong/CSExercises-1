using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {

            //Your code here
            Console.WriteLine("please input how many miles u already ran:");
            double miles = Convert.ToDouble(Console.ReadLine());

            miles = (Math.Ceiling(miles * 10))/10;

            double fare = CalculateFare(miles);
            if (fare == -1)
            {
                Console.WriteLine("**error**");
            }
            else {
                Console.WriteLine(fare);
            }
            

        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE

            if (0<=distance&&distance <= 0.5)
            {
                return 2.40;

            }
            else if (0 <= distance && distance <= 9)
            {
                return 2.40 + (distance * 10 - 85) * 0.04;
            }
            else if (distance > 9)
            {
                return 2.40 + 85 * 0.04 + (distance - 9) * 10 * 0.05;
            }
            else { return -1;
            }



        }
    }
}