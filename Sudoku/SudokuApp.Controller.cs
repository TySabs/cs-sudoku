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
            } // end switch DifficultyBox.SelectedItem

            int puzzleCounter = 1;
            foreach (Puzzle p in SelectedList)
            {
                if (!p.IsCompleted)
                {
                    SelectedPuzzle = p;
                    p.IsCheating = false;
                    FillGrid();
                    break;
                }
                puzzleCounter++;
            } // end foreach


            PuzzleTimer.Enabled = true;

            StringBuilder sb = new StringBuilder();
            sb.Append(DifficultyBox.SelectedItem + " Difficulty - ");
            sb.Append("Puzzle Number: " + puzzleCounter);
            DifficultyLabel.Text = sb.ToString();

            SetAverageSolutionTime();

        } // end DifficultyBox_SelectedIndexChanged function

        /*******************************************************
        * AnyTextBox_Click function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Changes textbox whenever clicked
        ******************************************************/
        private void AnyTextBox_Click(object sender, EventArgs e)
        {
            TextBox currentBox = sender as TextBox;
            currentBox.BackColor = Color.White;
            currentBox.ForeColor = Color.Black;
            currentBox.SelectionStart = currentBox.Text.Length;
        }

        /*******************************************************
        * AnyTextBox_Click function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Changes textbox whenever KeyUp occurs
        ******************************************************/
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
            } // end else

            if (currentBox.Text.Length > 1)
            {
                currentBox.Text = currentBox.Text.TrimStart('0');
            }

            currentBox.BackColor = Color.White;
            currentBox.ForeColor = Color.Black;
        } // end AnyTextBox_KeyUp function

        /*******************************************************
        * SaveButton_Click function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Saves current puzzle state on button click
        ******************************************************/
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SelectedPuzzle == null) { return; }
            SelectedPuzzle.SetSaveState(PuzzleBoxes);
        }

        /*******************************************************
        * ResetButton_Click function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Resets puzzle state back to initial state on button click
        ******************************************************/
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (SelectedPuzzle == null) { return; }
            SelectedPuzzle.IsSaved = false;
            FillGrid();
        }

        /*******************************************************
        * CheckSolutionButton_Click function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Resets puzzle state back to initial state on button click
        ******************************************************/
        private void CheckSolutionButton_Click(object sender, EventArgs e)
        {
            if (SelectedPuzzle == null) { return; }

            SelectedPuzzle.IsCompleted = CheckSolution();

            if (SelectedPuzzle.IsCompleted)
            {
                PuzzleTimer.Enabled = false;
                string winMsg = "Congratulations! You have completed the puzzle at time: " + TimerLabel.Text;
                SelectedPuzzle.RecordTime = SelectedPuzzle.Timer;

                TimerLabel.Text = "";
                WinLabel.Text = winMsg;

                SetAverageSolutionTime();
            } // end if SelectedPuzzle.IsCompleted
        } // end CheckSolution

        /*******************************************************
        * PauseButton_Click function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Pauses and Resets puzzle timer on button click
        ******************************************************/
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
        } // end PauseButton_Click function

        /*******************************************************
        * PuzzleTimer_Tick function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Updates the TimerLabel on PuzzleTimer tick
        ******************************************************/
        private void PuzzleTimer_Tick(object sender, EventArgs e)
        {
            if (SelectedPuzzle == null) { return; }

            TimeSpan timeElapsed = TimeSpan.FromSeconds(SelectedPuzzle.Timer);
            TimerLabel.Text = timeElapsed.ToString("T");
            SelectedPuzzle.Timer++;
        } // end PuzzleTimer_Tick function


        /*******************************************************
        * HelpButton_Click function
        *
        * Arguments: (2):
        *    1. sender - Form object that targetted
        *    2. e - the event arguments
        *
        * Return Type: void
        * Use Case: Helps the player out by showing them the next unsolved spot
        ******************************************************/
        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (SelectedPuzzle == null) { return; }

            SelectedPuzzle.IsCheating = true;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (PuzzleBoxes[i, j].Text != SelectedPuzzle.SolutionState[i, j].ToString())
                    {
                        PuzzleBoxes[i, j].Text = SelectedPuzzle.SolutionState[i, j].ToString();
                        PuzzleBoxes[i, j].BackColor = Color.Green;
                        PuzzleBoxes[i, j].ForeColor = Color.White;
                        return;
                    }
                } // end inner for-loop
            } // end outer for-loop
        } // end HelpButton_Click

        /**********************************************************************************
        *
        *  Helper Functions
        *
        * *********************************************************************************/


        /*******************************************************
        * FillGrid function
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Fill the grid with the selected puzzle
        ******************************************************/
        private void FillGrid()
        {
            if (SelectedPuzzle == null) { return; }

            for (int i = 0; i < 9; i++)
            {
                if (SelectedPuzzle.IsSaved)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        PuzzleBoxes[i, j].Text = SelectedPuzzle.SavedState[i, j].ToString();
                        PuzzleBoxes[i, j].BackColor = Color.White;
                        PuzzleBoxes[i, j].ForeColor = Color.Black;
                    } // end inner for loop
                }
                else
                {
                    for (int j = 0; j < 9; j++)
                    {
                        PuzzleBoxes[i, j].Text = SelectedPuzzle.InitialState[i, j].ToString();
                        PuzzleBoxes[i, j].BackColor = Color.White;
                        PuzzleBoxes[i, j].ForeColor = Color.Black;
                    } // end inner for loop
                } // end else

            } // end outer for loop
        } // end FillGrid function

        /*******************************************************
        * EmptyGrid function
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Empty the grid to blank boxes -- Used for pausing
        ******************************************************/
        private void EmptyGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    PuzzleBoxes[i, j].Text = "";
                }
            }
        } // end EmptyGrid function

        /*******************************************************
        * CheckSolution function
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Check if the puzzle was successfully completed by user
        ******************************************************/
        private bool CheckSolution()
        {
            if (SelectedPuzzle == null)
            {
                return false;
            }
            else if (SelectedPuzzle.IsCheating)
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

        /*******************************************************
        * SetAverageSolutionTime function
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Sets the AverageLabel with avgTime, recordTime, and totalCompleted
        ******************************************************/
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
            } // end switch DifficultyBox.SelectedItem

            TimeSpan formattedRecord = TimeSpan.FromSeconds(recordTime);
            sb.Append(" || Total Completed: " + amount);
            sb.Append(" || Record Time: " + formattedRecord.ToString("T"));

            AvgLabel.Text = sb.ToString();
        } // end SetAverageSolutionTime function

        /*******************************************************
        * GetCompletedAmount function
        *
        * Arguments: (1): puzzleList - a list of puzzles to be searched
        *
        * Return Type: int - the amount of completed puzzles
        * Use Case: Finds the amount of completed puzzles for a difficulty
        ******************************************************/
        private int GetCompletedAmount(List<Puzzle> puzzleList)
        {
            int amount = 0;

            foreach (Puzzle p in puzzleList)
            {
                if (p.IsCompleted)
                {
                    amount++;
                }
            } // end foreach

            return amount;
        } // end GetCompletedAmount method

        /*******************************************************
        * GetRecordTime function
        *
        * Arguments: (1): puzzleList - a list of puzzles to be searched
        *
        * Return Type: int - the record time
        * Use Case: Finds the record puzzle competion time for this difficulty
        ******************************************************/
        private int GetRecordTime(List<Puzzle> puzzleList)
        {
            int recordTime = Int32.MaxValue;
            foreach (Puzzle p in puzzleList)
            {
                if (p.IsCompleted && p.RecordTime < recordTime)
                {
                    recordTime = p.RecordTime;
                }
            } // end foreach

            return (recordTime == Int32.MaxValue) ? 0 : recordTime;
        } // end GetRecordTime function

    } // end SodukoApp.Controller class
} // end Sudoku namespace
