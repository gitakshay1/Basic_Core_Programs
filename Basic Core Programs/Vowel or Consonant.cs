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
            int alph = 0;
            char[] alpha = { 'a','A','E','e','I','i','o','O','U','u'};
            for(int i=1;i<=alpha.Length;i++)
            {
                if(alpha[i]==Alphabet)
                {
                    alph = 1;
                    break;
                }
            }
            if(alph==1)
            {
                Console.WriteLine("\n"+Alphabet + " is Vowel");
            }
            else
            {
                Console.WriteLine("\n"+Alphabet + " is Consonant");
            }
        }
    }
}
