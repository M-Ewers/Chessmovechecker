using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardLogic
{
    public class Cell
    {
        //creates a cell to keep track of what is occupied and where pieces can go 
        public int rankNumber { get; set; }
        public int fileNumber { get; set; }
        public bool occupied { get; set; }
        public bool legalMove { get; set; }


        public Cell(int x, int y)
        {
            rankNumber = x;
            fileNumber = y;
        }


    }
}
