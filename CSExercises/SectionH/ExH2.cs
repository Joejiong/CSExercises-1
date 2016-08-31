namespace CSExercises
{
    public class ExH2
    {

        public static void Main()
        {
            string s1 = "the brown ";
            string s2 = "bro";
            int count = 0;
            System.Console.WriteLine(FindWord(s1, s2));


        }
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static int FindWord(string s1, string s2)
        {
            //YOUR CODE HERE
            int flag = -1 ;
            int count = 0;
            bool ifExist = ExH1.InString(s1, s2,ref count);
            if (ifExist)
            {
                flag = count;
            }
            else {
                flag = -1;

            }


            return flag ;




        }
    }
}
