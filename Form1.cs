using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessBoardLogic;

namespace Chess
{
    public partial class Form1 : Form
    {

        static Board myboard = new Board(8);
        public Button[,] btnGrid = new Button[myboard.size, myboard.size];
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }
        private void populateGrid()
        {
            // uses the size of the board and the panel to fill the board with buttons
            // that act as squares in our board
            int buttonSize = panel1.Width / myboard.size;
            panel1.Height = panel1.Width;
            for(int i = 0; i < myboard.size; i++)
            {
            for(int j = 0; j < myboard.size; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;
                    // if a button is clicked we adjust all buttons to there new state
                    btnGrid[i, j].Click += Grid_Button_Click;
                    // adds the buttons to the panel
                    panel1.Controls.Add(btnGrid[i, j]);
                    // places the in correct location
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);                    
                    // tags them so we dont need there rank and file on screen to track them
                    btnGrid[i, j].Tag = new Point(i,j);
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button) sender;
            Point location = (Point) clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myboard.theGrid[x, y];
            // takes the string from the drop down box and feeds it to the legal move()
            myboard.LegalMove(currentCell, comboBox1.Text);
            // goes through and reassgins the buttons text to the name of the piece and if a square is legal
            for(int i = 0; i< myboard.size; i++)
            {
                for (int j = 0; j < myboard.size; j++)
                {
                    btnGrid[i, j].BackColor = Color.Transparent;
                    btnGrid[i, j].Text = " ";

                    if (myboard.theGrid[i, j].legalMove)
                    {
                        btnGrid[i, j].BackColor = Color.Orange;
                    }
                    else if (myboard.theGrid[i, j].occupied)
                    {
                        btnGrid[i, j].Text = comboBox1.Text;
                    }
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
