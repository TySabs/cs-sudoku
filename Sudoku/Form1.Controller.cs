using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {

        private void PopulateDiffComboBox()
        {
            foreach (string d in difficulties)
            {
                DifficultyBox.Items.Add(d);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Here is your new puzzle on " + DifficultyBox.SelectedItem
             + " difficulty!";
        }
    }
}
