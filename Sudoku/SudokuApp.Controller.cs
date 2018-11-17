using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuApp : Form
    {
        /**********************************************************************************
        * 
        *  Form Event Functions
        * 
        * *********************************************************************************/
        private void DifficultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save old selected puzzle
            List<Puzzle> selectedList;
            switch (DifficultyBox.SelectedItem)
            {
                case "Easy":
                    selectedList = easyPuzzles;
                    break;
                case "Medium":
                    selectedList = mediumPuzzles;
                    break;
                case "Hard":
                    selectedList = hardPuzzles;
                    break;
                default:
                    displayLabel.Text = "Combo Box Error!";
                    return;
            }

            int puzzleCounter = 1;
            foreach (Puzzle p in selectedList)
            {
                if (!p.IsCompleted)
                {
                    SelectedPuzzle = p;
                    FillGrid();
                    break;
                }
                puzzleCounter++;
            }


            displayLabel.Text = DifficultyBox.SelectedItem + " Difficulty - Puzzle Number: " + puzzleCounter;

        } // end DifficultyBox_SelectedIndexChanged function

        private void AnyTextBox_Click(object sender, EventArgs e)
        {
            TextBox currentBox = sender as TextBox;
            currentBox.BackColor = Color.White;
            currentBox.ForeColor = Color.Black;
        }

        private void AnyTextBox_KeyUp(object sender, EventArgs e)
        {
            TextBox currentBox = sender as TextBox;
            int result;
            if (Int32.TryParse(currentBox.Text, out result))
            {
                if (result < 0 || result > 9)
                {
                    currentBox.Text = "0";
                    currentBox.SelectionStart = currentBox.Text.Length;
                }
            }
            else
            {
                currentBox.Text = "0";
                currentBox.SelectionStart = currentBox.Text.Length;
            }

            if (currentBox.Text.Length > 1)
            {
                currentBox.Text = currentBox.Text.TrimStart('0');
            }

            currentBox.BackColor = Color.White;
            currentBox.ForeColor = Color.Black;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SelectedPuzzle.SetSaveState(PuzzleBoxes);
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            SelectedPuzzle.IsSaved = false;
            FillGrid();
        }

        private void CheckSolutionButton_Click(object sender, EventArgs e)
        {
            CheckSolution();
        }

        /**********************************************************************************
         * 
         *  Helper Functions
         * 
         * *********************************************************************************/
        private void FillGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                if (SelectedPuzzle.IsSaved)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        PuzzleBoxes[i, j].Text = SelectedPuzzle.SavedState[i, j].ToString();
                        PuzzleBoxes[i, j].BackColor = Color.White;
                        PuzzleBoxes[i, j].ForeColor = Color.Black;
                    }
                }
                else
                {
                    for (int j = 0; j < 9; j++)
                    {
                        PuzzleBoxes[i, j].Text = SelectedPuzzle.InitialState[i, j].ToString();
                        PuzzleBoxes[i, j].BackColor = Color.White;
                        PuzzleBoxes[i, j].ForeColor = Color.Black;
                    }
                }

            }
        } // end FillGrid function

        private bool CheckSolution()
        {
            int numCorrect = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (PuzzleBoxes[i, j].Text == SelectedPuzzle.SolutionState[i, j].ToString())
                    {
                        PuzzleBoxes[i, j].BackColor = Color.Green;
                        PuzzleBoxes[i, j].ForeColor = Color.White;
                        numCorrect++;
                    }
                    else
                    {
                        PuzzleBoxes[i, j].BackColor = Color.Red;
                        PuzzleBoxes[i, j].ForeColor = Color.White;
                    }
                }
            }

            bool solveCheck = numCorrect == 81;
            return solveCheck;
        }

    } // end SodukoApp.Controller class
} // end Sudoku namespace
