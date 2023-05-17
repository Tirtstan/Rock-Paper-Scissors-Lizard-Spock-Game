namespace Rock__Paper__Scissors__Lizard__Spock
{
    public partial class formMain : Form
    {
        private string[] choices = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        // layed out like a table :)
        // double check I did got the outcome right
        private string[,] gameRuleSet = new string[5, 5]
        {
            { "TIE", "Paper", "Rock", "Rock", "Spock" },
            { "Paper", "TIE", "Scissors", "Lizard", "Paper" },
            { "Rock", "Scissors", "TIE", "Scissors", "Spock" },
            { "Rock", "Lizard", "Scissors", "TIE", "Lizard" },
            { "Spock", "Paper", "Spock", "Lizard", "TIE" },
        };

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
            // use gameRuleSet array and this method's parameters to get the outcome in string
            // (return "") is just placeholder so it doesn't error
            // return the string (from the gameRuleSet array)
            // good luck, I don't know what else to give you so you get the hard part I guess :)
            // feel free to just let me do it if you can't figure it out and I'll explain it on Monday or any other time
            // use this to see examples and learn: (https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays) ignore 3D arrays obviously, that is too much

            return "";
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
