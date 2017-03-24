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
// Purpose: Displays the final score to the screen upon completion of the game. Allows user to navigate back to the home screen when finished viewing the final scoreboard.

namespace Jeopardy
{
    public partial class GameOverScreen : Form
    {
        public GameOverScreen()
        {
            InitializeComponent();

            this.player1NameLabel.Text = Core.currentGame.Player1.Name;
            this.player2NameLabel.Text = Core.currentGame.Player2.Name;
            this.player1ScoreLabel.Text = Core.currentGame.Player1.Score.ToString();
            this.player2ScoreLabel.Text = Core.currentGame.Player2.Score.ToString();

            if(Core.currentGame.NumPlayers == 2) // The game was a two player game, so hide the third player's scoreboard panel and move the second player's panel out to make things look more centered.
            {
                this.player3NameLabel.Hide();
                this.player3ScoreLabel.Hide();
                this.player2NameLabel.Location = this.player3NameLabel.Location;
                this.player2ScoreLabel.Location = this.player3ScoreLabel.Location;
            }
            else // Otherwise, the game was a three player game, so configure the third player's panel.
            {
                this.player3NameLabel.Text = Core.currentGame.Player3.Name;
                this.player3ScoreLabel.Text = Core.currentGame.Player3.Score.ToString();
            }
        }

        private void returnHomeButton_Click(object sender, EventArgs e) // The user clicked the button to return to the home screen, so close the final scoreboard.
        {
            Core.homeScreen.Show();
            this.Close();
        }
    }
}
