﻿using System;

namespace CSExercises
{
    //Write a program for the following:
    //a.Declare an array of dimension 10 (index 0… 9). 
    //b.Generate 50 Random integers in the range 0 … 9.
    //c.Store the number of occurrences(count) in the array appropriately.
    //d.Print a table that would list the numbers and the number of occurrences.

    //Addition:
    //-	Try to print an histogram for the above
    //-	How would the program be affected if the range of numbers randomly generated is between -5 and +5?

    // Sample Output
    // Number Count
    //  0		  4
    //  1		  2
    //  2		  8
    //  3		  6
    //  4		  5
    //  5		  5
    //  6		 11
    //  7		  0
    //  8		  3
    //  9		  6

    //Number	
    //  0	****  
    //  1	**
    //  2	********
    //  3	******
    //  4	*****
    //  5	*****
    //  6	***********
    //  7	
    //  8	***
    //  9	******

    public class ExI2
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE


            int[] array = new int[10] {0,0,0,0,0,0,0,0,0,0 };

            Random r = new Random();

            for (int i= 0;i<=50 ;i++) {
                switch (r.Next (1,10)) {
                    case 0:
                        array[0]++;
                        break;
                    case 1:
                        array[1]++;
                        break;
                    case 2:
                        array[2]++;
                        break;
                    case 3:
                        array[3]++;
                        break;
                    case 4:
                        array[4]++;
                        break;
                    case 5:
                        array[5]++;
                        break;
                    case 6:
                        array[6]++;
                        break;
                    case 7:
                        array[7]++;
                        break;
                    case 8:
                        array[8]++;
                        break;
                    case 9:
                        array[9]++;
                        break;
                   
                }
                
            }
            Console.WriteLine("simple");
            Console.WriteLine("number     times");
            for (int j = 0; j <= 9; j++)
            {
                Console.WriteLine("{0}           {1}", j , array[j]);
            }
            Console.WriteLine("number");
            for (int j = 0; j <= 9; j++)
            {
                Console.WriteLine("{0}           {1}", j,printStar(array [j]) );
            }

        }

        public static string printStar(int num) {
            string s = "";
            for (int i=0; i <num;i++) {
                s = s + "*";
            }
            return s;
        }




    }

}
