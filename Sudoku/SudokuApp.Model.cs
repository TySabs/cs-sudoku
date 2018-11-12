using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{

    public partial class SudokuApp : Form
    {

        public static string[] difficulties = { "Easy", "Medium", "Hard" };

        public static List<Puzzle> easyPuzzles = new List<Puzzle>();
        public static List<Puzzle> mediumPuzzles = new List<Puzzle>();
        public static List<Puzzle> hardPuzzles = new List<Puzzle>();

        public double EasyAverage
        {
            get { return Puzzle.CalculateDifficultyAverage(easyPuzzles); }
        }

        public double MediumAverage
        {
            get { return Puzzle.CalculateDifficultyAverage(mediumPuzzles); }
        }

        public double HardAverage
        {
            get { return Puzzle.CalculateDifficultyAverage(hardPuzzles); }
        }
    }
}
