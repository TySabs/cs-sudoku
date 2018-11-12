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
        public PuzzleDifficulty DifficultyLevel;
        public int Timer { get; set; }
        public int RecordTime { get; set; }

        // TODO add Initial State, Saved State, and Solution State
    }
}
