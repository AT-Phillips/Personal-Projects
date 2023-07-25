using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch._6_Exam_Averages_program
{
    class Program
    {
        static void Main(string[] args)
        { string quit = "   ";
            double num1;
            double num2;
            double num3;
            double num4;
            do
            {

                Console.Write("Enter student name: ");
                Console.ReadLine();

                Console.Write("Enter first score: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second score: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter third score: ");
                num3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter fourth score: ");
                num4 = Convert.ToDouble(Console.ReadLine());

                double total = (num1 + num2 + num3 + num4) / 4;


                Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ", num1, num2, num3, num4, total);

                Console.WriteLine("Do you want to quit?");
                quit = Console.ReadLine();

            } while (quit == "N" || quit == "n");

            Console.ReadKey();
        }
    }
}
