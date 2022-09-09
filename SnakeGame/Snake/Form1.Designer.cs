namespace Snake
{
    partial class Form1
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
            this.GameField = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.gameOvertxt = new System.Windows.Forms.Label();
            this.easyDiff = new System.Windows.Forms.Button();
            this.normalDiff = new System.Windows.Forms.Button();
            this.hardDiff = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.Label();
            this.diffLevelTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).BeginInit();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameField.Location = new System.Drawing.Point(12, 12);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(830, 360);
            this.GameField.TabIndex = 0;
            this.GameField.TabStop = false;
            this.GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(927, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 54);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(848, 102);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(81, 26);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score:";
            // 
            // gameOvertxt
            // 
            this.gameOvertxt.AutoSize = true;
            this.gameOvertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameOvertxt.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOvertxt.Location = new System.Drawing.Point(318, 141);
            this.gameOvertxt.Name = "gameOvertxt";
            this.gameOvertxt.Size = new System.Drawing.Size(183, 39);
            this.gameOvertxt.TabIndex = 5;
            this.gameOvertxt.Text = "Game Over";
            this.gameOvertxt.Visible = false;
            // 
            // easyDiff
            // 
            this.easyDiff.Location = new System.Drawing.Point(927, 194);
            this.easyDiff.Name = "easyDiff";
            this.easyDiff.Size = new System.Drawing.Size(109, 46);
            this.easyDiff.TabIndex = 6;
            this.easyDiff.Text = "Easy";
            this.easyDiff.UseVisualStyleBackColor = true;
            this.easyDiff.Click += new System.EventHandler(this.ChangeDifficultyToEasy);
            // 
            // normalDiff
            // 
            this.normalDiff.Location = new System.Drawing.Point(927, 246);
            this.normalDiff.Name = "normalDiff";
            this.normalDiff.Size = new System.Drawing.Size(109, 46);
            this.normalDiff.TabIndex = 7;
            this.normalDiff.Text = "Normal";
            this.normalDiff.UseVisualStyleBackColor = true;
            this.normalDiff.Click += new System.EventHandler(this.ChangeDifficultyToNormal);
            // 
            // hardDiff
            // 
            this.hardDiff.Location = new System.Drawing.Point(927, 298);
            this.hardDiff.Name = "hardDiff";
            this.hardDiff.Size = new System.Drawing.Size(109, 46);
            this.hardDiff.TabIndex = 8;
            this.hardDiff.Text = "Hard";
            this.hardDiff.UseVisualStyleBackColor = true;
            this.hardDiff.Click += new System.EventHandler(this.ChangeDifficultyToHard);
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Level.Location = new System.Drawing.Point(848, 141);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(55, 25);
            this.Level.TabIndex = 9;
            this.Level.Text = "Level";
            this.Level.Visible = false;
            // 
            // diffLevelTxt
            // 
            this.diffLevelTxt.AutoSize = true;
            this.diffLevelTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.diffLevelTxt.Location = new System.Drawing.Point(848, 141);
            this.diffLevelTxt.Name = "diffLevelTxt";
            this.diffLevelTxt.Size = new System.Drawing.Size(205, 25);
            this.diffLevelTxt.TabIndex = 10;
            this.diffLevelTxt.Text = "Choose difficulty level:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 392);
            this.Controls.Add(this.diffLevelTxt);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.hardDiff);
            this.Controls.Add(this.normalDiff);
            this.Controls.Add(this.easyDiff);
            this.Controls.Add(this.gameOvertxt);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.GameField);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox GameField;
        private Button startButton;
        private System.Windows.Forms.Timer GameTimer;
        private Label txtScore;
        private Label gameOvertxt;
        private Button easyDiff;
        private Button normalDiff;
        private Button hardDiff;
        private Label Level;
        private Label diffLevelTxt;
    }
}