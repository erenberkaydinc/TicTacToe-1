using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fieldStates = new string[9];

            // Game Start
            Console.WriteLine("Welcome to tic-tac-toe!");

            Console.WriteLine("What’s the state of the first field: ");
            fieldStates[0] = Console.ReadLine();
            Console.WriteLine("What’s the state of the second field: ");
            fieldStates[1] = Console.ReadLine();
            Console.WriteLine("What’s the state of the third field: ");
            fieldStates[2] = Console.ReadLine();
            Console.WriteLine("What’s the state of the fourth field: ");
            fieldStates[3] = Console.ReadLine();
            Console.WriteLine("What’s the state of the fifth field: ");
            fieldStates[4] = Console.ReadLine();
            Console.WriteLine("What’s the state of the sixth field: ");
            fieldStates[5] = Console.ReadLine();
            Console.WriteLine("What’s the state of the seventh field: ");
            fieldStates[6] = Console.ReadLine();
            Console.WriteLine("What’s the state of the eighth field: ");
            fieldStates[7] = Console.ReadLine();
            Console.WriteLine("What’s the state of the nineth field: ");
            fieldStates[8] = Console.ReadLine();
            
            
            // Output
            Console.WriteLine();
            Console.WriteLine($" {fieldStates[0]} | {fieldStates[1]} | {fieldStates[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {fieldStates[3]} | {fieldStates[4]} | {fieldStates[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {fieldStates[6]} | {fieldStates[7]} | {fieldStates[8]}");
            
            Console.WriteLine();











        }
    }
}
