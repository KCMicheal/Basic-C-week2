using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMapper
{
    class SymbolNum
    {
        public static bool Application()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome to the Symbol-To-Number Transcriber");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please press these following symbols \"( ) * & ^ % $ # @ !\" and I'll transcribe to number.");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Symbol-to-Number");
            Console.WriteLine("2) Number-to-Symbol");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if(result == "1")
            {
                SymbolToNum();
                return true;
            }
            else if(result == "2")
            {
                NumToSymbol();
                return true;
            }
            else if(result == "3")
            {
                Console.WriteLine("Goodbye! Restart the application to try again.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void SymbolToNum()
        {
            Console.WriteLine("Sym-to-Num");
        }
        public static void NumToSymbol()
        {
            Console.WriteLine("Num-to-Sym");
        }
    }
}
