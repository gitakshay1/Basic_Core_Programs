﻿namespace Basic_Core_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the Program\n1 Flip Coin");
            int Choise=Convert.ToInt32(Console.ReadLine());
            switch(Choise)
            {
                case 1:
                    Flip_Coin basic = new Flip_Coin();
                    basic.FlipCoin();
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;

            }
        }
    }
}
