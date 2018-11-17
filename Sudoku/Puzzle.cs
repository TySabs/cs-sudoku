using System;
using System.Collections.Generic;
using System.IO;
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
    public class Puzzle
    {
        public bool IsSolved { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSaved { get; set; }
        public bool IsCheating { get; set; }
        public int Timer { get; set; }
        public int RecordTime { get; set; }
        public char[,] InitialState;
        public char[,] SolutionState;
        public char[,] SavedState;



        /*******************************************************
        * Puzzle constructor
        *
        * Arguments: (1): filePath - path to a source file
        ******************************************************/
        public Puzzle(string filePath)
        {
            IsSolved = false;
            IsCompleted = false;
            IsSaved = false;
            IsCheating = false;

            Timer = 0;
            RecordTime = 0;

            using (StreamReader inFile = new StreamReader(filePath))
            {
                string buffer;
                buffer = inFile.ReadLine();
                InitialState = new char[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        InitialState[i, j] = buffer[j];
                    } // end inner for-loop

                    buffer = inFile.ReadLine();
                } // end outer for-loop

                buffer = inFile.ReadLine();
                SolutionState = new char[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        SolutionState[i, j] = buffer[j];
                    } // end inner for-loop

                    buffer = inFile.ReadLine();
                } // end outer for-loop
            }
        } // end Constructor


        /*******************************************************
        * Puzzle.CalculateDifficultyAverage method
        *
        * Arguments: (1): puzzlePool - A list of puzzles
        *
        * Return Type: TimeSpan - the average difficulty for this pool
        * Use Case: Calculates the average record time for a difficulty
        ******************************************************/
        public static TimeSpan CalculateDifficultyAverage(List<Puzzle> puzzlePool)
        {
            int total, sum, i;
            for (i = 0, total = 0, sum = 0; i < puzzlePool.Count; i++)
            {
                if (puzzlePool[i].IsCompleted)
                {
                    sum += puzzlePool[total].RecordTime;
                    total++;
                }
            }

            if (total == 0)
            {
                return TimeSpan.FromSeconds(0);
            }
            else
            {
                return TimeSpan.FromSeconds(sum / total);
            }

        } // end Puzzle.CalculateDifficultyAverage method


        /*******************************************************
        * Puzzle.SetSaveState method
        *
        * Arguments: (1): currentState - Current State of the TextBox grid
        *
        * Return Type: void
        * Use Case: Sets this puzzle's SavedState
        ******************************************************/
        public void SetSaveState(TextBox[,] currentState)
        {
            IsSaved = true;
            SavedState = new char[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SavedState[i, j] = currentState[i, j].Text[0];
                } // end inner for-loop

            } // end outer for-loop
        }
    } // end Puzzle class
} // end Sudoku namespace
