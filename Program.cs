using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops1
{
    
    class Program
    {
       static int x = 0;
       static int y = 0;
       static bool gameOver = false;
        static void Main(string[] args)
        {
            Console.WriteLine("BEFORE Loops");
           
            int count = 1;
           
          

            while (gameOver == false)
            {
                Update();
                Draw();
                
            }
           
          
        }
        static void Update()
        {
            ConsoleKeyInfo space = Console.ReadKey(true);
            if (space.KeyChar == 'a')
            {
                x -= 1;

            }
            if (space.KeyChar == 'd')
            {
                x += 1;
            }
            if (space.KeyChar == 'w')
            {
                y -= 1;
            }
            if (space.KeyChar == 's')
            {
                y += 1;
            }
            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }
            if (x == Console.WindowWidth)
            {
                x = Console.WindowWidth - 1;
            }
            if (y == Console.WindowHeight)
            {
                y = Console.WindowHeight - 1;
            }
            if (space.Key == ConsoleKey.Escape)
            {
            
            gameOver = true;
            }
        }
        static void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition( x, y);
            Console.Write("A");
            
        }
    }
}
