using System.Threading;
Console.WriteLine("BACKEND OF TIC TAK TOE");

    // {
    //     char[] board = { '1','2','3','4','5','6','7','8','9' };
    //     char currentPlayer = 'X';
    //     int moves = 0;

    //     while (true)
    //     {
    //         Console.Clear();
    //         PrintBoard(board);

    //         Console.WriteLine($"Player {currentPlayer}, enter position:");
    //         int choice = int.Parse(Console.ReadLine());

    //         if (choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
    //         {
    //             Console.WriteLine("Invalid move! Try again.");
    //             Console.ReadKey();
    //             continue;
    //         }

    //         board[choice - 1] = currentPlayer;
    //         moves++;

    //         if (CheckWin(board, currentPlayer))
    //         {
    //             Console.Clear();
    //             PrintBoard(board);
    //             Console.WriteLine($"Player {currentPlayer} Wins!");
    //             break;
    //         }

    //         if (moves == 9)
    //         {
    //             Console.Clear();
    //             PrintBoard(board);
    //             Console.WriteLine("It's a Draw!");
    //             break;
    //         }

    //         currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    //     }
    // }

    // static void PrintBoard(char[] b)
    // {
    //     Console.WriteLine($"{b[0]} | {b[1]} | {b[2]}");
    //     Console.WriteLine("--+---+--");
    //     Console.WriteLine($"{b[3]} | {b[4]} | {b[5]}");
    //     Console.WriteLine("--+---+--");
    //     Console.WriteLine($"{b[6]} | {b[7]} | {b[8]}");
    //     Console.WriteLine("\n");
    // }

    // static bool CheckWin(char[] b, char p)
    // {
    //     return
    //     (b[0]==p && b[1]==p && b[2]==p) ||
    //     (b[3]==p && b[4]==p && b[5]==p) ||
    //     (b[6]==p && b[7]==p && b[8]==p) ||
    //     (b[0]==p && b[3]==p && b[6]==p) ||
    //     (b[1]==p && b[4]==p && b[7]==p) ||
    //     (b[2]==p && b[5]==p && b[8]==p) ||
    //     (b[0]==p && b[4]==p && b[8]==p) ||
    //     (b[2]==p && b[4]==p && b[6]==p);
    // }
    char [] board={'1','2','3','4','5','6','7','8','9'};
    char currentvalue ='x';
    int choice;
    int move=0;
    while(true)
    { 
        // Console.Clear();
        printboard();
        if(currentvalue=='o')
        {
            Random random = new Random();
            choice = random.Next(1, 10);
            if(choice<1 ||choice > 9 || board[choice-1]=='x'|| board[choice-1]== 'o' )
        {
            Console.WriteLine($"INVAILD MOVE YOU CHEATER {currentvalue}!!!!!");
            choice = random.Next(1, 10);
        }
        }
        else
        {
            Console.Write(" ENTER YOUR  NUMBER :");
          choice =int.Parse(Console.ReadLine());
          if(choice<1 ||choice > 9 || board[choice-1]=='x'|| board[choice-1]== 'o' )
        {
            Console.WriteLine($"INVAILD MOVE YOU CHEATER {currentvalue}!!!!!");
            Console.Write(" AGAIN ,ENTER YOUR  NUMBER :");
          choice =int.Parse(Console.ReadLine());
        
        }
        }
        
        board[choice-1]=currentvalue;
        move++;
        if(currentvalue=='o')
        {
            Console.WriteLine($" YOUR OPPONET CHOSE {choice} .");
        }

        if(move== 9)
        {
            Console.WriteLine("IT'S A DRAW. OHHOHHH HAAAA");
            break;
        }
        if (winner(board,currentvalue))
        {
            Console.WriteLine($"PLAYER {currentvalue} WINS! OHHHHH HAAA OHHHH");
            break;
        }

        currentvalue=(currentvalue =='x')?'o':'x'; 
        Thread.Sleep(1000);
    }
    void printboard( )
        {
           Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
           Console.WriteLine("------------------");
           Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
           Console.WriteLine("------------------");
           Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
        bool winner(char[]b,char p)
        {
           return
        (b[0]==p && b[1]==p && b[2]==p) ||
        (b[3]==p && b[4]==p && b[5]==p) ||
        (b[6]==p && b[7]==p && b[8]==p) ||
        (b[0]==p && b[3]==p && b[6]==p) ||
        (b[1]==p && b[4]==p && b[7]==p) ||
        (b[2]==p && b[5]==p && b[8]==p) ||
        (b[0]==p && b[4]==p && b[8]==p) ||
        (b[2]==p && b[4]==p && b[6]==p);
       
        }


