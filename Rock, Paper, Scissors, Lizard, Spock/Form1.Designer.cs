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
            lblGame4 = new Label();
            lblGame3 = new Label();
            lblWinner = new Label();
            ((System.ComponentModel.ISupportInitialize)picScissors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLizard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSpock).BeginInit();
            SuspendLayout();
            // 
            // picScissors
            // 
            picScissors.Location = new Point(306, 9);
            picScissors.Margin = new Padding(3, 2, 3, 2);
            picScissors.Name = "picScissors";
            picScissors.Size = new Size(105, 90);
            picScissors.TabIndex = 0;
            picScissors.TabStop = false;
            // 
            // picLizard
            // 
            picLizard.Location = new Point(416, 9);
            picLizard.Margin = new Padding(3, 2, 3, 2);
            picLizard.Name = "picLizard";
            picLizard.Size = new Size(105, 90);
            picLizard.TabIndex = 1;
            picLizard.TabStop = false;
            // 
            // picPaper
            // 
            picPaper.Location = new Point(196, 9);
            picPaper.Margin = new Padding(3, 2, 3, 2);
            picPaper.Name = "picPaper";
            picPaper.Size = new Size(105, 90);
            picPaper.TabIndex = 2;
            picPaper.TabStop = false;
            // 
            // picRock
            // 
            picRock.Location = new Point(86, 9);
            picRock.Margin = new Padding(3, 2, 3, 2);
            picRock.Name = "picRock";
            picRock.Size = new Size(105, 90);
            picRock.TabIndex = 3;
            picRock.TabStop = false;
            // 
            // picSpock
            // 
            picSpock.Location = new Point(527, 9);
            picSpock.Margin = new Padding(3, 2, 3, 2);
            picSpock.Name = "picSpock";
            picSpock.Size = new Size(105, 90);
            picSpock.TabIndex = 4;
            picSpock.TabStop = false;
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRock.Location = new Point(86, 104);
            btnRock.Margin = new Padding(3, 2, 3, 2);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(105, 30);
            btnRock.TabIndex = 6;
            btnRock.Text = "ROCK";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaper.Location = new Point(196, 104);
            btnPaper.Margin = new Padding(3, 2, 3, 2);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(105, 30);
            btnPaper.TabIndex = 7;
            btnPaper.Text = "PAPER";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnScissors.Location = new Point(306, 104);
            btnScissors.Margin = new Padding(3, 2, 3, 2);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(105, 30);
            btnScissors.TabIndex = 8;
            btnScissors.Text = "SCISSORS";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // btnLizard
            // 
            btnLizard.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLizard.Location = new Point(416, 104);
            btnLizard.Margin = new Padding(3, 2, 3, 2);
            btnLizard.Name = "btnLizard";
            btnLizard.Size = new Size(105, 30);
            btnLizard.TabIndex = 9;
            btnLizard.Text = "LIZARD";
            btnLizard.UseVisualStyleBackColor = true;
            btnLizard.Click += btnLizard_Click;
            // 
            // btnSpock
            // 
            btnSpock.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpock.Location = new Point(527, 104);
            btnSpock.Margin = new Padding(3, 2, 3, 2);
            btnSpock.Name = "btnSpock";
            btnSpock.Size = new Size(105, 30);
            btnSpock.TabIndex = 10;
            btnSpock.Text = "SPOCK";
            btnSpock.UseVisualStyleBackColor = true;
            btnSpock.Click += btnSpock_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Roboto", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(584, 272);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 45);
            btnExit.TabIndex = 12;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Font = new Font("Roboto", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlayAgain.Location = new Point(388, 272);
            btnPlayAgain.Margin = new Padding(3, 2, 3, 2);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(190, 45);
            btnPlayAgain.TabIndex = 13;
            btnPlayAgain.Text = "PLAY AGAIN";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // lblPlayerChoice
            // 
            lblPlayerChoice.AutoSize = true;
            lblPlayerChoice.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerChoice.Location = new Point(355, 154);
            lblPlayerChoice.Name = "lblPlayerChoice";
            lblPlayerChoice.Size = new Size(176, 23);
            lblPlayerChoice.TabIndex = 14;
            lblPlayerChoice.Text = "PLAYER SELECTED:";
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.AutoSize = true;
            lblComputerChoice.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblComputerChoice.Location = new Point(355, 181);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(208, 23);
            lblComputerChoice.TabIndex = 15;
            lblComputerChoice.Text = "COMPUTER SELECTED:";
            // 
            // lblGame1
            // 
            lblGame1.AutoSize = true;
            lblGame1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame1.Location = new Point(10, 155);
            lblGame1.Name = "lblGame1";
            lblGame1.Size = new Size(166, 23);
            lblGame1.TabIndex = 16;
            lblGame1.Text = "Winner of game 1:";
            // 
            // lblGame2
            // 
            lblGame2.AutoSize = true;
            lblGame2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame2.Location = new Point(10, 180);
            lblGame2.Name = "lblGame2";
            lblGame2.Size = new Size(166, 23);
            lblGame2.TabIndex = 17;
            lblGame2.Text = "Winner of game 2:";
            // 
            // lblGame4
            // 
            lblGame4.AutoSize = true;
            lblGame4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame4.Location = new Point(10, 230);
            lblGame4.Name = "lblGame4";
            lblGame4.Size = new Size(166, 23);
            lblGame4.TabIndex = 18;
            lblGame4.Text = "Winner of game 4:";
            // 
            // lblGame3
            // 
            lblGame3.AutoSize = true;
            lblGame3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame3.Location = new Point(10, 205);
            lblGame3.Name = "lblGame3";
            lblGame3.Size = new Size(166, 23);
            lblGame3.TabIndex = 19;
            lblGame3.Text = "Winner of game 3:";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Roboto", 16F, FontStyle.Underline, GraphicsUnit.Point);
            lblWinner.Location = new Point(10, 284);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(197, 27);
            lblWinner.TabIndex = 20;
            lblWinner.Text = "OVERALL WINNER:";
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblWinner);
            Controls.Add(lblGame3);
            Controls.Add(lblGame4);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock, Paper, Scissors, Lizard, Spock Game";
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
        private Label lblGame4;
        private Label lblGame3;
        private Label lblWinner;
    }
}