using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek
{
    class Program
    {
        static void Draw(int x,int y,char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        static void Main(string[] args)
        {
            int x = 1;
            int y = 3;
            char sym1 = '*';
            Draw(x, y, sym1);
            Console.ReadKey();
        }
    }
}
