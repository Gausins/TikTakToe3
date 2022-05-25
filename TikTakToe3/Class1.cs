using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Tema_1_uzdevums

{
    class Game
    {
        static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        static void DrawBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
        }

      
        static void Main(string[] args)
        {
            string name1 = "", name2 = "";
            int choice = 0, turn = 1, score1 = 0, score2 = 0;
            bool winFlag = false, playing = true, correctInput = false;

            Console.WriteLine("Kāds ir tavs vārds - player 1?");
            name1 = Console.ReadLine();
            Console.WriteLine($"Sveiks player1: {name1}!");
            Console.WriteLine("Kāds ir tavs vārds - player 2?");
            name2 = Console.ReadLine();
            Console.WriteLine($"Sveiks player2: {name2}!"); ;
            Console.WriteLine($"Tātad. {name1} ir O un {name2} ir X.");
            Console.WriteLine($" {name1} sāk pirmais.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sākam spēli!");
            Console.WriteLine();
            Console.WriteLine();
            DrawBoard();
            Console.WriteLine("");
        }

    }
}
