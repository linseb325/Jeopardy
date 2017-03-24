using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: This is the screen which is displayed upon launching the application. Allows the user to navigate to one of two different instruction screens or begin a game.

namespace Jeopardy
{
    public partial class HomeScreen : Form
    {

        private System.Media.SoundPlayer soundPlayer;

        public HomeScreen()
        {
            InitializeComponent();
            Core.homeScreen = this;

            String soundPath = Application.StartupPath + @"\JEOPARDY MUSIC HERE!\JeopardyTheme.wav";
            this.soundPlayer = new System.Media.SoundPlayer(soundPath);
            this.soundPlayer.PlayLooping();
            
        }

        private void playButton_Click(object sender, EventArgs e) // PLAY BUTTON CLICKED
        {
            SettingsSelectScreen ss = new SettingsSelectScreen();
            ss.Show();
            this.Hide();
        }

        private void instructionsButton_Click(object sender, EventArgs e) // INSTRUCTIONS BUTTON CLICKED
        {
            InstructionsScreen ins = new InstructionsScreen();
            ins.Show();
            this.Hide();
        }

        private void customQuestionsButton_Click(object sender, EventArgs e) // CUSTOM QUESTION FORMAT REQUIREMENTS BUTTON CLICKED
        {
            FormatRequirementsScreen frs = new FormatRequirementsScreen();
            frs.Show();
            this.Hide();
        }

        private void HomeScreen_VisibleChanged(object sender, EventArgs e) // FORM WAS EITHER HIDDEN OR SHOWN
        {
            if (this.Visible) // Play the music and clear out the current game and category data because the form is shown.
            {
                Core.currentGame = null;
                Core.allCategories = null;
                this.soundPlayer.PlayLooping();
            }
            else this.soundPlayer.Stop(); // Otherwise, stop the music because the form is hidden.
        }
    }
}
