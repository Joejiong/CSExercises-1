using System;

namespace CSExercises
{
    //Using iteration write a C# program to determine 
    //the square root of a given number (N). If required, 
    //your instructor would explain the method using a numerical example.  
    //Many efficient methods are available; we use a simple one 
    //for demonstrating the looping.

    //STEPS:

    //a.	Take as input the number for finding the square root.
    //b. Take a random number between 1 and N using the function RND.Let the integer be called a Guess, G (not necessarily an integer). 
    //c. If the Guess is correct then G* G should be N.
    //d. If not use the following formula iteratively until G* G approximates to N to an accuracy of 5 decimal places:
    //		G = (G +  N/G) / 2

    //      Input     Output
    //      0	        0.000
    //      25	        5
    //      3	        1.732


    public class ExD4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("the square root of the number N^(1/2) is {0:0.00000} ",SQT(n));
        }

        public static double SQT(double n)
        {
            //YOUR CODE HERE
            Console.Write("Enter a number that you Guass G: ");
            double  G = Convert.ToDouble(Console.ReadLine());
            double  G1 = G * G;
            bool con = true;
            if (G1 == n)
            {
                return G;
            }
            else
            {
                while (con ) {
               
                
                    G = (G + n / G) / 2;
                    double k = (Math.Pow(G, 2) - n);
                    k = Math.Abs(k);
                    if (k <= 0.00001)
                    {
                        con = false;
                       
                    }
                   
                }
                return G;
            }
               
                }
                
            }
        }
    

