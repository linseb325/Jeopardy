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
// Purpose: Displays the game instructions to the user.

namespace Jeopardy
{
    public partial class InstructionsScreen : Form
    {
        public InstructionsScreen()
        {
            InitializeComponent();

            this.instructionsLabel.Text = "Settings Select\n  - Number of players may be either two or three.\n  - A player's name may be up to 18 characters in length.\n  - One player must begin the game with control of the board, so check either one player check box or the \"randomize\" check box in order to set initial board control.\n  - A small set of default categories is pre-loaded. To play with these categories, do not browse for text files.\n  - To play with custom categories, browse for a text file using the \"Browse...\" button. See the format requirements for custom question files (accessible from the Home Page).\n\nGameplay\n  - The game board consists of a five-by-five grid. For any given turn, the player with control of the board will select a question by clicking the corresponding grid box. Once the game gets rolling, the controlling player will be the last player to correctly answer a question.\n  - When a grid box is clicked, the corresponding question appears after a short delay. Once the question appears, players may push their \"buzzers\" to answer the question.\n  - A player's buzzer is a key on the keyboard. To remind players which keys are their buzzers, each eligible player's buzzer will appear on the screen whenever buzzer pushes are allowed. For both two and three player games, player 1’s buzzer is the \"A\" key. For two player games, player 2's buzzer is the semicolon key. For three player games, player 2’s buzzer is the \"B\" key, and player 3’s buzzer is the semicolon key.\n  - If a player answers incorrectly, he/she will lose the question’s point value and be ineligible to answer the current question, but remaining players may attempt to buzz in and answer.\n  - If the controlling player selects the daily double, he/she will wager a portion of his/her current score. Wagers may be as low as five points; if a player has less than five points, his/her wager will default to five points. Only the player who selected the question may answer the question once it appears. If he/she does not answer correctly, the wager will be deducted. If he/she submits the correct answer, the wager will be added to his/her score.\n  - People are smarter than computers. For example, the application does not know that \"Concordia University Wisconsin\" and \"CUW\" are the same answer and will check submitted answers against whichever answer is in the uploaded text file. With the agreement of all players, scores may be manually adjusted for situations such as these by using the button located at the bottom of the game board screen.\n  - The game is over once all 25 questions have been answered.";
        }

        private void InstructionsScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Core.homeScreen.Show();
        }
    }
}
