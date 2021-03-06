using System;

namespace CSExercises
{
    //Guess the Number Game: Write a C# program that would 
    //let you guess the number that the computer has in 
    //its “mind”.  Computer thinks of an integer between 0 and 9.

    //a.The program uses the random number function to first 
    //“think of” a number.It should then prompt you for a guess.  
    //If your guess is correct, then it would congratulate you 
    //and tell out how many attempts that you took to make the guess.  

    //b.Modify the program you wrote in 23(a) so that in addition 
    //to the basic guessing function, it would also say 
    //“You are a Wizard!” if you succeed in the first two attempts 
    //or say “You are a good guess” if you make it next three attempts 
    //else it would say “You are lousy!”  Every time you make a wrong guess, 
    //the program would prompt “Try again” and accept another guess.
    //The program repeats until you have made the correct guess.

    public class ExD3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Random r = new Random();
            int scNum = r.Next(1,10);
            Console.WriteLine("please input the number that you guess!(0~9)");
            int uNum ;
            int flag = 0;

            bool canNot = true;
            while (canNot) {
                uNum = Convert.ToInt32(Console.ReadLine());
                if (scNum == uNum)
                {
                    canNot = false;
                    Console.WriteLine("congratulate!");
                    flag++;
                }
                else {
                    flag++;
                    Console.WriteLine("try again!!");
                }
                Console.WriteLine("you have tried "+flag+" times");
                
            }


            if (flag < 3)
            {
                Console.WriteLine("You are a Wizard!");

            }
            else if (flag <= 5)
            {
                Console.WriteLine("You are a good guess");
            }
            else
            {
                Console.WriteLine("You are lousy!");
            }

        }
    }
}
