using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            string[] s = phrase.Split();
            string[] s2 = phrase.Split();


            for (int i=0; i< s.Length ;i++) {
                s[i] = s[i].ToUpper();
                s[i] = s[i].Substring(0, 1);
                s2[i] = s2[i].Substring(1,s2[i].Length-1);
            }
            string newstring = "";
            for (int i=0; i < s.Length ;i++) {
                newstring = newstring +s[i]+s2[i]+" ";
            }
            newstring = newstring.Substring(0, (newstring.Length - 1));
            return newstring;


        }
    }
}
