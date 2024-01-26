using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
                char direction = 'l';
            char[,] board = new char[10, 50];
            Thread.Sleep(150);
            string[] boardRows = {
    "#######################################",
    "#               e                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                                     #",
    "#                  p                  #",
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
            Console.Clear();
                printboard(board);
                while (true)
                {
                    
                    if (Keyboard.IsKeyPressed(Key.LeftArrow))
                    {
                        moveplayerleft(board);
                    }
                    if (Keyboard.IsKeyPressed(Key.RightArrow))
                    {
                        moveplayerright(board);
                    }
                    if (enemystrike(board, direction))
                    {
                        if (direction == 'l')
                            direction = 'r';
                        else if (direction == 'r')
                            direction = 'l';
                    }
                    moveenemy(board, direction);
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
            static void moveplayerright(char[,] board)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (board[i, j] == 'p')
                        {
                            board[i, j] = ' ';
                            if (j < 37)
                            {
                                board[i, j + 1] = 'p';
                            }
                            else
                            {
                                board[i, j] = 'p';
                            }
                            break;
                        }
                    }
                }
            }
            static void moveplayerleft(char[,] board)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (board[i, j] == 'p')
                        {
                            board[i, j] = ' ';
                            if (j > 1)
                            {
                                board[i, j - 1] = 'p';
                            }
                            else
                            {
                                board[i, j] = 'p';
                            }
                            break;
                        }
                    }
                }
            }
            static void moveenemy(char[,] board, char direction)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (board[i, j] == 'e')
                        {
                            board[i, j] = ' ';
                            if (direction == 'l')
                            {
                                board[i, j - 1] = 'e';
                            }
                            else if (direction == 'r')
                            {
                                board[i, j + 1] = 'e';
                            }
                            break;
                        }
                    }
                }
            }
            static bool enemystrike(char[,] board, char direction)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (board[i, j] == 'e')
                        {
                            if (direction == 'l')
                            {
                                if (board[i, j - 1] == ' ')
                                    return false;
                                else
                                    return true;
                            }
                            else if (direction == 'r')
                            {
                                if (board[i, j + 1] == ' ')
                                    return false;
                                else
                                    return true;
                            }
                            break;
                        }
                    }
                }
            return true;
            }


        }
    }
