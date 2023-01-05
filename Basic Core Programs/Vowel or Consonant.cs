using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Vowel_or_Consonant
    {
        public void Vowel_Consonant()
        {
            Console.WriteLine("Enter Alphabet");
            Char Alphabet = Console.ReadKey().KeyChar;
            switch(Alphabet)
            {
                case'a':
                    Console.WriteLine("\n" + Alphabet + " is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("\n" + Alphabet + " is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("\n" + Alphabet + " is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("\n" + Alphabet + " is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("\n" + Alphabet + " is Vowel");
                    break;
                default:
                    Console.WriteLine("\n" + Alphabet + " is Consonant");
                    break;
            }
            
        }
    }
}
