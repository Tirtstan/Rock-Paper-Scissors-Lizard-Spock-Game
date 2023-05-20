namespace Rock__Paper__Scissors__Lizard__Spock
{
    partial class formMain
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
            picScissors = new PictureBox();
            picLizard = new PictureBox();
            picPaper = new PictureBox();
            picRock = new PictureBox();
            picSpock = new PictureBox();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            btnLizard = new Button();
            btnSpock = new Button();
            btnExit = new Button();
            btnPlayAgain = new Button();
            lblPlayerChoice = new Label();
            lblComputerChoice = new Label();
            lblGame1 = new Label();
            lblGame2 = new Label();
            lblGame3 = new Label();
            lblWinner = new Label();
            lblRuling = new Label();
            ((System.ComponentModel.ISupportInitialize)picScissors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLizard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSpock).BeginInit();
            SuspendLayout();
            // 
            // picScissors
            // 
            picScissors.Image = Properties.Resources.CamScanner_05_17_2023_11_13_3;
            picScissors.Location = new Point(350, 12);
            picScissors.Name = "picScissors";
            picScissors.Size = new Size(120, 120);
            picScissors.SizeMode = PictureBoxSizeMode.StretchImage;
            picScissors.TabIndex = 0;
            picScissors.TabStop = false;
            // 
            // picLizard
            // 
            picLizard.Cursor = Cursors.No;
            picLizard.Image = Properties.Resources.CamScanner_05_17_2023_11_13_4;
            picLizard.Location = new Point(475, 12);
            picLizard.Name = "picLizard";
            picLizard.Size = new Size(120, 120);
            picLizard.SizeMode = PictureBoxSizeMode.StretchImage;
            picLizard.TabIndex = 1;
            picLizard.TabStop = false;
            // 
            // picPaper
            // 
            picPaper.Image = Properties.Resources.CamScanner_05_17_2023_11_13_2;
            picPaper.Location = new Point(224, 12);
            picPaper.Name = "picPaper";
            picPaper.Size = new Size(120, 120);
            picPaper.SizeMode = PictureBoxSizeMode.StretchImage;
            picPaper.TabIndex = 2;
            picPaper.TabStop = false;
            // 
            // picRock
            // 
            picRock.Image = Properties.Resources.CamScanner_05_17_2023_11_13_1;
            picRock.Location = new Point(98, 12);
            picRock.Name = "picRock";
            picRock.Size = new Size(120, 120);
            picRock.SizeMode = PictureBoxSizeMode.StretchImage;
            picRock.TabIndex = 3;
            picRock.TabStop = false;
            // 
            // picSpock
            // 
            picSpock.Image = Properties.Resources.CamScanner_05_17_2023_11_13_5;
            picSpock.Location = new Point(602, 12);
            picSpock.Name = "picSpock";
            picSpock.Size = new Size(120, 120);
            picSpock.SizeMode = PictureBoxSizeMode.StretchImage;
            picSpock.TabIndex = 4;
            picSpock.TabStop = false;
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRock.Location = new Point(98, 139);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(120, 40);
            btnRock.TabIndex = 6;
            btnRock.Text = "ROCK";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaper.Location = new Point(224, 139);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(120, 40);
            btnPaper.TabIndex = 7;
            btnPaper.Text = "PAPER";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnScissors.Location = new Point(350, 139);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(120, 40);
            btnScissors.TabIndex = 8;
            btnScissors.Text = "SCISSORS";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // btnLizard
            // 
            btnLizard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLizard.Location = new Point(475, 139);
            btnLizard.Name = "btnLizard";
            btnLizard.Size = new Size(120, 40);
            btnLizard.TabIndex = 9;
            btnLizard.Text = "LIZARD";
            btnLizard.UseVisualStyleBackColor = true;
            btnLizard.Click += btnLizard_Click;
            // 
            // btnSpock
            // 
            btnSpock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpock.Location = new Point(602, 139);
            btnSpock.Name = "btnSpock";
            btnSpock.Size = new Size(120, 40);
            btnSpock.TabIndex = 10;
            btnSpock.Text = "SPOCK";
            btnSpock.UseVisualStyleBackColor = true;
            btnSpock.Click += btnSpock_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(666, 363);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 60);
            btnExit.TabIndex = 12;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlayAgain.Location = new Point(443, 363);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(217, 60);
            btnPlayAgain.TabIndex = 13;
            btnPlayAgain.Text = "PLAY AGAIN";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // lblPlayerChoice
            // 
            lblPlayerChoice.AutoSize = true;
            lblPlayerChoice.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerChoice.Location = new Point(406, 205);
            lblPlayerChoice.Name = "lblPlayerChoice";
            lblPlayerChoice.Size = new Size(245, 29);
            lblPlayerChoice.TabIndex = 14;
            lblPlayerChoice.Text = "PLAYER SELECTED:";
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.AutoSize = true;
            lblComputerChoice.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblComputerChoice.Location = new Point(406, 241);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(290, 29);
            lblComputerChoice.TabIndex = 15;
            lblComputerChoice.Text = "COMPUTER SELECTED:";
            // 
            // lblGame1
            // 
            lblGame1.AutoSize = true;
            lblGame1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame1.Location = new Point(11, 207);
            lblGame1.Name = "lblGame1";
            lblGame1.Size = new Size(207, 29);
            lblGame1.TabIndex = 16;
            lblGame1.Text = "Winner of game 1:";
            // 
            // lblGame2
            // 
            lblGame2.AutoSize = true;
            lblGame2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame2.Location = new Point(11, 240);
            lblGame2.Name = "lblGame2";
            lblGame2.Size = new Size(207, 29);
            lblGame2.TabIndex = 17;
            lblGame2.Text = "Winner of game 2:";
            // 
            // lblGame3
            // 
            lblGame3.AutoSize = true;
            lblGame3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame3.Location = new Point(11, 273);
            lblGame3.Name = "lblGame3";
            lblGame3.Size = new Size(207, 29);
            lblGame3.TabIndex = 19;
            lblGame3.Text = "Winner of game 3:";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Underline, GraphicsUnit.Point);
            lblWinner.Location = new Point(11, 382);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(230, 29);
            lblWinner.TabIndex = 20;
            lblWinner.Text = "OVERALL WINNER:";
            // 
            // lblRuling
            // 
            lblRuling.AutoSize = true;
            lblRuling.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRuling.Location = new Point(406, 307);
            lblRuling.Name = "lblRuling";
            lblRuling.Size = new Size(90, 25);
            lblRuling.TabIndex = 21;
            lblRuling.Text = "RULING";
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(lblRuling);
            Controls.Add(lblWinner);
            Controls.Add(lblGame3);
            Controls.Add(lblGame2);
            Controls.Add(lblGame1);
            Controls.Add(lblComputerChoice);
            Controls.Add(lblPlayerChoice);
            Controls.Add(btnPlayAgain);
            Controls.Add(btnExit);
            Controls.Add(btnSpock);
            Controls.Add(btnLizard);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Controls.Add(picSpock);
            Controls.Add(picRock);
            Controls.Add(picPaper);
            Controls.Add(picLizard);
            Controls.Add(picScissors);
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock, Paper, Scissors, Lizard, Spock Game";
            Activated += formMain_Activated;
            ((System.ComponentModel.ISupportInitialize)picScissors).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLizard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSpock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picScissors;
        private PictureBox picLizard;
        private PictureBox picPaper;
        private PictureBox picRock;
        private PictureBox picSpock;
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnLizard;
        private Button btnSpock;
        private Button btnExit;
        private Button btnPlayAgain;
        private Label lblPlayerChoice;
        private Label lblComputerChoice;
        private Label lblGame1;
        private Label lblGame2;
        private Label lblGame3;
        private Label lblWinner;
        private Label lblRuling;
    }
}