using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations for which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("please input you triangle's three sides");
            double a = Convert .ToDouble (System.Console .ReadLine());
            double b = Convert.ToDouble(System.Console.ReadLine());
            double c = Convert.ToDouble(System.Console.ReadLine());
            double AREA = CalculateArea(a,b,c);
            Console.WriteLine("the area of the triangle is :{0}",AREA);
        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double s = (a + b + c) / 2;

            return System.Math.Sqrt(s*(s - a)*(s - b)*(s - c));
        }
    }
}