namespace Tic_tac_toe
{
    class Program
    {
     /* 1 | 2 | 3
        4 | 5 | 6
        7 | 8 | 9 */ 
        static void Main()
        {
            Game tictactoe = new();
            int counter = 0;
            tictactoe.Intro();
            while (tictactoe.Win("X") == false || tictactoe.Win("O") == false || counter < 9) 
            {
                var inputOne = tictactoe.askData("X");
                tictactoe.board[inputOne] = "X";
                Console.WriteLine($"You played X on {inputOne + 1}!");
                tictactoe.drawBoard();
                counter++;
                if (tictactoe.Win("X") == true)
                {
                    Console.WriteLine("Congratulation! Player X Won!!");
                    break;
                }
                if (counter == 9)
                {
                    Console.WriteLine("The game was a tie and there were no winners.");
                    break;
                }
                var inputTwo = tictactoe.askData("O");
                tictactoe.board[inputTwo] = "O";
                Console.WriteLine($"You played O on {inputTwo + 1}!");
                tictactoe.drawBoard();
                counter++;
                if (tictactoe.Win("O") == true)
                {
                    Console.WriteLine("Congratulation! Player O Won!!");
                    break;
                }
            }

        }
    }
}
