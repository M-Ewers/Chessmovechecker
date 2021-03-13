using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To do
 * add images to button to make them look like squares 
 * add images to the occupied squares to show what piece is occuping it
 * add multiple pieces to the board
 * have those pieces be able to move to legal spots
 * have two sets of pieces
 * have pieces block each other and remove eachother from board
 */
namespace ChessBoardLogic
{
    class Program
    {
        // creates a new board that is hard coded to only have 8 rows and files
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            //prints out an empty board
            printBoard(myBoard);
            // takes user input and sets it as a rank and a cell
            Cell currentCell = setCurrentCell();
            currentCell.occupied = true;
            Console.WriteLine("Please choose your piece. \nKnight\nBiship\nRook\nQueen\nKing\nPawn");
            string userinputpiece = Console.ReadLine();
            // takes user input and checks if its a valid piece  
            string piece = findChessman(userinputpiece);
            // changes the board and reprints the new state of board
            myBoard.LegalMove(currentCell, piece);            
            printBoard(myBoard);
        }

        private static void printBoard(Board myBoard)
        {
            // formats the board
            for(int i = 0; i<myBoard.size; i++)
            {
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
                for (int j = 0; j < myBoard.size; j++)
                {
                    
                    Cell c = myBoard.theGrid[i, j];
                    
                    if (c.occupied)
                    {                                                
                        Console.Write("| x ");
                    }
                    else if (c.legalMove)
                    {                        
                        Console.Write("| + ");
                    }
                    else
                    {                        
                        Console.Write("|   ");
                    }
                }
                Console.WriteLine("|");
            }
           Console.WriteLine("+---+---+---+---+---+---+---+---+");
              
        }

        private static Cell setCurrentCell()
        {                       
            Console.WriteLine("Enter the current rank number");
            string s = Console.ReadLine();
            int currentRank;
            int currentFile;
            // checks to ensure the user input is valid for the rank and file
            while(!int.TryParse(s, out currentRank) || currentRank < 0 || currentRank > 7)
            {
                Console.WriteLine("Sorry that is not a valid rank");
                s = Console.ReadLine();
            }
            Console.WriteLine("Enter the current file number");
            string others = Console.ReadLine();
            while (!int.TryParse(others, out currentFile) || currentFile < 0 || currentFile > 7)
            {
                Console.WriteLine("Sorry that is not a valid file");
                others = Console.ReadLine();
            }
            // returns the grid that has the new rank and file as occupied 
            myBoard.theGrid[currentRank, currentFile].occupied = true;
            return myBoard.theGrid[currentRank, currentFile];
        }
        private static string findChessman(string chessman)
        {
            // lowers to ensure word structure is consistent and checks to ensures that we recieve a valid chess piece
            chessman = chessman.ToLower();
            if(chessman == "rook" || chessman == "knight" || chessman == "queen" || 
                chessman == "king" || chessman == "pawn" || chessman == "biship")
            {
                return chessman;
            }
            else
            {
                // if a valid input is not met then we use recursion to continue to check 
                Console.WriteLine("That is not a valid piece");
                string s = Console.ReadLine();
                return findChessman(s);
            }
        }
    }
}
