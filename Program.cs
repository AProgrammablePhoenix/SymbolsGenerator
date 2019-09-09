using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace SymbolsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&~\"#'{([|`_\\^@)]}$£¤%!§/:.;,?+/*-=";
            //string[] lowercases = new string[] { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };
            System.Text.StringBuilder syms = new System.Text.StringBuilder(symbols);
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            { 
                Random random = new Random();
                int rand_int = random.Next(symbols.Length);

                Console.Write(syms[rand_int]);

                /*try
                {
                    StreamWriter sw = new StreamWriter("output.txt", true);
                    sw.Write(syms[rand_int]);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }*/

                Thread.Sleep(15);            
            }
        }
    }
}
