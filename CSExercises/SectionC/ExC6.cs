using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            Console.WriteLine("please input how many tv:");
            Console.WriteLine("please input how many DVD:");
            Console.WriteLine("please input how many Mp3:");

            int tvQ, tDQ, mp3Q;
            tvQ = Convert.ToInt32(Console.ReadLine ());
            tDQ = Convert.ToInt32(Console.ReadLine());
            mp3Q = Convert.ToInt32(Console.ReadLine());
           double totalPrice = CalculateTotalPrice(tvQ, tDQ, mp3Q);
            Console.WriteLine("price is {0}", totalPrice);
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double total = tvQty * 900 + dvdQty * 500 + mp3Qty * 700;
            int amount = tvQty + dvdQty + mp3Qty;
            if (total >= 5000 && total < 10000)
            {
                return total = tvQty * 900 + dvdQty * 500 + mp3Qty * 700;
            }
            else if (total >= 10000)
            {
                return total * 0.85;
            }
            else { return -1;
            }

            



        }
    }
}