using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
namespace task02pd
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	List<Enemy>enemies=new List<Enemy>();
            char[,] board = new char[10, 40];
            Player player = new Player('P', 20, 8);
            Enemy enemy1 = new Enemy('e', 2, 2,'l');
            enemies.Add(enemy1);
            Enemy enemy2 = new Enemy('x', 17, 2,'r');
            enemies.Add(enemy2);
            Enemy enemy3 = new Enemy('n', 30, 2,'l');
            enemies.Add(enemy3);
            Thread.Sleep(150);
            string[] boardRows = {
    "#######################################",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#######################################"
};
            for (int i = 0; i < boardRows.Length; i++)
            {
                for (int j = 0; j < boardRows[i].Length; j++)
                {
                    board[i, j] = boardRows[i][j];
                }
            }
            board[player.pY, player.pX] = player.playerchar;
            Console.Clear();
            printboard(board);
            while (true)
            {
                Thread.Sleep(150);
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    player.moveplayerleft(board);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    player.moveplayerright(board);
                }
				for(int i=0;i<enemies.Count;i++)
				{
					enemies[i].enemystrike(board);
				}
                for (int i = 0; i < enemies.Count; i++)
                {
                    enemies[i].moveenemy(board);
                }
                Console.Clear();
                printboard(board);
            }
        }
        static void printboard(char[,] board)
        {
            string print = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    print += board[i, j];
                }
                print += "\n";
            }
            Console.Write(print);
        }
    }
}



