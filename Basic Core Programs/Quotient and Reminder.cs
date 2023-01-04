using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Quotient_and_Reminder
    {
        public void compute_Quot_Remin()
        {
            Console.WriteLine("Enter Number");
            int Num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divider");
            int Divider=Convert.ToInt32(Console.ReadLine());
            int Quotient, Reminder;
            Quotient = Num / Divider;
            Reminder=Num% Divider;
            Console.WriteLine("Quotient is " + Quotient + " Reminder is " + Reminder);
        }
    }
}
