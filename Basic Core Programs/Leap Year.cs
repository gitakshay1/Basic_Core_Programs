using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Leap_Year
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter the Year");
            int Year = Convert.ToInt32(Console.ReadLine());
            if((Year%4== 0)&&(Year%100!=0)||(Year%400==0) )
            {
                Console.WriteLine(Year + " is Leap Year");
            }
            else
            {
                Console.WriteLine(Year + " is Leap not Year");
            }
        }
    }
}
