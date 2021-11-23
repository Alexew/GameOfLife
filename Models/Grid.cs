using System;

namespace GameOfLife.Models
{
    public class Grid
    {
        public Grid(int width, int height)
        {
            Width = width;
            Height = height;

            Cells = new Cell[Width, Height];

            for (var i = 0; i < Width; i++)
                for (var j = 0; j < Height; j++)
                    Cells[i, j] = new Cell();
        }

        public Cell[,] Cells { get; }
        public int Width { get; }
        public int Height { get; }

        public void NextGeneration()
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Height; j++)
                {
                    Cells[i, j].NeighborsNumber = 0;

                    for (var x = i - 1; x < i + 2; x++)
                    {
                        for (var y = j - 1; y < j + 2; y++)
                        {
                            if (x == i && y == j)
                                continue;

                            var xNormal = x;
                            if (xNormal < 0)
                                xNormal += Width;
                            if (xNormal == Width)
                                xNormal = 0;

                            var yNormal = y;
                            if (yNormal < 0)
                                yNormal += Height;
                            if (yNormal == Height)
                                yNormal = 0;

                            if (Cells[xNormal, yNormal].IsAlive)
                                Cells[i, j].NeighborsNumber++;
                        }
                    }
                }
            }

            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Height; j++)
                {
                    if (Cells[i, j].NeighborsNumber == 3)
                        Cells[i, j].IsAlive = true;
                    else if (Cells[i, j].NeighborsNumber != 2)
                        Cells[i, j].IsAlive = false;
                }
            }
        }

        public string SaveData()
        {
            var data = string.Empty;

            foreach (var cell in Cells)
                data += cell.IsAlive ? "1" : "0";

            return data;
        }

        public void LoadData(string data)
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Height; j++)
                {
                    Cells[i, j].IsAlive = data[i * Height + j] == '1';
                }
            }
        }
    }
}
