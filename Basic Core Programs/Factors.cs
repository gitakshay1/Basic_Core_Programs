using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Factors
    {
        public void  Prime_Factors()
        {
            Console.WriteLine("Enter Number to find prime factors ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int factors=Num;
            Console.WriteLine("Prime Factors of " + Num + " are\n");
            for(int i=1; i<=Num/2; i++)
            {
                if(factors%i==0)
                {
                    factors = factors / i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
