using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Flip_Coin
    {
        public void FlipCoin()
        {
            double Tail_count = 0, Head_Count = 0;
            double Percentage_tail = 0, Percentage_head = 0;
            Console.WriteLine("Enter number of times to flip coin");
            int Flips = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            if(Flips > 0)
            {
                for (int flip = 1; flip <= Flips; flip++)
                {
                    int randmcoin = random.Next(0, 2);
                    if (randmcoin < 0.5)
                    {
                        Tail_count++;
                    }
                    else
                    {
                        Head_Count++;
                    }
                }
                Percentage_tail = Tail_count / Flips* 100;
                Percentage_head = Head_Count / Flips * 100;
                Console.WriteLine("Percentage of Head : " + Percentage_head + "\nPercentage of tail : " + Percentage_tail);
            }
            else
            {
                Console.WriteLine("Enter Positive integer");
            }
            
        }
    }
}
