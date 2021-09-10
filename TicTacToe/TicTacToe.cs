using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        public static int OutputState(List<char> TTT)
        {
            int turns = 0;
            foreach (char ch in TTT) {              //count every X and O
                if (ch == 'X' && ch == 'O') { turns++; } }

            if (CheckWin(TTT) == 1 && WhoseTurn(turns) == 1) { Print(2); return 2; }       //X wins
            else if (CheckWin(TTT) == 1 && WhoseTurn(turns) == 2) { Print(3); return 2; }  //O wins
            else if (CheckDraw(TTT) == 1) { Print(4); return 3; } //draw
            return 0;
        }

        //Methods
        private static int CheckDraw(List<char> list)
        {
            if(list.Count ==9)
            { return 1; }
            return 0;
        }

        private static int CheckWin(List<char> T)   //1 means win, 0 means never win
        {
            for (int i = 1; i < 4; i++)
            {
                if ((T[i] == T[i + 3]) && (T[i + 3] == T[i + 6]))
                { //vertical win
                    return 1;
                }
            }
            if ((T[1] == T[2] && T[2] == T[3]) ||
                (T[4] == T[5] && T[5] == T[6]) ||
                (T[7] == T[8] && T[8] == T[9]))
            {      //horizontal win
                return 1;
            }
            if ((T[1] == T[5] && T[5] == T[9]) ||  //diagonal win
                (T[3] == T[5] && T[5] == T[7]))
            {
                return 1;
            }
            return 0;
        }

        public static int WhoseTurn(int num)
        {
            if (num % 2 == 1) { Print(5); return 1; } //player 1=X
            Print(6); return 2; //player 2=O
        }

        public static void Print(int n)
        {
            switch(n)
            {
                case 1: Console.WriteLine("Wait, what?"); break;
                case 2: Console.WriteLine("X wins!"); break;
                case 3: Console.WriteLine("O wins!"); break;
                case 4: Console.WriteLine("Its a draw."); break;
                case 5: Console.WriteLine("X Turn."); break;
                case 6: Console.WriteLine("O Turn."); break;
                case 7: Console.WriteLine("Position is already taken.");
                        Console.WriteLine("Please wait 2 seconds board is loading again.");
                        Thread.Sleep(2000);
                        break;
            }
        }
        public static void DisplayBoard(List<char> TTT)
        {
            Console.WriteLine("    -- -- -- -- -- -- -- -- -- ");
            Console.WriteLine("     {0}   ||   {1}   ||   {2}", TTT[1], TTT[2], TTT[3]);
            Console.WriteLine("    --------------------------");
            Console.WriteLine("     {0}   ||   {1}   ||   {2}", TTT[4], TTT[5], TTT[6]);
            Console.WriteLine("    ---------------------------");
            Console.WriteLine("     {0}   ||   {1}   ||   {2}", TTT[7], TTT[8], TTT[9]);
            Console.WriteLine("    -- -- -- -- -- -- -- -- --");
        }
    }
}

