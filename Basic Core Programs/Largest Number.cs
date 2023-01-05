using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Largest_Number
    {
        public void LargestNumber()
        {
            Console.WriteLine("Enter First Number");
            int Num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            if(Num1>Num2&&Num1>Num3)
            {
                Console.WriteLine(Num1 + " is Largest Number");
            }
            else if(Num2>Num1 &&Num2>Num3) 
            {
                Console.WriteLine(Num2 + " is Largest Number");
            }
            else
            {
                Console.WriteLine(Num3 + " is Largest Number");
            }
        } 
    }
}
