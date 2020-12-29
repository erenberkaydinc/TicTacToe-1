using System;

namespace TicTacToe
{
    class Program
    {
        static int rounds = 9;
        static int prefer; 

        static char[] section = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {

            int player = 1;

            do
            {
                Console.Clear();

                Console.WriteLine("PLAYER 1 IS X , PLAYER 2 IS O \n ");
                
                rounds--;

                
                if (player % 2 == 0)
                {
                    Console.WriteLine("PLAYER 2's TURN");

                }
                else
                {
                    Console.WriteLine("PLAYER 1's TURN");
                }
                Console.Write("\n");

                gameBoard();

                prefer = int.Parse(Console.ReadLine());


                if (section[prefer] != 'x' && section[prefer] != 'o')
                {
                    if (player % 2 == 0)
                    {
                        section[prefer] = 'o';

                        player++;
                    }
                    else
                    {
                        section[prefer] = 'x';
                        player++;
                    }
                }

                else
                {
                    Console.WriteLine("ROW {0} is already filled with {1} \n", prefer, section[prefer]);
                    
                    Console.WriteLine("please wait....");

                }


                if (rounds == 0)
                {

                    Console.WriteLine("game over");
                    break;
                }


            } while (rounds > 0);


            Console.WriteLine();
            Console.ReadLine();
        }
        private static void gameBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", section[1], section[2], section[3]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", section[4], section[5], section[6]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", section[7], section[8], section[9]);
        }
    }
}
