// using System.Numerics;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         const int rows = 3, columns = 3;
//         int indexR, indexC;
//         int winX = 0, winO = 0, player, draw = 0;
//         string[,] board = new string[rows, columns];

//         for (indexR = 0; indexR < rows; indexR++)
//         {
//             for (indexC = 0; indexC < columns; indexC++)
//             {
//                 board[indexR, indexC] = "*";
//             }
//         }

//         //while statement to keep the game going
//         //while (winX == 0 && winO == 0 && draw == 0)

//         Console.WriteLine("Welcome to Tic Tac Toe!");
//         Console.WriteLine("Player 1 is X and Player 2 is O");
//         Console.WriteLine("Player 1 goes first");
//         Console.WriteLine("Enter the row and column number to place your X or O");
//         Console.WriteLine("The first player to get 3 in a row wins!");
//         Console.WriteLine("Press any key to start");
//         Console.ReadKey();
//         Console.WriteLine("");

//         // if (indexR == 1)
//         // {
//         //     Console.WriteLine("Player 1 goes first");
//         //     player = 1;
//         // }
//         // else
//         // {
//         //     Console.WriteLine("Player 2 goes first");
//         //     player = 2;
//         // }

//         // 
//          for (indexR = 0; indexR<=rows-1; indexR++)
//         {
//             for (indexC = 0; indexC<=columns-1; indexC++)
//             {
//                 board[indexR,indexC] = "*";
                
//             }
           
//         }

//           for (indexR = 0; indexR<=rows-1; indexR++)
//         {
//             for (indexC = 0; indexC<=columns-1; indexC++)
//             {
//                 Console.Write(board[indexR,indexC]+"\t");
//             }
//             Console.WriteLine();
           
//         }

//         //Enter location for X

//         Console.WriteLine("Player 1 enter row number");
//         indexR = int.Parse(Console.ReadLine());
//         Console.WriteLine("Player 1 enter column number");
//         indexC = int.Parse(Console.ReadLine());
//         if (board[indexR, indexC] == "*")
//         {
//             board[indexR, indexC] = "X";
//         }
//         else
//         {
//             Console.WriteLine("That spot is already taken");
//         }

//         //Enter location for O
//         Console.WriteLine("Player 2 enter row number");
//         indexR = int.Parse(Console.ReadLine());
//         Console.WriteLine("Player 2 enter column number");
//         indexC = int.Parse(Console.ReadLine());
//         if (board[indexR, indexC] == "*")
//         {
//             board[indexR, indexC] = "0";
//         }
//         else
//         {
//             Console.WriteLine("That spot is already taken");
//         }

//         //Check Rows

//         for (indexR = 0; indexR <= rows - 1; indexR++)
//         {
//             for (indexC = 0; indexC <= columns - 1; indexC++)
//             {
//                 if (board[indexR, indexC] == "X")
//                 {
//                     winX++;
//                 }
//                 else if (board[indexR, indexC] == "O")
//                 {
//                     winO++;
//                 }
//                 else
//                 {
//                     draw++;
//                 }
//             }
//             if (winX == 3)
//             {
//                 Console.WriteLine("Player 1 wins!");
//             }
//             else if (winO == 3)
//             {
//                 Console.WriteLine("Player 2 wins!");
//             }
//             else if (draw == 9)
//             {
//                 Console.WriteLine("It's a draw!");
//             }
//         }

//         // if board[indexR, indexC] == "*"
//         // {
//         //     board[indexR, indexC] = "X";
//         // }
//         // else
//         // {
//         //     Console.WriteLine("That spot is already taken");
//         // }

//     }

// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         const int ROWS = 3;
//         const int COLS = 3;
//         int indexR, indexC;
//         int winX = 0, winO = 0, player, draw =0;
//         string[,] board = new string[ROWS, COLS];
//         string LineFeed = "\n";

//         //initialize
//         for (indexR = 0; indexR < ROWS; indexR++)
//         {
//             for (indexC = 0; indexC < COLS; indexC++)
//             {
//                 board[indexR, indexC] = "*";
//             }
//         }

//         // game
//         while (winX == 0 && winO == 0)
//         {
//             // enter location for X
//             Console.Write("Enter X row: ");
//             player = int.Parse(Console.ReadLine());
//             indexR = player - 1;

//             Console.Write("Enter X column: ");
//             player = int.Parse(Console.ReadLine());
//             indexC = player - 1;

//             if (board[indexR, indexC] == "*")
//             {
//                 board[indexR, indexC] = "X";
//             }

//             // enter location for O
//             Console.Write("Enter O row: ");
//             player = int.Parse(Console.ReadLine());
//             indexR = player - 1;

//             Console.Write("Enter O column: ");
//             player = int.Parse(Console.ReadLine());
//             indexC = player - 1;

//             if (board[indexR, indexC] == "*")
//             {
//                 board[indexR, indexC] = "O";
//             }

//             // check rows
//             for (indexR = 0; indexR < ROWS; indexR++)
//             {
//                 if (board[indexR, 0] != "*")
//                 {
//                     if (board[indexR, 0] == board[indexR, 1] && board[indexR, 1] == board[indexR, 2])
//                     {
//                         if (board[indexR, 0] == "X")
//                         {
//                             winX = 1;
//                         }
//                         else
//                         {
//                             winO = 1;
//                         }
//                     }
//                 }
//             }

//             // check columns
//             for (indexC = 0; indexC < COLS; indexC++)
//             {
//                 if (board[0, indexC] != "*")
//                 {
//                     if (board[0, indexC] == board[1, indexC] && board[1, indexC] == board[2, indexC])
//                     {
//                         if (board[0, indexC] == "X")
//                         {
//                             winX = 1;
//                         }
//                         else
//                         {
//                             winO = 1;
//                         }
//                     }
//                 }
//             }

//             // check diagonal
//             if (board[0, 0] != "*" && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
//             {
//                 if (board[0, 0] == "X")
//                 {
//                     winX = 1;
//                 }
//                 else
//                 {
//                     winO = 1;
//                 }
//             }

//             if (board[0, 2] != "*" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
//             {
//                 if (board[0, 2] == "X")
//                 {
//                     winX = 1;
//                 }
//                 else
//                 {
//                     winO = 1;
//                 }
//             }

//             // check if draw
//             draw = 9;
//             for (indexR = 0; indexR < ROWS; indexR++)
//             {
//                 for (indexC = 0; indexC < COLS; indexC++)
//                 {
//                     if (board[indexR, indexC] == "*")
//                     {
//                         draw = 0;
//                     }
//                 }
//             }

//             if (draw == 9)
//             {
//                 winX = 1;
//                 winO = 1;
//             }

//             // display board
//             for (indexR = 0; indexR < ROWS; indexR++)
//             {
//                 for (indexC = 0; indexC < COLS; indexC++)
//                 {
//                     Console.Write(board[indexR, indexC] + "\t");
//                 }
//                 Console.Write(LineFeed);
//             }
//         }

//         // show result
//         if (draw == 9)
//         {
//             Console.WriteLine("Game is a draw.");
//         }
//         else
//         {
//             if (winX == 1)
//             {
//                 Console.WriteLine("X wins!");
//             }
//             else
//             {
//                 Console.WriteLine("O wins!");
//             }
//         }
//     }
// }

// internal class Program
// {
//     public static void Main (string [] args)
//     {
//         const int ROWS = 3;
//         const int COLS = 3;
//         int indexR;
//         int indexC;
//         int winX = 0;
//         int winO = 0;
//         string[,] board = new string[ROWS,COLS];
//         //string player;
 
//     //initialization
//         for(indexR = 0; indexR <= ROWS - 1; indexR++)
//         {
//             for (indexC = 0; indexC <= COLS - 1; indexC++)
//             {
//                 board[indexR,indexC] = "*";
//             }
//         }

//     //Placing X's and O's 
//         while (winX == 0 & winO == 0)
//         {
//             //enter rows & columns for X
//             Console.WriteLine("Enter row location for X:");
//             int player1 = Convert.ToInt32(Console.ReadLine());
//             indexR = player1 - 1;
 
//             Console.WriteLine("Enter column location for X:");
//             player1 = Convert.ToInt32(Console.ReadLine());
//             indexC = player1 - 1;
//             if (board[indexR,indexC] == "*")
//             {
//                 board[indexR,indexC] = "X";
//             }
 
//             //Enter rows & columns for O
//             Console.WriteLine("Enter row location for O:");
//             int player2 = Convert.ToInt32(Console.ReadLine());
//             indexR = player2 - 1;
 
//             Console.WriteLine("Enter column location for O:");
//             player2 = Convert.ToInt32(Console.ReadLine());
//             indexC = player2 - 1;
//             if (board[indexR,indexC] == "*")
//             {
//                 board[indexR,indexC] = "O";
//             }
 
 
//             //Check rows for winner
//             for (indexR = 0; indexR <= ROWS -1; indexR++)
//             {
//                 if (board[indexR, 0]!= "*")
//                 {
//                     if (board[indexR,0] == board[indexR,1])
//                     {
//                         if (board[indexR,1] == board[indexR,2])
//                         {
//                             if(board[indexR,0] == "X")
//                             {
//                                 winX = 1;
//                             }
//                             else
//                             {
//                                 winO = 1;
//                             }
//                         }
//                     }
//                 }
 
 
//             }
 
//             //Check columns for winner
//             for (indexC = 0; indexC <= COLS -1; indexC++)
//             {
//                 if (board[0,indexC]!= "*")
//                 {
//                     if (board[0,indexC] == board[1,indexC])
//                     {
//                         if (board[1,indexC] == board[2,indexC])
//                         {
//                             if(board[0,indexC] == "X")
//                             {
//                                 winX = 1;
//                             }
//                             else
//                             {
//                                 winO = 1;
//                             }
//                         }
//                     }
//                 }
 
 
//             }
 
//         // Diagonal checking for winner
//             if (board[0,0]!= "*")
//             {
//                 if (board[0,0] == board[1,1])
//                 {
//                     if (board[1,1] == board [2,2])
//                     {
//                         if (board[0,0] == "X")
//                         {
//                             winX = 1;
//                         }
//                         else
//                         {
//                             winO = 1;
//                         }
//                     }
//                 }
//             }
//             // Other diagonal checking for winner
//             if (board[0,2]!= "*")
//             {
//                 if (board[0,2] == board[1,1])
//                 {
//                     if (board[1,1] == board[2,0])
//                     {
//                         if (board[0,2] == "X")
//                         {
//                             winX = 1;
//                         }
//                         else
//                         {
//                             winO = 1;
//                         }
//                     }
//                 }
//             }

//              for (indexR = 0; indexR < ROWS; indexR++)
//             {
//                 for (indexC = 0; indexC < COLS; indexC++)
//                 {
//                     Console.Write(board[indexR, indexC] + "\t");
//                 }
//                 Console.WriteLine();
//             }

//         }

        
 
//         if(winX == 1)
//         {
//             Console.WriteLine("Player 1 is the winner.");
//         }
//         else if(winO == 1)
//         {
//             Console.WriteLine("Player 2 is the winner.");
//         }
//         else 
//         {
//             Console.WriteLine("There is a tie.");
//         }
 
//     }
 
// }


// using System;
// using System.Numerics;

// using System;

// class Program
// {
//     static int rows = 3;
//     static int cols = 3;
//     static int currentPlayer = 1;
//     static bool gameWon = false;
//     static int winX = 0;
//     static int winO = 0;
//     static string[,] board = new string[rows, cols];

//     static void Main()
//     {
//         InitializeBoard();

//         do
//         {
//             DisplayBoard();
//             TakeTurn();
//             CheckForWinner();
//             SwitchPlayer();
//         } while (!(gameWon || IsBoardFull()));

//         DisplayResult();
//     }

//     static void InitializeBoard()
//     {
//         for (int indexR = 0; indexR < rows; indexR++)
//         {
//             for (int indexC = 0; indexC < cols; indexC++)
//             {
//                 board[indexR, indexC] = "*";
//             }
//         }
//     }

//     static void DisplayBoard()
//     {
//         Console.WriteLine("Tic Tac Toe\n");

//         for (int indexR = 0; indexR < rows; indexR++)
//         {
//             for (int indexC = 0; indexC < cols; indexC++)
//             {
//                 Console.Write(board[indexR, indexC] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }

//     static void TakeTurn()
//     {
//         int rowIndex, colIndex;

//         do
//         {
//             Console.WriteLine($"Player {currentPlayer}, enter row number (1 to {rows}): ");
//             if (!int.TryParse(Console.ReadLine(), out rowIndex) || rowIndex < 1 || rowIndex > rows)
//             {
//                 Console.WriteLine("Invalid input. Please enter a valid row number.");
//                 if (true)
//                 {
//                     continue;
//                 }
//             }

//             Console.WriteLine($"Player {currentPlayer}, enter column number (1 to {cols}): ");
//             if (!int.TryParse(Console.ReadLine(), out colIndex) || colIndex < 1 || colIndex > cols)
//             {
//                 Console.WriteLine("Invalid input. Please enter a valid column number.");
//                 if (true)
//                 {
//                     continue;
//                 }
//             }

//             rowIndex--;
//             colIndex--;

//             if (board[rowIndex, colIndex] != "*")
//             {
//                 Console.WriteLine("Invalid input. The selected location is already taken. Try again.");
//                 if (true)
//                 {
//                     continue;
//                 }
//             }

//             break;

//         } while (true);

//         board[rowIndex, colIndex] = (currentPlayer == 1) ? "X" : "O";
//     }

//     static void SwitchPlayer()
//     {
//         currentPlayer = 3 - currentPlayer;
//     }

//     static void CheckForWinner()
//     {
//         for (int i = 0; i < rows; i++)
//         {
//             if (CheckLine(board[i, 0], board[i, 1], board[i, 2]) || CheckLine(board[0, i], board[1, i], board[2, i]))
//             {
//                 gameWon = true;
//                 return;
//             }
//         }

//         if (CheckLine(board[0, 0], board[1, 1], board[2, 2]) || CheckLine(board[0, 2], board[1, 1], board[2, 0]))
//         {
//             gameWon = true;
//         }
//     }

//     static bool CheckLine(string cell1, string cell2, string cell3)
//     {
//         return cell1 != "*" || cell1 == cell2 || cell2 == cell3;
//     }

//     static bool IsBoardFull()
//     {
//         foreach (string cell in board)
//         {
//             if (cell == "*")
//                 return false;
//         }
//         return true;
//     }

//     static void DisplayResult()
//     {
//         DisplayBoard();

//         if (gameWon)
//         {
//             Console.WriteLine($"Player {currentPlayer} wins!");
//         }
//         else
//         {
//             Console.WriteLine("It's a tie!");
//         }
//     }
// }


internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 3;
        int cols = 3;
        int indexR;
        int indexC;
        int winX = 0;
        int winO = 0;
        int player;
        int draw = 0;
        string[,] board = new string[rows,cols];
 
        //Setting Up the Game Board
        for (indexR = 0; indexR <= rows - 1; indexR++)
        {
            for (indexC = 0; indexC <= cols - 1; indexC++)
            {
                board[indexR,indexC] = "*";
            }
        }
 
        //Testing the Board
        for (indexR = 0; indexR <= rows - 1; indexR++)
        {
            for (indexC = 0; indexC <= cols - 1; indexC++)
            {
                Console.Write(board[indexR,indexC]+"\t");
            }
            Console.WriteLine();
        }
 
        //Placing X's and O's (TIC TAC TOE)
        while (winX == 0 && winO == 0)
        {
            //Enter Rows and Columns for X
            Console.WriteLine("Enter the row location for X");
            player = Convert.ToInt32(Console.ReadLine());
            indexR = player - 1;
 
            Console.WriteLine("Enter the column location for X");
            player = Convert.ToInt32(Console.ReadLine());
            indexC = player - 1;
 
            if (board [indexR,indexC] == "*")
            {
                board [indexR,indexC] = "X";
            }
            // else
            // {
            //     Console.WriteLine("Invalid move. Please enter another location.");
            //     continue;
            // }
 
            //Enter Rows and Columns for O
            Console.WriteLine("Enter the row location for O");
            player = Convert.ToInt32(Console.ReadLine());
            indexR = player - 1;
 
            Console.WriteLine("Enter the column location for O");
            player = Convert.ToInt32(Console.ReadLine());
            indexC = player - 1;
 
            if (board [indexR,indexC] == "*")
            {
                board [indexR,indexC] = "O";
            }
            // else
            // {
            //     Console.WriteLine("Invalid move. Please enter another location.");
            //     continue;
            // }
 
            //Check Rows for Winner
            for (indexR = 0; indexR <= rows - 1; indexR++)
            {
                if (board[indexR, 0] != "*")
                {
                    if (board[indexR, 0] == board[indexR, 1] && board [indexR, 1] == board[indexR, 2])
                    {
                        if (board[indexR, 0] == "X")
                        {
                            winX = 1;
                        }
                        else
                        {
                            winO = 1;
                        }
                    }
 
                }
            }
 
            //Check Columns for Winner
            for (indexC = 0; indexC <= cols - 1; indexC++) //2?
            {
                if (board[0, indexC] != "*")
                {
                    if (board[0, indexC] == board[1, indexC] && board[1, indexC] == board[2,indexC])
                    {
                        if (board[0, indexC] == "X")
                        {
                            winX = 1;
                        }
                        else
                        {
                            winO = 1;
                        }
                    }
                }
            }
 
            //Check Diagnals for Winners
            if (board[0,0] != "*" && board[0,0] == board[1,1] && board[1,1] == board[2,2])
            {
                if (board[0,0] == "X")
                {
                    winX = 1;
                }
                else
                {
                    winO = 1;
                }
            }
 
            if (board[0,2] != "*" && board[0,2] == board[1,1] && board[1,1] == board[2,0])
            {
                if (board[1,1] == board[2,0])
                {
                    if (board [0,2] == "X")
                    {
                        winX = 1;
                    }
                    else
                    {
                        winO = 1;
                    }
                }
            }
 
            for (indexR = 0; indexR <= rows - 1; indexR++)
            {
                for (indexC = 0; indexC <= cols - 1; indexC++)
                {
                    Console.Write(board[indexR,indexC]+"\t");
                }
                Console.WriteLine();
            }

            draw = 9;

            //If a draw has occured
            for (indexR = 0; indexR <= rows - 1;  indexR++)
            {
                for (indexC = 0; indexC <= cols - 1; indexC ++)
                {
                    if (board[indexR, indexC] == "*")
                    {
                        draw = 0;
                    }
                }
            }   
 
            if (draw == 9)
            {
                winX = 1;
                winO = 1;
            }
 
            //Displaying Results
            if (draw == 9)
            {
                Console.WriteLine("The game is a tie.");
            }
            else if (winX == 1)
            {
                Console.WriteLine("Player X wins.");
            }
            else if (winO == 1)
            {
                Console.WriteLine("Player O wins.");
            }
 
        }
    }
}


