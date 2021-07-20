using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMapper
{
    class NumSymbol
    {
        public static void NumToSymbol()
        {
            Console.WriteLine("NumToSymbol");
            Console.WriteLine("Input \"1 2 3 4 5 6 7 8 9 0\" with a space in between");
            string result = Console.ReadLine();
            Mapper(result);
        }
        private static string SpecialNums = "1234567890";
        public static void Mapper(string num)
        {
            //Query Method
            var methodSyntaxNums = from sNum in num.Split()
                                    where SpecialNums.Contains(sNum)
                                    select sNum;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------");
            foreach (var item in methodSyntaxNums)
            {
                switch (item)
                {
                    case "1": Console.Write(")"); break;
                    case "2": Console.Write("("); break;
                    case "3": Console.Write("*"); break;
                    case "4": Console.Write("&"); break;
                    case "5": Console.Write("^"); break;
                    case "6": Console.Write("%"); break;
                    case "7": Console.Write("$"); break;
                    case "8": Console.Write("#"); break;
                    case "9": Console.Write("@"); break;
                    case "0": Console.Write("!"); break;
                    default:
                        Console.WriteLine($"{item} is not a number");
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
