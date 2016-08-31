using System;

namespace CSExercises
{
    //You are required to take as input an amount (dollar.cents).  
    //Assume that the amount is between 5 cents (inputted as 0.05) and 
    //3 dollars 50 cents (inputted as 3.50).  Further assume that we would 
    //always input nearest to 5 cents (i.e., values like 2.23 are not keyed in).  
    //The duty of your program is to dispense this amount (accurately!) using a combination of 
    //coins.  We have coins of denomination 100, 50, 20, 10 and 5 cents.  More than one coin of 
    //a denomination can be used.  
    //Yeah I know what you are thinking – simply issue all five cent coins; right?  
    //Cannot!- easy but no challenge.  
    //We are requesting the program to use the “minimum number of coins” principle.  
    //For example, if a request were made for 1.95 then the computer would issue one 100-cent coin, 
    //one 50-cent coin, two 20-cent coins and one 5-cent coin.  

    //The trick is to always start with the largest denomination and slowly go down.  
    //Try your luck – but don’t loose money!  

    public class ExI1
    {

       
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount which is between (0.05-3.50): ");
            double amount = Convert.ToDouble(Console.ReadLine());
            int  theNum = (int )(amount * 100);
          
            //YOUR CODE HERE
            int[] coins = new int[6] { 100, 50, 20, 10, 5, 0 };

            //int[] x = new int[5] { 0, 0, 0, 0, 0 };




            //int j = 0;

            //Console.Write(findPosition (coins ,theNum ));

            while (theNum>1)
            {

                int index = findPosition(coins, theNum);
                Console.WriteLine(index);
                theNum = jianDiao(coins, theNum, index);
                Console.WriteLine(theNum);
                
            }
            //for (int j = 0; j < x.Length; j++)
            //{
            //    Console.Write(x[j] + "  ");
            //}

        }
        public static int jianDiao(int[] coins,int theNum,int post) {

            theNum = theNum - coins[post];

            return theNum ;
        }

        public static int findPosition(int[] coins,int theNum) {
            int index = 0;
            //100, 50, 20, 10, 5
            for (int i =0;i<coins.Length ; i++) {
                if (theNum <coins [i]) {
                    index = i+1;
                    
                }
            }

            return index;

        }
    }
}
