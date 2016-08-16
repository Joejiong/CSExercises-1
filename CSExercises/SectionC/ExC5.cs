using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100?99.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("please input a number (100~999)");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsArmstrongNumber(num));
            
        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE

           
            double a = Math.Pow(n % 10, 3);
            double b = Math.Pow(n/10 % 10, 3);
            double c = Math.Pow(n / 100 % 10, 3);

            double sum = a + b + c;
            
            if (sum==n) {
                return true;
            }
            else return false;

        }
    }
}