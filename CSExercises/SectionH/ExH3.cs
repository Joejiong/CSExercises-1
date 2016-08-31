using System;
namespace CSExercises
{
    public class ExH3
    {
        public static void Main()
        {
            
            System.Console.WriteLine("please input a number： ");
            int integer = Convert.ToInt32(System.Console.ReadLine());
            string hex = Hex(integer);
            System.Console.WriteLine("the hex form of number is ：{0} ",hex );

        }
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.
        public static string Hex(int i)
        {
            //YOUR CODE HERE
            bool con = true;
            int k = 0;
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            array2[0] = i;
            while (con ) {
                array1[k] = array2[k] % 16;//取出来的数
                array2[k+1] = array2[k] / 16;//商数
                //array1[k] = array2[k] % 16;//取出来的数
                if (array2[k + 1] == 0) {
                    con = false ;
                }
                k++;
            }
            for (int j = 0; j < k; j++) {
                System.Console.Write(array1[j]+"  ");
            }
            string[] ssss = new string[k] ;
             
            System.Console.WriteLine("lol");
            for (int j = 0; j < k; j++)
            { 
                System.Console.Write(array1[j]+" ");
                ssss[j] = array1[k-1-j].ToString();
                //ssss += array1[k-1-j].ToString();
                
            }
            System.Console.WriteLine(ssss+"LOL");


            string s = "";
            for (int j = 0; j < k; j++)
            {
                
                switch (ssss[j])
                {
                    case "10":
                        ssss[j]="A";
                        break;
                    case "11":
                        ssss[j] = "B";
                        break;
                    case "12":
                        ssss[j] = "C";
                        break;
                    case "13":
                        ssss[j] = "D";
                        break;
                    case "14":
                        ssss[j] = "E";
                        break;
                    case "15":
                        ssss[j] = "F";
                        break;

                }
                s += ssss[j];
            }
            
            return s;






        }
    }
}
