using System;

namespace CSExercises
{
    //Given a number find out its factorial.  

    //Write two different C# program variations for 
    //the problem:
    //a.Using increment counter
    //b.Using a decrement counter.

    //Carefully study the similarities and differences 
    //between the two approaches.
    //List the conditions, if any, under which your program 
    //is likely to fail

    public class ExE1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            CalculateFactorialInc(n);
            Console.WriteLine("********************************************");
            CalculateFactorialDec(n);
            
        }

        public static void CalculateFactorialInc(int n)
        {
            //YOUR CODE HERE
            
            int k = 1;
            while ( k <= n ) {

         
                if ( n % k == 0)
                {
                    Console.WriteLine("there is a factor :"+k);
                    
                   
                }
                k++;
            }  
           


        }

        public static void CalculateFactorialDec(int n)
        {
            //YOUR CODE HERE

            for (int i = 1; i <=n ;i++) {
                if (n%i==0) {
                    Console.WriteLine("the factor is :"+i);
                }
            }


        }


    }
}
