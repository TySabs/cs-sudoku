using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    public enum PuzzleDifficulty { Easy = 1, Medium = 2, Hard = 3 }

    public class Puzzle
    {
        public bool IsSolved { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSaved { get; set; }
        public PuzzleDifficulty? DifficultyLevel;
        public int Timer { get; set; }
        public int RecordTime { get; set; }

        // TODO add Initial State, Saved State, and Solution State


        // Constructor
        public Puzzle(PuzzleDifficulty difLvl)
        {
            DifficultyLevel = difLvl;

            IsSolved = false;
            IsCompleted = false;
            IsSaved = false;

            Timer = 0;
            RecordTime = 0;
        }

        public Puzzle()
        {
            IsSolved = false;
            IsCompleted = false;
            IsSaved = false;

            Timer = 0;
            RecordTime = 0;
        }

        
        public static double CalculateDifficultyAverage(List<Puzzle> puzzlePool)
        {
            int total, sum;
            for (total = 0, sum = 0; total < puzzlePool.Count; total++)
            {
                sum += puzzlePool[total].RecordTime;
            }

            return sum / total;
        }

    } // end Puzzle class
} // end Sudoku namespace
