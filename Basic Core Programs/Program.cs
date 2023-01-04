namespace Basic_Core_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the Program\n1 Flip Coin\n2 Leap Year\n3 Power Of 2" +
                "\n4 Harmonic Number\n5 Prime Factors\n6 Quotient and Reminder\n7 Swap Numbers" +
                "\n8 Even Or Odd");
            int Choise=Convert.ToInt32(Console.ReadLine());
            switch(Choise)
            {
                case 1:
                    Flip_Coin basic = new Flip_Coin();
                    basic.FlipCoin();
                    break;
                case 2:
                    Leap_Year leap_Year=new Leap_Year();
                    leap_Year.LeapYear();
                    break;
                case 3:
                    Power_of_2 power_Of_2=new Power_of_2();
                    power_Of_2.Pow_of_2();
                    break;
                case 4:
                    Harmonic_Number harmonic_Number=new Harmonic_Number();
                    harmonic_Number.HarmonicNumber();
                    break;
                case 5:
                    Factors factors=new Factors();
                    factors.Prime_Factors();
                    break;
                case 6:
                    Quotient_and_Reminder compute=new Quotient_and_Reminder();
                    compute.compute_Quot_Remin();
                    break;
                case 7:
                    Swap_Numbers swap_Numbers=new Swap_Numbers();
                    swap_Numbers.Swap_Number();
                    break;
                case 8:
                    Even_or_Odd even_Or_Odd=new Even_or_Odd();
                    even_Or_Odd.EvenOrOdd();
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;

            }
        }
    }
}
