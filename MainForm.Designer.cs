
namespace GameOfLife
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridPictureBox = new System.Windows.Forms.PictureBox();
            this.generationTimer = new System.Windows.Forms.Timer(this.components);
            this.playButton = new System.Windows.Forms.Button();
            this.generationSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.generationSpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationSpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPictureBox
            // 
            this.gridPictureBox.BackColor = System.Drawing.Color.Black;
            this.gridPictureBox.Location = new System.Drawing.Point(0, 0);
            this.gridPictureBox.Name = "gridPictureBox";
            this.gridPictureBox.Size = new System.Drawing.Size(800, 500);
            this.gridPictureBox.TabIndex = 0;
            this.gridPictureBox.TabStop = false;
            this.gridPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPictureBox_Paint);
            // 
            // generationTimer
            // 
            this.generationTimer.Tick += new System.EventHandler(this.GenerationTimer_Tick);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(10, 509);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // generationSpeedTrackBar
            // 
            this.generationSpeedTrackBar.LargeChange = 3;
            this.generationSpeedTrackBar.Location = new System.Drawing.Point(153, 509);
            this.generationSpeedTrackBar.Maximum = 100;
            this.generationSpeedTrackBar.Minimum = 1;
            this.generationSpeedTrackBar.Name = "generationSpeedTrackBar";
            this.generationSpeedTrackBar.Size = new System.Drawing.Size(104, 45);
            this.generationSpeedTrackBar.TabIndex = 3;
            this.generationSpeedTrackBar.Value = 10;
            this.generationSpeedTrackBar.Scroll += new System.EventHandler(this.GenerationSpeedTrackBar_Scroll);
            // 
            // generationSpeedLabel
            // 
            this.generationSpeedLabel.AutoSize = true;
            this.generationSpeedLabel.Location = new System.Drawing.Point(105, 513);
            this.generationSpeedLabel.Name = "generationSpeedLabel";
            this.generationSpeedLabel.Size = new System.Drawing.Size(42, 15);
            this.generationSpeedLabel.TabIndex = 4;
            this.generationSpeedLabel.Text = "Speed:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.generationSpeedLabel);
            this.Controls.Add(this.generationSpeedTrackBar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gridPictureBox);
            this.Name = "MainForm";
            this.Text = "The Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationSpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.Timer generationTimer;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TrackBar generationSpeedTrackBar;
        private System.Windows.Forms.Label generationSpeedLabel;
    }
}

