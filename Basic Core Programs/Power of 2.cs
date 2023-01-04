using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Power_of_2
    {
        public void Pow_of_2()
        {
            Console.WriteLine("Enter Power Value N");
            int N=Convert.ToInt32(Console.ReadLine());
            if((0<=N) &&(N<31))
            {
                for(int n=0;n<=N;n++)
                {
                    Console.WriteLine(Math.Pow(2,n));
                }
            }
            else
            {
                Console.WriteLine("Enter power between 0 to 30");
            }
        }
    }
}
