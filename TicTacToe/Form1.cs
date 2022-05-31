namespace TicTacToe
{            /*
            4. Create player X win/ player O win pop up after the game
                (need to create player X and O then add corresponding symbol X/O 
                (maybe later))
            5. alternating label color for player X and O (try lang) 
             */
    public partial class TicTacToe : Form
    {
        byte Turn = 1;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void UpButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn ==5 || Turn == 7 || Turn == 9)
            {
                UpButton1.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton1.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
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
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
                
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton2.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            UpButton2.Enabled = false;
        }

        private void UpButton3_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                UpButton3.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton3.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            UpButton3.Enabled = false;
        }

        private void CenterButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                CenterButton1.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton1.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            CenterButton1.Enabled = false;
        }

        private void CenterButton2_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                CenterButton2.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton2.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            CenterButton2.Enabled = false;
        }

        private void CenterButton3_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                CenterButton3.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton3.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            CenterButton3.Enabled = false;
        }

        private void DownButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                DownButton1.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton1.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            DownButton1.Enabled = false;
        }

        private void DownButton2_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                DownButton2.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton2.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            DownButton2.Enabled = false;
        }

        private void DownButton3_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                DownButton3.Text = ("X");
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton3.Text = ("O");
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            DownButton3.Enabled = false;
        }

        private void Player2Label_Click(object sender, EventArgs e)
        {

        }
    }
}