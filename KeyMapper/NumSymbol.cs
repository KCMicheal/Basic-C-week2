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
            int result = Convert.ToInt32(Console.ReadLine());
            Mapper(result);
        }
        private static int SpecialChars = ")(*&^%$#@!";
        public static void Mapper(int num)
        {

            var methodSyntaxChars = from sChar in chars.Split()
                                    where SpecialChars.Contains(sChar)
                                    select sChar;

            Console.WriteLine();
            Console.WriteLine("Method syntax Output: ");
            foreach (var item in methodSyntaxChars)
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
        }
    }
}
