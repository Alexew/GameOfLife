using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        const int width = 80;
        const int height = 50;

        private readonly Grid lifeGrid;

        public MainForm()
        {
            InitializeComponent();

            lifeGrid = new Grid(80, 50);
        }

        private void GenerationTimer_Tick(object sender, EventArgs e)
        {
            lifeGrid.NextGeneration();
            gridPictureBox.Refresh();
        }

        private void GridPictureBox_Paint(object sender, PaintEventArgs e)
        {
            using var brush = new SolidBrush(Color.White);

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    if (lifeGrid.Cells[i, j].IsAlive)
                        e.Graphics.FillRectangle(brush, i * 10 + 1, j * 10 + 1, 8, 8);
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            generationTimer.Enabled = !generationTimer.Enabled;
            playButton.Text = playButton.Text == "Play" ? "Pause" : "Play";
        }

        private void GenerationSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            generationTimer.Interval = generationSpeedTrackBar.Value * 10;
        }

        private void GridPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lifeGrid.Cells[e.X / 10, e.Y / 10].Toggle();

            gridPictureBox.Refresh();
        }
    }
}
