using System;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char openingSymbol = '(';
            char closingSymbol = ')';
            string line;
            string message = "корректное скобочное выражение";
                        
            int depth = 0;
            int maxDepth = 0;

            Console.WriteLine($"Введите строку с {openingSymbol}{closingSymbol} скобками:");
            line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == openingSymbol)
                {
                    depth++;                    
                }
                else if (line[i] == closingSymbol)
                {
                    depth--;                    
                }

                if (depth < 0)
                {                    
                    break;
                }

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }

            if (depth == 0)
            {
                Console.WriteLine($"{message}, глубина вложений {maxDepth}");
            }
            else
            {
                Console.WriteLine($"Не{message}");
            }
        }
    }
}
