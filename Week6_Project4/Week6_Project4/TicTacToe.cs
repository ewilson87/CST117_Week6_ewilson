/**
 * Program: Tic Tac Toe generator
 * File: TicTacToe.cs
 * Summary: randomly generated tic tac toe
 * Author: Evan Wilson
 * Date: June 1st, 2018
 **/

using System;
using System.Windows.Forms;

namespace Week6_Project4
{
    public partial class TicTacToe : Form
    {
        //declare constants for rows and columns.
        private const int Rows = 3;
        private const int Columns = 3;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            //declarations
            int numberOfX = 0;
            int numberOfO = 0;
            int randomNumber;
            int columnAndRow = 0;
            string xOrO;
            bool xWon = false;
            bool oWon = false;

            Random random = new Random();

            int[,] board = new int[Columns, Rows];

            //fills array with random values of either 0 or 1, and assigns either X or O to appropriate label
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    randomNumber = random.Next(2);
                    //prevents more than 5 of either X or O 
                    if (randomNumber == 0)
                    {
                        numberOfO++;
                        xOrO = "O";
                    }
                    else
                    {
                        numberOfX++;
                        xOrO = "X";
                    }


                    if (numberOfX > 4)
                    {
                        board[i, j] = 0;
                        xOrO = "O";
                    }
                    else if (numberOfO > 4)
                    {
                        board[i, j] = 1;
                        xOrO = "X";
                    }
                    else
                    {
                        board[i, j] = randomNumber;
                    }

                    //concatenate values as strings together, to then parse into one of the cases below
                    columnAndRow = (int.Parse(i.ToString() + j.ToString()));

                    //sets all appropriate labels with either X or O
                    switch (columnAndRow)
                    {
                        //[0,0]
                        case 0:
                            _00.Text = xOrO;
                            break;
                        //[0,1]
                        case 1:
                            _01.Text = xOrO;
                            break;
                        //[0,2]
                        case 2:
                            _02.Text = xOrO;
                            break;
                        //[1,0]
                        case 10:
                            _10.Text = xOrO;
                            break;
                        //[1,1]
                        case 11:
                            _11.Text = xOrO;
                            break;
                        //[1,2]
                        case 12:
                            _12.Text = xOrO;
                            break;
                        //[2,0]
                        case 20:
                            _20.Text = xOrO;
                            break;
                        //[2,1]
                        case 21:
                            _21.Text = xOrO;
                            break;
                        //[2,2]
                        case 22:
                            _22.Text = xOrO;
                            break;
                    }
                }
            }

            int rowValue = 0;
            int columnValue = 0;
            //column major to check for wins
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    columnValue = columnValue + board[i, j];
                }

                if (columnValue == 3)
                {
                    xWon = true;
                }
                else if (columnValue == 0)
                {
                    oWon = true;
                }
                //resets columnValue
                columnValue = 0;
            }

            //row major to check for wins
            for (int j = 0; j < Rows; j++)
            {
                for (int i = 0; i < Columns; i++)
                {
                    rowValue = rowValue + board[i, j];
                }

                if (rowValue == 3)
                {
                    xWon = true;
                }
                else if (rowValue == 0)
                {
                    oWon = true;
                }
                //resets columnValue
                rowValue = 0;
            }

            //handles diagonals to check for wins
            int diagonal1 = 0;
            diagonal1 = board[0, 0] + board[1, 1] + board[2, 2];

            int diagonal2 = 0;
            diagonal2 = board[0, 2] + board[1, 1] + board[2, 0];

            if (diagonal1 == 3 || diagonal2 == 3)
            {
                xWon = true;
            }
            else if (diagonal1 == 0 || diagonal2 == 0)
            {
                oWon = true;
            }

            //sets winnerLabel text
            if (xWon && oWon || xWon == false && oWon == false)
            {
                winnerLabel.Text = "Tie Game!";
            }
            else if (oWon)
            {
                winnerLabel.Text = "O WINS!";
            }
            else if (xWon)
            {
                winnerLabel.Text = "X WINS!";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            //allows for transparant backgrounds in labels to work properly
            _00.Parent = bunifuGradientPanel2;
            _01.Parent = bunifuGradientPanel3;
            _02.Parent = bunifuGradientPanel4;
            _10.Parent = bunifuGradientPanel5;
            _11.Parent = bunifuGradientPanel6;
            _12.Parent = bunifuGradientPanel7;
            _20.Parent = bunifuGradientPanel8;
            _21.Parent = bunifuGradientPanel9;
            _22.Parent = bunifuGradientPanel10;
        }
    }
}
