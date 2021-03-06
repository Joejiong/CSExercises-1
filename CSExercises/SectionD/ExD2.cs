using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.
    
    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input int numberA :");
            int A = Convert.ToInt32(Console.ReadLine ());
            Console.WriteLine("please input int numberB :");
            int B = Convert.ToInt32(Console.ReadLine());
            int hcf = 1;
            int lcm = 1;
            CalculateHCFAndLCM(A,B,ref hcf,ref lcm );
            Console.WriteLine("the HCF of A and B is :{0}\nthe LCM of A and B is :{1}",hcf,lcm );
        }

        public static void CalculateHCFAndLCM(int a, int b,ref int hcf, ref int lcm)
        {
            //YOUR CODE HERE
            int k = a;
            int d = b;
            while (a != b) {
                if (b > a) {
                    int c = a;
                    a = b;
                    b = c;
                }
                a = a - b;
                 hcf = a;
                 lcm = k * d / hcf;
           }
        }
    }
}
