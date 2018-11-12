using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    enum PuzzleDifficulty { easy = 1, medium = 2, hard = 3 }

    class Puzzle
    {
        bool IsSolved { get; set; }
        bool IsCompleted { get; set; }
        bool IsSaved { get; set; }
        PuzzleDifficulty DifficultyLevel;
        int Timer { get; set; }

        // TODO add Initial State, Saved State, and Solution State
    }
}
