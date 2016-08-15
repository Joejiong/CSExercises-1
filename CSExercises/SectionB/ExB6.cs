using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("please input A(x1,y1) :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please input B(x2,y2) :");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double l = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine(" the distance between A and B is : {0:0.00} !", l);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            return Math.Sqrt (Math.Pow ((x1-x2),2)+Math.Pow((y1-y2),2));
        }
    }
}
