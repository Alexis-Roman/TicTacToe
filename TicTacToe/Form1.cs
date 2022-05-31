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
            
            UpButton1.Enabled = false;
            
        }

        private void UpButton2_Click1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpButton2_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                UpButton2.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton2.Text = ("O");
                Turn++;
            }

            UpButton2.Enabled = false;
        }

        private void UpButton3_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                UpButton3.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton3.Text = ("O");
                Turn++;
            }

            UpButton3.Enabled = false;
        }

        private void CenterButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                CenterButton1.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton1.Text = ("O");
                Turn++;
            }

            CenterButton1.Enabled = false;
        }

        private void CenterButton2_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                CenterButton2.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton2.Text = ("O");
                Turn++;
            }

            CenterButton2.Enabled = false;
        }

        private void CenterButton3_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                CenterButton3.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton3.Text = ("O");
                Turn++;
            }

            CenterButton3.Enabled = false;
        }

        private void DownButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                DownButton1.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton1.Text = ("O");
                Turn++;
            }

            DownButton1.Enabled = false;
        }

        private void DownButton2_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                DownButton2.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton2.Text = ("O");
                Turn++;
            }

            DownButton2.Enabled = false;
        }

        private void DownButton3_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                DownButton3.Text = ("X");
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton3.Text = ("O");
                Turn++;
            }

            DownButton3.Enabled = false;
        }
    }
}