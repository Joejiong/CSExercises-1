using System;

namespace CSExercises
{
    //Write a program to print all numbers between 1 and 10 with the values 
    //of its inverse, square root and square as below:

    //NO            INVERSE         SQUARE ROOT    SQUARE
    //------------------------------------------------------
    //1.0             1.0             1.0             1.0
    //2.0             0.5             1.414           4.0
    //3.0             0.333           1.732           9.0
    //4.0             0.25            2.0             16.0
    //5.0             0.2             2.236           25.0
    //6.0             0.167           2.449           36.0
    //7.0             0.143           2.646           49.0
    //8.0             0.125           2.828           64.0
    //9.0             0.111           3.0             81.0
    //10.0            0.1             3.162           100.0

    public class ExE2
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine(" //NO            INVERSE         SQUARE ROOT    SQUARE");
            for (int i = 1; i<10 ;i++) {
                double inverse = 1 / i;
                double srtRoot = Math.Sqrt(i);
                double square = Math.Pow(i, 2);
                Console.WriteLine(" //{0:0.0}            {1:0.###}         {2:0.0##}         {3:0.0}",i,inverse, srtRoot,square);


            }
           
        }
    }
}
