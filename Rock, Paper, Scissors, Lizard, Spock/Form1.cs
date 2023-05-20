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
        private int gameRound = 0;
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

        private void btnPlayAgain_Click(object sender, EventArgs e) { }

        private void StartGame(int playerChoice)
        {
            Random random = new();
            int computerChoice = random.Next(0, 5); // returns (0 - 4)

            string outcome = GetOutcome(playerChoice, computerChoice);
        }

        private string GetOutcome(int playerChoice, int computerChoice)
        {
            string outcome = outcomeArray[playerChoice, computerChoice];

            // won't increment round if tie or add points
            if (outcome == choices[playerChoice])
            {
                playerScore++;
                gameRound++;
            }
            else if (outcome == choices[computerChoice])
            {
                computerScore++;
                gameRound++;
            }

            return outcome;
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
    }
}
