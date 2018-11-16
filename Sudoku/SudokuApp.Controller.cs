using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuApp : Form
    {
        private void DifficultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save old selected puzzle
           SelectedPuzzle.SetSaveState(PuzzleBoxes);

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
                    FillGrid(p);
                    SelectedPuzzle = p;
                    break;
                }
                puzzleCounter++;
            }


            displayLabel.Text = DifficultyBox.SelectedItem + " Difficulty - Puzzle Number: " + puzzleCounter;

        } // end DifficultyBox_SelectedIndexChanged function

        private void FillGrid(Puzzle selectedPuzzle)
        {
            for (int i = 0; i < 9; i++)
            {
                if (selectedPuzzle.IsSaved)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        PuzzleBoxes[i, j].Text = selectedPuzzle.SavedState[i, j].ToString();
                    }
                }
                else
                {
                    for (int j = 0; j < 9; j++)
                    {
                        PuzzleBoxes[i, j].Text = selectedPuzzle.InitialState[i, j].ToString();
                    }
                }

            }
        } // end FillGrid function


    } // end SodukoApp.Controller class
} // end Sudoku namespace
