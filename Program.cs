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
            string message = "Некорректное скобочное выражение";            

            while (true)
            {
                int balance = 0;
                int depth = 0;
                int maxDepth = 0;

                Console.WriteLine($"Введите строку с {openingSymbol}{closingSymbol} скобками:");
                line = Console.ReadLine();

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == openingSymbol)
                    {
                        balance++;
                        depth++;
                    }

                    if (line[i] == closingSymbol)
                    {
                        balance--;
                        depth--;
                    }

                    if (balance < 0)
                    {                        
                        i = line.Length;
                    }

                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }

                if (balance == 0)
                {
                    Console.WriteLine($"Корректное скобочное выражение, глубина вложений {maxDepth}");
                }
                else
                {
                    Console.WriteLine($"{message}");
                }
            }
        }
    }
}
