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
        int Turn = 1;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void UpButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn ==5 || Turn == 7 || Turn == 9)
            {
                UpButton1.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton1.Text = ("O");
                Turn++;
            }
            else if (UpButton2.Text == "O")
                UpButton1.Text = ("X");

            else if (UpButton3.Text == "X")
                UpButton1.Text = ("O");
            else
            { }
            UpButton1.Enabled = false;
        }

        private void UpButton2_Click1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpButton2_Click(object sender, EventArgs e)
        {
            UpButton2.Text = ("X");

            if (UpButton1.Text == "X" )
                UpButton2.Text = ("O");

            else if (UpButton1.Text == "O")
                UpButton2.Text = ("X");

            else if (UpButton3.Text == "X")
                UpButton2.Text = ("O");

        }

        private void UpButton3_Click(object sender, EventArgs e)
        {
            UpButton3.Text = ("X");
            
            if (UpButton1.Text == "X" && UpButton2.Text == "O")
                UpButton3.Text = ("X");

            else if (UpButton1.Text == "O")
                UpButton3.Text = ("X");

            else if (UpButton2.Text == "X")
                UpButton3.Text = ("O");

            else if (UpButton2.Text == "O")
                UpButton3.Text = ("X");
            
        }

        private void CenterButton1_Click(object sender, EventArgs e)
        {
            CenterButton1.Text = ("X");
        }

        private void CenterButton2_Click(object sender, EventArgs e)
        {
            CenterButton2.Text = ("X");
        }

        private void CenterButton3_Click(object sender, EventArgs e)
        {
            CenterButton3.Text = ("X");
        }

        private void DownButton1_Click(object sender, EventArgs e)
        {
            DownButton1.Text = ("X");
        }

        private void DownButton2_Click(object sender, EventArgs e)
        {
            DownButton2.Text = ("X");
        }

        private void DownButton3_Click(object sender, EventArgs e)
        {
            DownButton3.Text = ("X");
        }
    }
}