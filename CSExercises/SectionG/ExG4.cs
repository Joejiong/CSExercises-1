using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            int[] Marks = {63,29,75,82,55 };
            string[] names = {"John","Venkat","Mary","Victor","Betty" };
            Console.WriteLine("The marks obtained by five students in Programming course are as below:");
            Console.WriteLine("Name\t\t        Mark");
            for (int i= 0; i<=names.Length-1; i++) {
                names[i] = names[i].PadRight(10,' ');
            }

            for (int i = 0; i <= names.Length - 1; i++)
            {
                Console.WriteLine("{0}\t\t{1}",names[i],Marks[i] );
            }
            for (int i = 0; i <= names.Length - 1; i++)
            {
                Console.WriteLine("{0}\t\t{1}", names[i], Marks[i]);
            }



        }
    }
}
