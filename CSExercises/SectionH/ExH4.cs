namespace CSExercises
{

   
    //Write a static method:  Substitute(string s, char c1, char c2) that would 
    //return a string. The method should find all occurrences of the character c1 
    //in the string s and substitute c1 with character c2.  The new word so formed would 
    //be the return value of this method. 
    public class ExH4
    {
        public static void Main()
        {
            string s1 = "the browb ";
            char c1 = 'b';
            char c2 = 'c';
            
            System.Console.WriteLine(Substitute(s1,c1,c2));

        }
        public static string Substitute(string s, char c1, char c2)
        {
            //YOUR CODE HERE

            char[] cArray1 = s.ToCharArray();
           
            for (int i=0; i<cArray1.Length ;i++) {
                if (cArray1[i]==c1) {
                    cArray1[i] = c2;
                }

            }
            System.Console.WriteLine(cArray1);
            string ss = new string(cArray1);

            return ss; 
        }
    }
}
