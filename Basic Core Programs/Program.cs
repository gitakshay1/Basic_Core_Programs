namespace Basic_Core_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the Program\n1 Flip Coin\n2 Leap Year\n3 Power Of 2");
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
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;

            }
        }
    }
}
