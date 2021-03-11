using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Draws(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }

        static void Main(string[] args)
        {
            int x1 = 3, y1 = 3;
            char sym1 = '*';

            Draws(x1, y1, sym1);

            int x2 = 4, y2 = 5;
            char sym2 = '*';

            Draws(x2, y2, sym2);

            Console.ReadLine();
        }
    }
}