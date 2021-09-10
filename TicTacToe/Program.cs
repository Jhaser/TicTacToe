using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        //instantiate and initiate List property
        private static List<char> TTT = new List<char>() 
            {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        private static int flag = 0; //valid, continue
        private static int player = 1;
        private static int index;
        static void Main()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("TicTacToe Game: 2 Player X O");
                Console.WriteLine("Instructions: Input a number to mark X or O on game board.");
                    Console.WriteLine("\n");
                TicTacToe.WhoseTurn(player);
                    Console.WriteLine("\n");
                TicTacToe.DisplayBoard(TTT);
                    Console.WriteLine("\n");

                try {
                    Console.Write("NUMBER: ");
                    index = Convert.ToInt32(Console.ReadLine()); }
                catch {
                    Console.WriteLine("ERROR: Input is invalid. Please enter a NUMBER. "); }

                InputArr(TTT, index);
            } while (flag != 1 && flag != 2 && flag != 3);
            Console.Clear();
            TicTacToe.OutputState(TTT);
        }

        private static void InputArr(List<char> list, int index)
        {
            if (list[index] != 'X' && list[index] != 'O')
            {  //check whether input index is alrd marked
                if (player % 2 == 1)
                { list[index] = 'X';  //player1
                    player++; }
                else
                { list[index] = 'O';
                    player++; } } //player2
            else
            { TicTacToe.Print(7); }
            flag = TicTacToe.OutputState(list);
        }
    }
}
