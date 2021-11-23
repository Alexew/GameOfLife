using System;
using System.Windows.Forms;

namespace GameOfLife.Forms
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        public int GridWidth { get; set; } = 80;
        public int GridHeight { get; set; } = 50;

        private void WidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GridWidth = (int)widthNumericUpDown.Value;
        }

        private void HeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GridHeight= (int)heightNumericUpDown.Value;
        }
    }
}
