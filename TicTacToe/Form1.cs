namespace TicTacToe
{            /*
                > Create player X win/ player O win pop up after the game
                (need to create player X and O then add corresponding symbol X/O 
                (maybe later))
                
                !!! Dapat may lalabas na messagebox saying player X or O win
                
                > 8 possibilities for winning 
             */
    public partial class TicTacToe : Form
    {
        byte Turn = 1;
        sbyte UpBut1, UpBut2, UpBut3, CenBut1, CenBut2, CenBut3, 
             DowBut1, DowBut2, DowBut3;
        
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void UpButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                UpButton1.Text = ("X");
                UpBut1 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton1.Text = ("O");
                UpBut1 = -1;
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            UpButton1.Enabled = false;
            //WINNER CODE 
            //8 winning possibility per player... so 15 na else if???
            //then else statement for draw
            //papalitan lang ==6 if O is the winner

            //3 possibility
            if (UpBut1 + UpBut2 + UpBut3 == 3 || CenBut1 + CenBut2 + CenBut3 == 3 ||
                DowBut1 + DowBut2 + DowBut3 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                    "Congratulations!",MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            //3 possibility
            else if (UpBut1 + CenBut1 + DowBut1 == 3 || UpBut2 + CenBut2 + DowBut2 == 3
                || UpBut3 + CenBut3 + DowBut3 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                   "Congratulations!", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            //2 possibility
            else if (UpBut1 + CenBut2 + DowBut3 == 3 || UpBut3 + CenBut2 + DowBut1 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                   "Congratulations!", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

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
                UpBut2 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;

            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton2.Text = ("O");
                UpBut2= -1;
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            UpButton2.Enabled = false;

            if (UpBut1 + UpBut2 + UpBut3 == 3 || CenBut1 + CenBut2 + CenBut3 == 3 ||
                DowBut1 + DowBut2 + DowBut3 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                    "Congratulations!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            //3 possibility
            else if (UpBut1 + CenBut1 + DowBut1 == 3 || UpBut2 + CenBut2 + DowBut2 == 3
                || UpBut3 + CenBut3 + DowBut3 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                   "Congratulations!", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            //2 possibility
            else if (UpBut1 + CenBut2 + DowBut3 == 3 || UpBut3 + CenBut2 + DowBut1 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                   "Congratulations!", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void UpButton3_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                UpButton3.Text = ("X");
                UpBut3 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                UpButton3.Text = ("O");
                UpBut3 = -1;
                PlayerXLabel.BackColor = Color.LightPink;
                PlayerOLabel.BackColor = Color.White;
                Turn++;
            }

            UpButton3.Enabled = false;

            if (UpBut1 + UpBut2 + UpBut3 == 3 || CenBut1 + CenBut2 + CenBut3 == 3 ||
                DowBut1 + DowBut2 + DowBut3 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                    "Congratulations!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            //3 possibility
            else if (UpBut1 + CenBut1 + DowBut1 == 3 || UpBut2 + CenBut2 + DowBut2 == 3
                || UpBut3 + CenBut3 + DowBut3 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                   "Congratulations!", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            //2 possibility
            else if (UpBut1 + CenBut2 + DowBut3 == 3 || UpBut3 + CenBut2 + DowBut1 == 3)
                MessageBox.Show("Player X wins! Thank you for playing.",
                   "Congratulations!", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void CenterButton1_Click(object sender, EventArgs e)
        {
            if (Turn == 1 || Turn == 3 || Turn == 5 || Turn == 7 || Turn == 9)
            {
                CenterButton1.Text = ("X");
                CenBut1 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton1.Text = ("O");
                CenBut1 = -1;
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
                CenBut2 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton2.Text = ("O");
                CenBut2 = -1;
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
                CenBut3 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                CenterButton3.Text = ("O");
                CenBut3 = -1;
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
                DowBut1 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton1.Text = ("O");
                DowBut1 = -1;
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
                DowBut2 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton2.Text = ("O");
                DowBut2 = -1;
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
                DowBut3 = 1;
                PlayerXLabel.BackColor = Color.White;
                PlayerOLabel.BackColor = Color.LightPink;
                Turn++;
            }

            else if (Turn == 2 || Turn == 4 || Turn == 6 || Turn == 8)
            {
                DownButton3.Text = ("O");
                DowBut3 = -1; 
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
    
