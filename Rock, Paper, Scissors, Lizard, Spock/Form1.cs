namespace Rock__Paper__Scissors__Lizard__Spock
{
    public partial class formMain : Form
    {
        private string[] choices = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        // layed out like a table :)
        // double check I got the outcome right
        private string[,] outcomeArray = new string[5, 5]
        {
            { "TIE", "Paper", "Rock", "Rock", "Spock" },
            { "Paper", "TIE", "Scissors", "Lizard", "Paper" },
            { "Rock", "Scissors", "TIE", "Scissors", "Spock" },
            { "Rock", "Lizard", "Scissors", "TIE", "Lizard" },
            { "Spock", "Paper", "Spock", "Lizard", "TIE" },
        };
        private int gameRound = 1;
        private int playerScore = 0;
        private int computerScore = 0;

        public formMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame(int playerChoice)
        {
            Random random = new();
            int computerChoice = random.Next(0, 5);     // returns (0 - 4)

            string gameWinner = GetWinner(playerChoice, computerChoice);
            string outcome = outcomeArray[playerChoice, computerChoice];

            lblPlayerChoice.Text = "PLAYER SELECTED: " + choices[playerChoice];
            lblComputerChoice.Text = "COMPUTER SELECTED: " + choices[computerChoice];

            switch (gameRound)      // adds outcome to relevant label and reveals them
            {
                default:
                case 1:
                    lblGame1.Visible = true;
                    lblGame1.Text = "Winner of game 1: " + gameWinner;
                    break;
                case 2:
                    lblGame2.Visible = true;
                    lblGame2.Text = "Winner of game 2: " + gameWinner;
                    break;
                case 3:
                    lblGame3.Visible = true;
                    lblGame3.Text = "Winner of game 3: " + gameWinner;
                    break;
            }

            if (outcome == choices[playerChoice])
            {
                gameRound++;
                playerScore++;
            }
            else if (outcome == choices[computerChoice])
            {
                gameRound++;
                computerScore++;
            }

            if (gameRound >= 4)
            {
                string overallWinner = GetOverallWinner(playerScore, computerScore);

                lblWinner.Text = "OVERALL WINNER: " + overallWinner;

                EndGame();
            }
        }

        private string GetOverallWinner(int scorePlayer, int scoreComputer)     // method to show the overall winner
        {
            string overallWinner;

            if (playerScore > computerScore)
            {
                overallWinner = "Player Wins";
            }
            else if (playerScore < computerScore)
            {
                overallWinner = "Computer Wins";
            }
            else
            {
                overallWinner = "TIE";
            }

            return overallWinner;
        }

        private void EndGame()  // resets the game counter, player and computer score, and disables game buttons (to prevent errors)
        {
            gameRound = 1;
            playerScore = 0;
            computerScore = 0;

            btnRock.Enabled = false;
            btnPaper.Enabled = false;
            btnScissors.Enabled = false;
            btnLizard.Enabled = false;
            btnSpock.Enabled = false;
            lblWinner.Visible = true;
        }

        private string GetRuling(string playerSelected, string computerSelected)
        {
            string ruling = "";

            if (playerSelected == "Rock")   // ruling for when player chooses rock
            {
                if (computerSelected == "Scissors" || computerSelected == "Lizard")
                    ruling = "Rock crushes " + computerSelected;
                else if (computerSelected == "Paper")
                    ruling = "Paper covers Rock";
                else if (computerSelected == "Spock")
                    ruling = "Spock vaporizes Rock";
                else
                    ruling = "TIE";
            }
            else if (playerSelected == "Paper")   // ruling for when player chooses paper
            {
                if (computerSelected == "Rock")
                    ruling = "Paper covers Rock";
                else if (computerSelected == "Scissors")
                    ruling = "Scissors cuts Paper";
                else if (computerSelected == "Lizard")
                    ruling = "Lizard eats Paper";
                else if (computerSelected == "Spock")
                    ruling = "Paper disproves Spock";
                else
                    ruling = "TIE";
            }
            else if (playerSelected == "Scissors")   // ruling for when player chooses scissors
            {
                if (computerSelected == "Paper")
                    ruling = "Scissors cuts Paper";
                else if (computerSelected == "Rock")
                    ruling = "Rock crushes Scissors";
                else if (computerSelected == "Lizard")
                    ruling = "Scissors decapitates Lizard";
                else if (computerSelected == "Spock")
                    ruling = "Spock smashes Scissors";
                else
                    ruling = "TIE";
            }
            else if (playerSelected == "Lizard")   // ruling for when player chooses lizard
            {
                if (computerSelected == "Paper")
                    ruling = "Lizard eats Paper";
                else if (computerSelected == "Rock")
                    ruling = "Rock crushes Lizard";
                else if (computerSelected == "Scissors")
                    ruling = "Scissors decapitates Lizard";
                else if (computerSelected == "Spock")
                    ruling = "Lizard poisons Spock";
                else
                    ruling = "TIE";
            }
            else if (playerSelected == "Spock")   // ruling for when player chooses spock
            {
                if (computerSelected == "Rock")
                    ruling = "Spock vaporizes Rock";
                else if (computerSelected == "Paper")
                    ruling = "Paper disproves Spock";
                else if (computerSelected == "Scissors")
                    ruling = "Spock smashes Scissors";
                else if (computerSelected == "Lizard")
                    ruling = "Lizard poisons Spock";
                else
                    ruling = "TIE";
            }

            return ruling;
        }

        private string GetWinner(int playerChoice, int computerChoice)
        {
            string gameWinner = "";
            string playerSelected = choices[playerChoice];
            string computerSelected = choices[computerChoice];
            string outcome = outcomeArray[playerChoice, computerChoice];

            if (outcome == choices[playerChoice])   // won't increment round if tie or add points
            {
                gameWinner = "Player";      // displays the player as the winner of game 1, 2 or 3
            }
            else if (outcome == choices[computerChoice])
            {
                gameWinner = "Computer";      // displays the computer as the winner of game 1, 2 or 3
            }
            else
            {
                gameWinner = "TIE";
            }

            string ruling = GetRuling(playerSelected, computerSelected);

            lblRuling.Text = ruling;
            lblRuling.Visible = true;

            label1.Text = "Game Round: " + gameRound;

            return gameWinner;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            StartGame(0); // rock index in choices array is 0
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame(1); // paper index in choices array is 1
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StartGame(2); // scissors index in choices array is 2
        }

        private void btnLizard_Click(object sender, EventArgs e)
        {
            StartGame(3); // lizard index in choices array is 3
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            StartGame(4); // spock index in choices array is 4
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()    // method that resets the game
        {
            lblGame1.Text = "Winner of game 1: ";
            lblGame1.Visible = false;

            lblGame2.Text = "Winner of game 2: ";
            lblGame2.Visible = false;

            lblGame3.Text = "Winner of game 3: ";
            lblGame3.Visible = false;

            lblPlayerChoice.Text = "PLAYER SELECTED: ";
            lblComputerChoice.Text = "COMPUTER SELECTED: ";
            lblWinner.Visible = false;
            lblRuling.Visible = false;

            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
            btnLizard.Enabled = true;
            btnSpock.Enabled = true;

            gameRound = 1;
            playerScore = 0;
            computerScore = 0;
        }

        private void formMain_Activated(object sender, EventArgs e)
        {
            ResetGame();    // pulls the method to reset the game so that the unknown information is hidden
        }
    }
}
