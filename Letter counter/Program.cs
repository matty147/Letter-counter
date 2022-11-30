using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Letter_counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            int Howmuch = 0;
            Console.WriteLine("Please enter the character you are looking for");
            char Char = Console.ReadLine()[0];
            Console.WriteLine("Please enter the text where you want to find the charecter");
            string Inlook = Console.ReadLine();
            for (int i = 0; i < Inlook.Length; i++)
            {
            if (Inlook[i] == Char)
                {
                    Howmuch++;
                }
            }
            
            Console.WriteLine(Howmuch);
            Console.ReadKey();
        }
    }
}
