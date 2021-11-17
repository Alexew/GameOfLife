﻿using System;
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
        private bool[,] lifeGrid;

        public MainForm()
        {
            InitializeComponent();
            InitializeLifeGrid();
        }

        private void InitializeLifeGrid()
        {
            lifeGrid = new bool[width, height];

            // Glider
            lifeGrid[2, 0] = true;
            lifeGrid[0, 1] = true;
            lifeGrid[2, 1] = true;
            lifeGrid[1, 2] = true;
            lifeGrid[2, 2] = true;
        }

        private void NextGeneration()
        {
            var bufferGrid = new bool[width, height];

            Array.Copy(lifeGrid, bufferGrid, width * height);

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    var neighborsNumber = 0;

                    for (var x = i - 1; x < i + 2; x++)
                    {
                        for (var y = j - 1; y < j + 2; y++)
                        {
                            if (x == i && y == j)
                                continue;

                            var xNormal = x;
                            if (xNormal < 0)
                                xNormal += width;
                            if (xNormal == width)
                                xNormal = 0;

                            var yNormal = y;
                            if (yNormal < 0)
                                yNormal += height;
                            if (yNormal == height)
                                yNormal = 0;

                            if (lifeGrid[xNormal, yNormal])
                                neighborsNumber++;
                        }
                    }

                    if (neighborsNumber == 3)
                        bufferGrid[i, j] = true;
                    else if (neighborsNumber != 2)
                        bufferGrid[i, j] = false;
                }
            }

            lifeGrid = bufferGrid;
        }

        private void GenerationTimer_Tick(object sender, EventArgs e)
        {
            NextGeneration();

            gridPictureBox.Refresh();
        }

        private void GridPictureBox_Paint(object sender, PaintEventArgs e)
        {
            using var brush = new SolidBrush(Color.White);

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    if (lifeGrid[i, j])
                        e.Graphics.FillRectangle(brush, i * 10 + 1, j * 10 + 1, 8, 8);
                }
            }
        }
    }
}
