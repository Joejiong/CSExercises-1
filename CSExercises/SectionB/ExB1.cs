using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("please input a double precision number !!!");
            Double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the square root of the number is {0}", SQRT(d));
        }

        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            x = System.Math.Sqrt(x);
            return x;

        }
    }
}
