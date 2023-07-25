using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch._7_Month_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] monthname = new string[12];

            monthname[0] = "January";
            monthname[1] = "February";
            monthname[2] = "March";
            monthname[3] = "April";
            monthname[4] = "May";
            monthname[5] = "June";
            monthname[6] = "July";
            monthname[7] = "August";
            monthname[8] = "September";
            monthname[9] = "October";
            monthname[10] = "November";
            monthname[11] = "December";

            Console.WriteLine("Enter a month number");
            int monthNbr = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine ("The month name is {0}", monthname[monthNbr - 1]);

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();
        }
    }
}
