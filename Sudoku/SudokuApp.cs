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
        }

        private void InitFrameSize()
        {
            int h = (int) (Screen.PrimaryScreen.WorkingArea.Height * 0.65);
            int w = (int) (Screen.PrimaryScreen.WorkingArea.Width * 0.65);
            Size = new Size(w, h);
        }

    }
}
