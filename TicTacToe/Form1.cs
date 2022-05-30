namespace TicTacToe
{            /*
            1. If button clicked, then print "X" in button text.
            2. Button became unclickable
            3. Next button text when clicked print "O", then become unclickable
            4. Create player 1 win/ player 2 win pop up after the game
                (need to create player 1 and 2 then add corresponding symbol X/O 
                (maybe later))
             */
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void UpButton1_Click(object sender, EventArgs e)
        {
            UpButton1.Text = ("X");

            if (UpButton2.Text == "X")
                UpButton1.Text = ("O");

            else if (UpButton2.Text == "O")
                UpButton1.Text = ("X");

            else if (UpButton3.Text == "X")
                UpButton1.Text = ("O");
        }

        private void UpButton2_Click(object sender, EventArgs e)
        {
            UpButton2.Text = ("X");

            if (UpButton1.Text == "X")
                UpButton2.Text = ("O");

            else if (UpButton1.Text == "O")
                UpButton2.Text = ("X");

            else if (UpButton3.Text == "X")
                UpButton2.Text = ("O");

        }

        private void UpButton3_Click(object sender, EventArgs e)
        {
            UpButton3.Text = ("X");

            if (UpButton1.Text == "X")
                UpButton3.Text = ("O");

            else if (UpButton1.Text == "O")
                UpButton3.Text = ("X");

            else if (UpButton2.Text == "X")
                UpButton3.Text = ("O");

            else if (UpButton2.Text == "O")
                UpButton3.Text = ("X");
            
        }
    }
}