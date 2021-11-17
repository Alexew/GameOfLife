
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
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
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
            this.generationTimer.Enabled = true;
            this.generationTimer.Tick += new System.EventHandler(this.GenerationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.gridPictureBox);
            this.Name = "MainForm";
            this.Text = "The Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.Timer generationTimer;
    }
}

