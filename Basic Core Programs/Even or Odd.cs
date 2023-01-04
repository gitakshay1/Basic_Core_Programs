using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Even_or_Odd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter Number");
            int Num=Convert.ToInt32(Console.ReadLine());
            if(Num%2==0 )
            {
                Console.WriteLine(Num + " is Even Number");
            }
            else
            {
                Console.WriteLine(Num + " is Odd Number");
            }
        }
    }
}
