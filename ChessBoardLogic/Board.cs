using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardLogic
{
    public class Board
    {
        public int size { get; set;}
        public Cell[,] theGrid { get; set; } 

        public Board (int s)
        {
            // creates a board that is a series of cells
            size = s;
            theGrid = new Cell[size, size];
            for(int i = 0; i < size; i++)
            {
                for( int j =0; j <size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void LegalMove(Cell currentCell, string chessman)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // clears the board
                    theGrid[i, j].legalMove = false;
                    theGrid[i, j].occupied = false;
                }
            }
            // lowers string to ensure we can always enter the switch
            chessman = chessman.ToLower();
            // uses a switch to find a piece in question and maps out there legal moves
            switch (chessman)
            {
                case "knight":
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber + 1))                    
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber + 1].legalMove = true;                    
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber - 1))                   
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber - 1].legalMove = true;                    
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber + 1))                    
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber + 1].legalMove = true;                    
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber - 1))                    
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber - 1].legalMove = true;                    
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber + 2))                    
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber + 2].legalMove = true;                    
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber - 2))                    
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber - 2].legalMove = true;                    
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber + 2))                    
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber + 2].legalMove = true;                    
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber - 2))                    
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber - 2].legalMove = true;                                  
                    break;
                
                case "biship":
                    //moving left and up 
                    if(Safe(currentCell.rankNumber + 1, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber + 2))
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber + 2].legalMove = true;
                    if (Safe(currentCell.rankNumber + 3, currentCell.fileNumber + 3))
                        theGrid[currentCell.rankNumber + 3, currentCell.fileNumber + 3].legalMove = true;
                    if (Safe(currentCell.rankNumber + 4, currentCell.fileNumber + 4))
                        theGrid[currentCell.rankNumber + 4, currentCell.fileNumber + 4].legalMove = true;
                    if (Safe(currentCell.rankNumber + 5, currentCell.fileNumber + 5))
                        theGrid[currentCell.rankNumber + 5, currentCell.fileNumber + 5].legalMove = true;
                    if (Safe(currentCell.rankNumber + 6, currentCell.fileNumber + 6))
                        theGrid[currentCell.rankNumber + 6, currentCell.fileNumber + 6].legalMove = true;
                    if (Safe(currentCell.rankNumber + 7, currentCell.fileNumber + 7))
                        theGrid[currentCell.rankNumber + 7, currentCell.fileNumber + 7].legalMove = true;
                    //moving right and up
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber - 2))
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber - 2].legalMove = true;
                    if (Safe(currentCell.rankNumber + 3, currentCell.fileNumber - 3))
                        theGrid[currentCell.rankNumber + 3, currentCell.fileNumber - 3].legalMove = true;
                    if (Safe(currentCell.rankNumber + 4, currentCell.fileNumber - 4))
                        theGrid[currentCell.rankNumber + 4, currentCell.fileNumber - 4].legalMove = true;
                    if (Safe(currentCell.rankNumber + 5, currentCell.fileNumber - 5))
                        theGrid[currentCell.rankNumber + 5, currentCell.fileNumber - 5].legalMove = true;
                    if (Safe(currentCell.rankNumber + 6, currentCell.fileNumber - 6))
                        theGrid[currentCell.rankNumber + 6, currentCell.fileNumber - 6].legalMove = true;
                    if (Safe(currentCell.rankNumber + 7, currentCell.fileNumber - 7))
                        theGrid[currentCell.rankNumber + 7, currentCell.fileNumber - 7].legalMove = true;
                    // moving left and down
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber + 2))
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber + 2].legalMove = true;
                    if (Safe(currentCell.rankNumber - 3, currentCell.fileNumber + 3))
                        theGrid[currentCell.rankNumber - 3, currentCell.fileNumber + 3].legalMove = true;
                    if (Safe(currentCell.rankNumber - 4, currentCell.fileNumber + 4))
                        theGrid[currentCell.rankNumber - 4, currentCell.fileNumber + 4].legalMove = true;
                    if (Safe(currentCell.rankNumber - 5, currentCell.fileNumber + 5))
                        theGrid[currentCell.rankNumber - 5, currentCell.fileNumber + 5].legalMove = true;
                    if (Safe(currentCell.rankNumber - 6, currentCell.fileNumber + 6))
                        theGrid[currentCell.rankNumber - 6, currentCell.fileNumber + 6].legalMove = true;
                    if (Safe(currentCell.rankNumber - 7, currentCell.fileNumber + 7))
                        theGrid[currentCell.rankNumber - 7, currentCell.fileNumber + 7].legalMove = true;
                    //moving right and down
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber - 2))
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber - 2].legalMove = true;
                    if (Safe(currentCell.rankNumber - 3, currentCell.fileNumber - 3))
                        theGrid[currentCell.rankNumber - 3, currentCell.fileNumber - 3].legalMove = true;
                    if (Safe(currentCell.rankNumber - 4, currentCell.fileNumber - 4))
                        theGrid[currentCell.rankNumber - 4, currentCell.fileNumber - 4].legalMove = true;
                    if (Safe(currentCell.rankNumber - 5, currentCell.fileNumber - 5))
                        theGrid[currentCell.rankNumber - 5, currentCell.fileNumber - 5].legalMove = true;
                    if (Safe(currentCell.rankNumber - 6, currentCell.fileNumber - 6))
                        theGrid[currentCell.rankNumber - 6, currentCell.fileNumber - 6].legalMove = true;
                    if (Safe(currentCell.rankNumber - 7, currentCell.fileNumber - 7))
                        theGrid[currentCell.rankNumber - 7, currentCell.fileNumber - 7].legalMove = true;
                    break;
                
                case "rook":
                    //move right
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 3, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 3, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 4, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 4, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 5, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 5, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 6, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 6, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 7, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 7, currentCell.fileNumber].legalMove = true;
                    // move left
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 3, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 3, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 4, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 4, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 5, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 5, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 6, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 6, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 7, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 7, currentCell.fileNumber].legalMove = true;
                    // move up 
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 2))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 2].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 3))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 3].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 4))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 4].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 5))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 5].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 6))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 6].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 7))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 7].legalMove = true;
                    // move down 
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 2))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 2].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 3))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 3].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 4))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 4].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 5))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 5].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 6))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 6].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 7))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 7].legalMove = true;
                    break;

                case "queen":
                    //moving left and up
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber + 2))
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber + 2].legalMove = true;
                    if (Safe(currentCell.rankNumber + 3, currentCell.fileNumber + 3))
                        theGrid[currentCell.rankNumber + 3, currentCell.fileNumber + 3].legalMove = true;
                    if (Safe(currentCell.rankNumber + 4, currentCell.fileNumber + 4))
                        theGrid[currentCell.rankNumber + 4, currentCell.fileNumber + 4].legalMove = true;
                    if (Safe(currentCell.rankNumber + 5, currentCell.fileNumber + 5))
                        theGrid[currentCell.rankNumber + 5, currentCell.fileNumber + 5].legalMove = true;
                    if (Safe(currentCell.rankNumber + 6, currentCell.fileNumber + 6))
                        theGrid[currentCell.rankNumber + 6, currentCell.fileNumber + 6].legalMove = true;
                    if (Safe(currentCell.rankNumber + 7, currentCell.fileNumber + 7))
                        theGrid[currentCell.rankNumber + 7, currentCell.fileNumber + 7].legalMove = true;
                    //moving right and up
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber - 2))
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber - 2].legalMove = true;
                    if (Safe(currentCell.rankNumber + 3, currentCell.fileNumber - 3))
                        theGrid[currentCell.rankNumber + 3, currentCell.fileNumber - 3].legalMove = true;
                    if (Safe(currentCell.rankNumber + 4, currentCell.fileNumber - 4))
                        theGrid[currentCell.rankNumber + 4, currentCell.fileNumber - 4].legalMove = true;
                    if (Safe(currentCell.rankNumber + 5, currentCell.fileNumber - 5))
                        theGrid[currentCell.rankNumber + 5, currentCell.fileNumber - 5].legalMove = true;
                    if (Safe(currentCell.rankNumber + 6, currentCell.fileNumber - 6))
                        theGrid[currentCell.rankNumber + 6, currentCell.fileNumber - 6].legalMove = true;
                    if (Safe(currentCell.rankNumber + 7, currentCell.fileNumber - 7))
                        theGrid[currentCell.rankNumber + 7, currentCell.fileNumber - 7].legalMove = true;
                    // moving left and down
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber + 2))
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber + 2].legalMove = true;
                    if (Safe(currentCell.rankNumber - 3, currentCell.fileNumber + 3))
                        theGrid[currentCell.rankNumber - 3, currentCell.fileNumber + 3].legalMove = true;
                    if (Safe(currentCell.rankNumber - 4, currentCell.fileNumber + 4))
                        theGrid[currentCell.rankNumber - 4, currentCell.fileNumber + 4].legalMove = true;
                    if (Safe(currentCell.rankNumber - 5, currentCell.fileNumber + 5))
                        theGrid[currentCell.rankNumber - 5, currentCell.fileNumber + 5].legalMove = true;
                    if (Safe(currentCell.rankNumber - 6, currentCell.fileNumber + 6))
                        theGrid[currentCell.rankNumber - 6, currentCell.fileNumber + 6].legalMove = true;
                    if (Safe(currentCell.rankNumber - 7, currentCell.fileNumber + 7))
                        theGrid[currentCell.rankNumber - 7, currentCell.fileNumber + 7].legalMove = true;
                    //moving right and down
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber - 2))
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber - 2].legalMove = true;
                    if (Safe(currentCell.rankNumber - 3, currentCell.fileNumber - 3))
                        theGrid[currentCell.rankNumber - 3, currentCell.fileNumber - 3].legalMove = true;
                    if (Safe(currentCell.rankNumber - 4, currentCell.fileNumber - 4))
                        theGrid[currentCell.rankNumber - 4, currentCell.fileNumber - 4].legalMove = true;
                    if (Safe(currentCell.rankNumber - 5, currentCell.fileNumber - 5))
                        theGrid[currentCell.rankNumber - 5, currentCell.fileNumber - 5].legalMove = true;
                    if (Safe(currentCell.rankNumber - 6, currentCell.fileNumber - 6))
                        theGrid[currentCell.rankNumber - 6, currentCell.fileNumber - 6].legalMove = true;
                    if (Safe(currentCell.rankNumber - 7, currentCell.fileNumber - 7))
                        theGrid[currentCell.rankNumber - 7, currentCell.fileNumber - 7].legalMove = true;
                    //move right
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 2, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 2, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 3, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 3, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 4, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 4, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 5, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 5, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 6, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 6, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 7, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 7, currentCell.fileNumber].legalMove = true;
                    // move left
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 2, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 2, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 3, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 3, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 4, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 4, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 5, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 5, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 6, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 6, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber - 7, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 7, currentCell.fileNumber].legalMove = true;
                    // move up 
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 2))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 2].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 3))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 3].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 4))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 4].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 5))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 5].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 6))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 6].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 7))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 7].legalMove = true;
                    // move down 
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 2))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 2].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 3))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 3].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 4))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 4].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 5))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 5].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 6))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 6].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 7))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 7].legalMove = true;
                    break;

                case "king":
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber].legalMove = true;
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber + 1, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber + 1, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber + 1))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber + 1].legalMove = true;
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber - 1].legalMove = true;
                    if (Safe(currentCell.rankNumber - 1, currentCell.fileNumber))
                        theGrid[currentCell.rankNumber - 1, currentCell.fileNumber].legalMove = true;
                    break;

                case "pawn":
                    //there still a bunch that needs to work on for pawn                   
                    if (Safe(currentCell.rankNumber, currentCell.fileNumber - 1))
                        theGrid[currentCell.rankNumber, currentCell.fileNumber - 1].legalMove = true;
                    break;
            }
            theGrid[currentCell.rankNumber, currentCell.fileNumber].occupied = true;
        }        
        public bool Safe(int rank, int file)
        {
            // used to keep "legal" moves inside the board
            if ((rank > size -1 || rank < 0) || (file > size - 1 || file < 0))
            {
                return false;
            }
            return true;
        }
    }
}
