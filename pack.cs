using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    public class Game
    {
        public string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void Intro() 
        {
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.Write("Press any key to continue. ");
            Console.ReadLine();
        } 
        public bool Win(string player) 
        {
            if (board[0] == player && board[1] == player && board[2] == player)
                return true;
            if (board[3] == player && board[4] == player && board[5] == player)
                return true;
            if (board[6] == player && board[7] == player && board[8] == player)
                return true;
            if (board[0] == player && board[3] == player && board[6] == player)
                return true;
            if (board[1] == player && board[4] == player && board[7] == player)
                return true;
            if (board[2] == player && board[5] == player && board[8] == player)
                return true;
            if (board[0] == player && board[4] == player && board[8] == player)
                return true;
            if (board[2] == player && board[4] == player && board[6] == player)
                return true;
            return false;
        }
        public void drawBoard() 
        {           
             Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");    
             Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
             Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
        public int askData(string player)
        {
            Console.WriteLine($"PLayer: {player}");
            drawBoard();
            Console.Write("Please enter your selection: ");
            bool success = int.TryParse(Console.ReadLine(), out int input);
            while (success != true || input <= 0 || input > 9 || board[input - 1] == "X" || board[input - 1] == "O") 
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine($"PLayer: {player}");
                Console.Write("Please enter your selection: ");
                success = int.TryParse(Console.ReadLine(), out input);
            }
            return input - 1;            
        }   
    }
}
