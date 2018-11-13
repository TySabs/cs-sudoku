using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            PopulateRows();

            Puzzle p = new Puzzle("../../Properties/Resources/puzzles/easy/e1.txt");

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    PuzzleData[i, j].Text = p.InitialState[i, j].ToString();
                }
            }
        }

        private void InitFrameSize()
        {
            int h = (int) (Screen.PrimaryScreen.WorkingArea.Height * 0.65);
            int w = (int) (Screen.PrimaryScreen.WorkingArea.Width * 0.65);
            Size = new Size(w, h);
        }

        private void SudokuApp_Load(object sender, EventArgs e)
        {

        }
    }
}
