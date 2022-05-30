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
            
        }

        private void UpButton2_Click(object sender, EventArgs e)
        {
            if (UpButton1.Text == "X")
                UpButton2.Text = ("O");
            else
                UpButton2.Text = ("X");
        }
    }
}