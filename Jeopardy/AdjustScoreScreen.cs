using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Allows users to manually adjust player scores.

namespace Jeopardy
{
    public partial class AdjustScoreScreen : Form
    {
        public AdjustScoreScreen()
        {
            InitializeComponent();

            this.listBoxSelectPlayer.Items.Add(Core.currentGame.Player1.Name);
            this.listBoxSelectPlayer.Items.Add(Core.currentGame.Player2.Name);
            this.player1NameLabel.Text = Core.currentGame.Player1.Name;
            this.player2NameLabel.Text = Core.currentGame.Player2.Name;
            this.player1ScoreLabel.Text = Core.currentGame.Player1.Score.ToString();
            this.player2ScoreLabel.Text = Core.currentGame.Player2.Score.ToString();

            if(Core.currentGame.NumPlayers == 3) // For a three player game...
            {
                this.listBoxSelectPlayer.Items.Add(Core.currentGame.Player3.Name);
                this.player3NameLabel.Text = Core.currentGame.Player3.Name;
                this.player3ScoreLabel.Text = Core.currentGame.Player3.Score.ToString();
            }
            else // For a two player game...
            {
                this.player3NameLabel.Visible = false;
                this.player3ScoreLabel.Visible = false;
                this.player2NameLabel.Location = this.player3NameLabel.Location;
                this.player2ScoreLabel.Location = this.player3ScoreLabel.Location;
            }

            this.listBoxSelectPlayer.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e) // Before adding the adjustment, we have to make sure the user input is a positive whole number.
        {
            if(this.numPointsTextBox.Text.Equals(""))
            {
                MessageBox.Show("Input number of points to add!", "Error");
            }
            else if(!this.numPointsTextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Number of points must be a positive whole number!", "Error");
            }
            else
            {
                try
                {
                    if (this.getSelectedPlayer().Score + Convert.ToInt32(this.numPointsTextBox.Text) > 99999)
                    {
                        MessageBox.Show("Scores may not be higher than 99,999 points!", "Score too high!");
                    }
                    else
                    {
                        this.getSelectedPlayer().addPoints(Convert.ToInt32(this.numPointsTextBox.Text));
                        this.updateBothScoreboards();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Number of points must be a positive whole number!", "Error");
                }
            }
        }

        private void subtractButton_Click(object sender, EventArgs e) // Before subtracting the adjustment, we have to make sure the user input is a positive whole number.
        {
            if (this.numPointsTextBox.Text.Equals(""))
            {
                MessageBox.Show("Input number of points to subtract!", "Error");
            }
            else if (!this.numPointsTextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Number of points must be a positive whole number!", "Error");
            }
            else
            {
                try
                {
                    if(this.getSelectedPlayer().Score - Convert.ToInt32(this.numPointsTextBox.Text) < -99999)
                    {
                        MessageBox.Show("Scores may not be lower than -99,999 points!", "Score too low!");
                    }
                    else
                    {
                        this.getSelectedPlayer().subtractPoints(Convert.ToInt32(this.numPointsTextBox.Text));
                        this.updateBothScoreboards();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Number of points must be a positive whole number!", "Error");
                }
            }
        }

        private Player getSelectedPlayer()
        {
            if (this.listBoxSelectPlayer.SelectedItem.Equals(Core.currentGame.Player1.Name))
            {
                return Core.currentGame.Player1;
            }
            else if (this.listBoxSelectPlayer.SelectedItem.Equals(Core.currentGame.Player2.Name))
            {
                return Core.currentGame.Player2;
            }
            else
            {
                return Core.currentGame.Player3;
            }
        }

        private void updateBothScoreboards()
        {
            Core.currentGame.GameBoardScreen.updateScoreBoard();

            this.player1ScoreLabel.Text = Core.currentGame.Player1.Score.ToString();
            this.player2ScoreLabel.Text = Core.currentGame.Player2.Score.ToString();
            if(Core.currentGame.NumPlayers == 3)
            {
                this.player3ScoreLabel.Text = Core.currentGame.Player3.Score.ToString();
            }
        }
    }
}
