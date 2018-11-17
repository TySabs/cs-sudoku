using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public SudokuApp()
        {
            InitializeComponent();
            PopulateDiffComboBox();
            InitFrameSize();
            CenterToScreen();
            InitPuzzleLists();
            PopulateGrid();
        }

        /*******************************************************
        * InitFrameSize function
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Initializes frame size to 65% of user's window
        ******************************************************/
        private void InitFrameSize()
        {
            int h = (int) (Screen.PrimaryScreen.WorkingArea.Height * 0.65);
            int w = (int) (Screen.PrimaryScreen.WorkingArea.Width * 0.65);
            Size = new Size(w, h);
        }

        /*******************************************************
        * BuildPuzzleList function
        *
        * Arguments: (2):
        *   1. puzzleList - a list of puzzles to be populated
        *   2. source - base filepath to create puzzles
        *
        * Return Type: void
        * Use Case: Initializes frame size to 65% of user's window
        ******************************************************/
        private void BuildPuzzleList(List<Puzzle> puzzleList, string source)
        {
            Puzzle p;
            string filePath;
            for (int i = 1; i < 5; i++)
            {
                filePath = source + i + ".txt";
                p = new Puzzle(filePath);
                puzzleList.Add(p);
            }
        }

        /*******************************************************
        * InitPuzzleLists function
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Initializes our three lists of puzzles
        ******************************************************/
        private void InitPuzzleLists()
        {
            string easySrc = "../../Properties/Resources/puzzles/easy/e",
                   mediumSrc = "../../Properties/Resources/puzzles/medium/m",
                   hardSrc = "../../Properties/Resources/puzzles/hard/h";

            BuildPuzzleList(easyPuzzles, easySrc);
            BuildPuzzleList(mediumPuzzles, mediumSrc);
            BuildPuzzleList(hardPuzzles, hardSrc);
        }
    } // end SudokuApp class
} // end Sudoku namespace
