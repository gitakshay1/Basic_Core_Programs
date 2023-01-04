using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Swap_Numbers
    {
        public void Swap_Number()
        {
            Console.WriteLine("Enter First Number");    
            int Num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Num2=Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = Num1;
            Num1 = Num2;
            Num2 = temp;
            Console.WriteLine("After Swaping First Number is "+Num1+" Second Number "+Num2);

        }
    }
}
