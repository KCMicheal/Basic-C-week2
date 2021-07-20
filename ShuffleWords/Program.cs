using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleWords
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Here give me those words in an alphabetical order and i'll shuffle them!");
            string words = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(words))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please type in the words in order!.\nI'm not playing.");
                Console.ForegroundColor = ConsoleColor.White;
                words = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            string[] wordsArray = words.Split();
            try
            {
                var result = Shuffle(wordsArray);
                Console.WriteLine("Here are the random words;");
                foreach (var i in result)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(i + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nThat would be all for now. Restart the console to try again.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        static string[] Shuffle(string[] wordArray)
        {
            Random random = new Random();
            for (int i = wordArray.Length - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                string temp = wordArray[i];
                wordArray[i] = wordArray[swapIndex];
                wordArray[swapIndex] = temp;
            }
            return wordArray;
        }
    }
}
