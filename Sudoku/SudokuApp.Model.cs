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
        public static string SelectedDifficulty { get; set; }
        public static Puzzle SelectedPuzzle { get; set; }

        public static List<Puzzle> easyPuzzles = new List<Puzzle>();
        public static List<Puzzle> mediumPuzzles = new List<Puzzle>();
        public static List<Puzzle> hardPuzzles = new List<Puzzle>();


        public static TextBox[,] PuzzleBoxes = new TextBox[9,9];

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


        private void PopulateDiffComboBox()
        {
            foreach (string d in difficulties)
            {
                DifficultyBox.Items.Add(d);
            }
        }

        private void PopulateGrid()
        {
            PuzzleBoxes = new TextBox[9, 9]
            {
                { Box1A, Box1B, Box1C, Box1D, Box1E, Box1F, Box1G, Box1H, Box1J },
                { Box2A, Box2B, Box2C, Box2D, Box2E, Box2F, Box2G, Box2H, Box2J },
                { Box3A, Box3B, Box3C, Box3D, Box3E, Box3F, Box3G, Box3H, Box3J },
                { Box4A, Box4B, Box4C, Box4D, Box4E, Box4F, Box4G, Box4H, Box4J },
                { Box5A, Box5B, Box5C, Box5D, Box5E, Box5F, Box5G, Box5H, Box5J },
                { Box6A, Box6B, Box6C, Box6D, Box6E, Box6F, Box6G, Box6H, Box6J },
                { Box7A, Box7B, Box7C, Box7D, Box7E, Box7F, Box7G, Box7H, Box7J },
                { Box8A, Box8B, Box8C, Box8D, Box8E, Box8F, Box8G, Box8H, Box8J },
                { Box9A, Box9B, Box9C, Box9D, Box9E, Box9F, Box9G, Box9H, Box9J }
            };
        }

        // "../../Properties/Resources/puzzles/easy/e1.txt"
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

        private void InitPuzzleLists()
        {
            string easySrc = "../../Properties/Resources/puzzles/easy/e",
                   mediumSrc = "../../Properties/Resources/puzzles/medium/m",
                   hardSrc = "../../Properties/Resources/puzzles/hard/h";

            BuildPuzzleList(easyPuzzles, easySrc);
            BuildPuzzleList(mediumPuzzles, mediumSrc);
            BuildPuzzleList(hardPuzzles, hardSrc);
        }
    } // end Sudoku partial class
} // end Sudoku namespace
