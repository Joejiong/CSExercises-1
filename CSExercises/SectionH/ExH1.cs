namespace CSExercises
{

    public class ExH1
    {
        public static void Main()
        {
            string s1 = "the brown ";
            string s2 = "brob";
            int count = 0;
            System.Console.WriteLine(InString(s1, s2,ref count));
            

        }

        public static bool InString(string s1, string s2, ref int count)
        {
            //YOUR CODE HERE
            char[] c1 = s1.ToLower().ToCharArray();
            char[] c2 = s2.ToLower().ToCharArray();
            bool flag = false;
            count = 0;
            int lenthofc2 = c2.Length;
            for (int i =0;i <c1.Length ;i++) {

                if ((c1[i].CompareTo(c2[0]))==0) {
                    flag = true;
                    count = i;
                   
                    for (int j = 0 ; j<c2.Length;j++) {
                        if ((c1[j+count].CompareTo(c2[j])) != 0) {
                            flag = false;

                        }
                        }
                }
            }

            return flag;




        }
    }
}
