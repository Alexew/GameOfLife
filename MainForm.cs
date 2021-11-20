﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        const int width = 80;
        const int height = 50;

        private Grid lifeGrid;

        public MainForm()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            lifeGrid = new Grid(width, height);
        }

        private void Play()
        {
            generationTimer.Enabled = true;
            playButton.Text = "Pause";
        }

        private void Pause()
        {
            generationTimer.Enabled = false;
            playButton.Text = "Play";
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
            if (generationTimer.Enabled)
                Pause();
            else
                Play();
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

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pause();
            NewGame();

            gridPictureBox.Refresh();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isPlay = generationTimer.Enabled;

            if (isPlay)
                Pause();

            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text File (*.txt)|*.txt",
                Title = "Open"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = File.ReadAllText(openFileDialog.FileName);

                lifeGrid.LoadData(data);
                gridPictureBox.Refresh();
            }
            else
            {
                if (isPlay)
                    Play();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isPlay = generationTimer.Enabled;

            if (isPlay)
                Pause();

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text File (*.txt)|*.txt",
                Title = "Save"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, lifeGrid.SaveData());
            }

            if (isPlay)
                Play();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
