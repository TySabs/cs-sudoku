using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/************************************************************
 *                                                          *
 *  CSCI 473/504           Assignment 5         Fall 2018   *                                             
 *                                                          *
 *  Programmers: Tyler Saballus                             *
 *                                                          *
 *  Date Due:   Nov-15 (Turned in one day late)             *                          
 *                                                          *
 *  Purpose:    This is a Sudoku app that allows users to   *
 *              play the popular Sudoku game.               *
 ***********************************************************/

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
            WinLabel.Text = "";
            // Save old selected puzzle
            switch (DifficultyBox.SelectedItem)
            {
                case "Easy":
                    SelectedList = easyPuzzles;
                    break;
                case "Medium":
                    SelectedList = mediumPuzzles;
                    break;
                case "Hard":
                    SelectedList = hardPuzzles;
                    break;
                default:
                    DifficultyLabel.Text = "Combo Box Error!";
                    return;
            }

            int puzzleCounter = 1;
            foreach (Puzzle p in SelectedList)
            {
                if (!p.IsCompleted)
                {
                    SelectedPuzzle = p;
                    FillGrid();
                    break;
                }
                puzzleCounter++;
            }


            PuzzleTimer.Enabled = true;

            StringBuilder sb = new StringBuilder();
            sb.Append(DifficultyBox.SelectedItem + " Difficulty - ");
            sb.Append("Puzzle Number: " + puzzleCounter);
            DifficultyLabel.Text = sb.ToString();

            SetAverageSolutionTime();

        } // end DifficultyBox_SelectedIndexChanged function

        private void AnyTextBox_Click(object sender, EventArgs e)
        {
            TextBox currentBox = sender as TextBox;
            currentBox.BackColor = Color.White;
            currentBox.ForeColor = Color.Black;
            currentBox.SelectionStart = currentBox.Text.Length;
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
        } // end AnyTextBox_KeyUp function

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
            if (SelectedPuzzle == null)
            {
                return;
            }

            SelectedPuzzle.IsCompleted = CheckSolution();

            if (SelectedPuzzle.IsCompleted)
            {
                PuzzleTimer.Enabled = false;
                string winMsg = "Congratulations! You have completed the puzzle at time: " + TimerLabel.Text;
                SelectedPuzzle.RecordTime = SelectedPuzzle.Timer;

                TimerLabel.Text = "";
                WinLabel.Text = winMsg;

                SetAverageSolutionTime();
            }

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            PuzzleTimer.Enabled = !PuzzleTimer.Enabled;

            if (PuzzleTimer.Enabled) {
                FillGrid();
            }
            else
            {
                EmptyGrid();
            }
        }

        private void PuzzleTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = TimeSpan.FromSeconds(SelectedPuzzle.Timer);
            TimerLabel.Text = timeElapsed.ToString("T");
            SelectedPuzzle.Timer++;
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

        private void EmptyGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    PuzzleBoxes[i, j].Text = "";
                }
            }
        }

        private bool CheckSolution()
        {
            if (SelectedPuzzle == null)
            {
                return false;
            }

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
                } // end inner for-loop
            } // end outer for-loop

            bool solveCheck = numCorrect == 81;
            return solveCheck;
        } // end CheckSolution function

        private void SetAverageSolutionTime()
        {
            StringBuilder sb = new StringBuilder("Average Solution Time: ");
            int amount = 0, recordTime = 0;
            switch (DifficultyBox.SelectedItem)
            {
                case "Easy":
                    sb.Append(EasyAverage.ToString("T"));

                    amount = GetCompletedAmount(easyPuzzles);
                    recordTime = GetRecordTime(easyPuzzles);
                    break;
                case "Medium":
                    sb.Append(MediumAverage.ToString("T"));

                    amount = GetCompletedAmount(mediumPuzzles);
                    recordTime = GetRecordTime(mediumPuzzles);
                    break;
                case "Hard":
                    sb.Append(HardAverage.ToString("T"));

                    amount = GetCompletedAmount(hardPuzzles);
                    recordTime = GetRecordTime(hardPuzzles);
                    break;
                default:
                    sb.Append("\t Set Average Error!");
                    break;
            }

            TimeSpan formattedRecord = TimeSpan.FromSeconds(recordTime);
            sb.Append(" || Total Completed: " + amount);
            sb.Append(" || Record Time: " + formattedRecord.ToString("T"));

            AvgLabel.Text = sb.ToString();
        } // end SetAverageSolutionTime function

        private int GetCompletedAmount(List<Puzzle> puzzleList)
        {
            int amount = 0;

            foreach (Puzzle p in puzzleList)
            {
                if (p.IsCompleted)
                {
                    amount++;
                }
            }

            return amount;
        } // end GetCompletedAmount method


        private int GetRecordTime(List<Puzzle> puzzleList)
        {
            int recordTime = Int32.MaxValue;
            foreach (Puzzle p in puzzleList)
            {
                if (p.IsCompleted && p.RecordTime < recordTime)
                {
                    recordTime = p.RecordTime;
                }
            }

            return (recordTime == Int32.MaxValue) ? 0 : recordTime;      
        }

    } // end SodukoApp.Controller class
} // end Sudoku namespace
