using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Business_Cases
{
    class NumToChar
    {
        public static void Main() {
            Console.WriteLine("please input the maney: ");
            string s = Console.ReadLine();
           
            string[] ss = s.Split('.');
            int[] array = new int[2];
            int[] jiWei = new int[2];
            for (int i= 0; i<2;i++) {
                
                array [i] =  Convert.ToInt32(ss[i]);
            }


        }



        public static void Trans(int aNum) {
            bool con = true;
            while (con ) {
                int aNum % 10;


            }
        }
    }
}
