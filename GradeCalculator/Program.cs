using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Numberical Grade :");
            try
            {
                string input = Console.ReadLine();
                double num_grade = double.Parse(input);
                string letter_grade = GradeCalc(num_grade);
                if (letter_grade != "NA")
                {
                    Console.WriteLine("Your Calculated garde is :" + letter_grade.ToString());
                }
                else
                {
                    Console.WriteLine("Entered Numerical Grade is incorrect :" + num_grade.ToString());
                }
            }
            catch
            {
                Console.WriteLine("Entered Numerical Grade is incorrect :");
            }
            Console.WriteLine("Thank you!!...Hit a key to exit");
            Console.ReadKey(true);
        }//end of main
        private static string GradeCalc(double grade)
        {
            if (grade >= 0 && grade < 60)
            {
                return "F";
            }
            else if (grade < 63)
            {
                return "D";
            }
            else if (grade < 67)
            {
                return "D+";
            }
            else if (grade < 70)
            {
                return "C-";
            }
            else if (grade < 74)
            {
                return "C";
            }
            else if (grade < 77)
            {
                return "C+";
            }
            else if (grade < 80)
            {
                return "B-";
            }
            else if (grade < 84)
            {
                return "B";
            }
            else if (grade < 87)
            {
                return "B+";
            }
            else if (grade < 90)
            {
                return "A-";
            }
            else if (grade < 95)
            {
                return "A";
            }
            else if (grade <= 100)
            {
                return "A+";
            }
            else
            {
                return "NA";
            }
        }
    }
}
