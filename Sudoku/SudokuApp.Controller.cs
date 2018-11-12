using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuApp : Form
    {

        private void PopulateDiffComboBox()
        {
            foreach (string d in difficulties)
            {
                DifficultyBox.Items.Add(d);
            }
        }

        public double CalculateDifficultyAverage(List<Puzzle> puzzlePool)
        {
            int total, sum;
            for (total = 0, sum = 0; total < puzzlePool.Count; total++)
            {
                sum += puzzlePool[total].RecordTime;
            }

            return sum / total;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Here is your new puzzle on " + DifficultyBox.SelectedItem
             + " difficulty!";
        }
    }
}
