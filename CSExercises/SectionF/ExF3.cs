using System;
using System.Threading;

namespace CSExercises
{
    //The marks of students are stored in a two dimensional array with 
    //the subjects represented in columns and the students in the rows. 
    //That is Row 1 would pertain to Student 1 and the scores that this student 
    //has obtained is stored in various columns in row 1.  Assuming that there are 
    //12 students in a class and 4 subjects, write a program that would do the following:
    //  a.Compute the total marks obtained each student.
    //  b.Compute the class average and standard deviation* of Marks for each subject.
    //  c.Determine the overall average of marks for the whole class for each subjects.

    //Note:   
    //calculation of standard deviation is not required for first time exercise 
    //you may only compute the average – those needing additional practice 
    //may compute standard deviation)

    //Standard Deviation is square root of variance where Variance is given by:
    //	VARIANCE = { [SUM OF(Xi - M)2] / N }; i = 1 to N
    //      N is number of data elements(Xi) and
    //      M is mean(average). 

    public class ExF3
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[,]
            {
                {56,84,68,29},
                {94,73,31,96},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };

            int[] total = CalculateTotalMarks(marks);
            double[] avg = CalculateStudentAverage(marks);
            double[] avgPerSubject = CalculateSubjectAverage(marks);


            for (int row = 0; row < 12; row++)
            {
                Console.WriteLine("Total marks for student {0}: {1}", row + 1, total[row]);
                Console.WriteLine("Avg marks for student {0}: {1:0.00}", row + 1, avg[row]);
            }

            for (int col = 0; col < 4; col++)
            {
                Console.WriteLine("Avg marks for subject {0}: {1:0.00}", col + 1, avgPerSubject[col]);
            }
            double[] standardVarience = ExF3.CalculateVariance(marks);
            for (int col = 0; col < 4; col++)
            {
                Console.WriteLine("the standard varience for subject {0}: {1:0.00}", col + 1, standardVarience[col]);
            }
        }
        

        public static int[] CalculateTotalMarks(int[,] marks)
        {

            int[] total = new int[12];

            //YOUR CODE HERE
            for (int i = 0; i<marks .GetLength (0);i++) {
                for (int j = 0; j<marks.GetLength(1);j++) {
                    total[i] += marks[i,j];
                }
            }

            return total;


        }

        public static double[] CalculateStudentAverage(int[,] marks)
        {
           

            double[] avgPerStuent = new double[12];
            int[] sum = new int[12];
            //YOUR CODE HERE

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        sum[i] = sum[i] + marks[i, j];

            //    }
            //}
            sum= CalculateTotalMarks(marks );
            for (int i = 0; i < 12; i++)
            {
                avgPerStuent[i] = sum[i] / 4;
            }

            return avgPerStuent;

        }

        public static double[] CalculateSubjectAverage(int[,] marks)
        {
            double[] avg = new double[12];
            double[] sum = new double[12];
            //YOUR CODE HERE
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    sum[j] = sum[j] + marks[i, j];

                }
            }
            for (int j = 0; j < 4; j++)
            {
                avg[j] = sum[j] / 12;
            }
            return avg;





        }

        public static double[] CalculateVariance(int[,] marks)
        {
            double[] variance = new double[4];
            //YOUR CODE HERE - bonus questions
            double[] sumOfStudent = new double[12];
            double[] avgOfSubject = CalculateSubjectAverage(marks );

            avgOfSubject = CalculateSubjectAverage(marks );
            for (int i = 0; i<marks .GetLength (0);i++) {
                for (int j = 0; j <marks .GetLength (1);j++) {
                    sumOfStudent [j] += Math.Pow((marks[i, j] - avgOfSubject[j]), 2);
                }
                 
            }
            for (int i= 0;i<4 ;i++) {
                variance[i] = sumOfStudent[i] / 12;

            }
            //Standard Deviation is square root of variance where Variance is given by:
            //	VARIANCE = { [SUM OF(Xi - M)2] / N }; i = 1 to N
            //      N is number of data elements(Xi) and
            //      M is mean(average). 



            return variance;
        }
    }
}
