
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to the Symbol-to-Number Translator app");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please select from the options what you would like to translate");
            Console.WriteLine("1) Symbol-to-Number");
            Console.WriteLine("2) Number-to-Symbol");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if(result == "1")
            {
                Console.Clear();
                SymbolToNum();
                return true;
            } else if(result == "2")
            {
                Console.Clear();
                NumSymbol.NumToSymbol();
                return true;
            }else if(result == "3")
            {
                Console.WriteLine("Goodbye! Restart te application to try again.");
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry! Wrong input.");
                
                return true;
            }
        }

        public static void SymbolToNum()
        {
            Console.WriteLine("SymbolToNum");
            Console.WriteLine("Input \") ( * & ^ % $ # @ !\" with a space in between");
            string result = Console.ReadLine();
            Mapper(result);
        }
        private static string SpecialChars = ")(*&^%$#@!";

        //Lambda Method Query Syntax
        public static void Mapper(string chars)
        {
            var querySyntaxChars = chars.Split().Where(validChar => SpecialChars.Contains(validChar));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------");
            foreach (var item in querySyntaxChars)
            {
                switch (item)
                {
                    case ")": Console.Write("1"); break;
                    case "(": Console.Write("2"); break;
                    case "*": Console.Write("3"); break;
                    case "&": Console.Write("4"); break;
                    case "^": Console.Write("5"); break;
                    case "%": Console.Write("6"); break;
                    case "$": Console.Write("7"); break;
                    case "#": Console.Write("8"); break;
                    case "@": Console.Write("9"); break;
                    case "!": Console.Write("0"); break;
                    default:
                        Console.WriteLine($"{item} is not a special character");
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nPress Enter to go to the main menu!");
            Console.ReadLine();
            Console.Clear();
        }
        
    }
}
