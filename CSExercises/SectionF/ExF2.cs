using System;

namespace CSExercises
{
    //Write a C# program that would sort a numeric array in descending order 
    //using the simplified selection sort method described.

    //At the end of each pass print out the array to know the progress!

    public class ExF2
    {
        public static void Main(string[] args)
        {
            int[] list = new int[] {86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79};

            Sort(list);

            printNums(list);
        
        }

        public static void printNums(int[] list) {
            for (int k = 0; k < list.Length; k++)
            {
                Console.Write(list[k] + " ");
            }
            Console.WriteLine();
        }

        public static void Sort(int[] values)
        {
            //YOUR CODE HERE
            //Sort the list
            int green = 0;
            int red = 0;

            for (green=0;green < values .Length-1 ;green ++) {
                for (red = green +1;red <values .Length  ;red ++) {
                    if (values [green ]<values [red ]) {

                        int temp = values[green];
                        values[green ]= values[red];
                        values[red] = temp;
                    }
                    printNums(values );

                }


            }

        }

    }
}
