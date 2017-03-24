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
// Purpose: Allows user to select settings for the game to be played.

namespace Jeopardy
{
    public partial class SettingsSelectScreen : Form
    {
        public SettingsSelectScreen()
        {
            InitializeComponent();
        }

        private void numPlayersPicker_ValueChanged(object sender, EventArgs e) // Shows and hides the third player's name input controls depending on the selected number of players.
        {
            if((sender as NumericUpDown).Value.Equals(2))
            {
                this.player3NameLabel.Visible = false;
                this.player3TextBox.Visible = false;
                this.player3CheckBox.Visible = false;
                this.player3CheckBox.Checked = false;
            }
            else if((sender as NumericUpDown).Value.Equals(3))
            {
                this.player3NameLabel.Visible = true;
                this.player3TextBox.Visible = true;
                this.player3CheckBox.Visible = true;
            }
        }

        private void playGameButton_Click(object sender, EventArgs e) // PLAY GAME BUTTON WAS CLICKED
        {
            String path = this.filePathTextBox.Text;

            if (!this.filePathTextBox.Text.Equals("Use default pre-loaded categories.") && this.openFileDialog.FileName.Length >= 4 && !this.openFileDialog.FileName.Substring(this.openFileDialog.FileName.Length - 4, 4).Equals(".txt"))
            {
                MessageBox.Show("Must select a text file!");
            }
            else // Otherwise, a .txt file path has been selected.
            {
                if (path.Equals("Use default pre-loaded categories."))
                {
                    path = Application.StartupPath + @"\DEFAULT QUESTION TEXT FILE HERE!\JeopardyQuestions.txt";
                }
                else
                {
                    path = this.filePathTextBox.Text;
                }

                try
                {
                    Parser p = new Parser(path);
                    if(!p.parse())
                    {
                        MessageBox.Show("There was a parsing error! Check the text file to make sure it conforms to the format requirements (accessible from the home page)!", "Error");
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Could not find a file to parse at the given path!", "Error");
                    return;
                }
            }

            // ERROR CHECKING FOR PLAYER TEXT BOXES, CHECK BOXES, AND CATEGORY COUNT
            if(this.player1TextBox.Text.Equals(""))
            {
                MessageBox.Show("Player 1 must have a name!", "Error");
            }
            else if(this.player2TextBox.Text.Equals(""))
            {
                MessageBox.Show("Player 2 must have a name!", "Error");
            }
            else if(this.numPlayersPicker.Value.Equals(3) && this.player3TextBox.Text.Equals(""))
            {
                MessageBox.Show("Player 3 must have a name!", "Error");
            }
            else if(this.numPlayerCheckBoxesChecked() > 1)
            {
                MessageBox.Show("Only one player may have control of the board!", "Error");
            }
            else if(this.randomizeControlCheckBox.Checked && this.numPlayerCheckBoxesChecked() > 0)
            {
                MessageBox.Show("Both \"randomize\" and player option(s) for initial control of the board are selected!", "Error");
            }
            else if(!this.randomizeControlCheckBox.Checked && this.numPlayerCheckBoxesChecked() == 0)
            {
                MessageBox.Show("Someone has to start with control of the board!", "Error");
            }
            else if (Core.allCategories.Count() < 5)
            {
                MessageBox.Show("There are not enough categories loaded into the game! See the instructions on how to add custom questions (accessible from the home page).", "Error");
            }
            else // If we enter this else statement, the user entered the settings correctly, and we can initialize the game.
            {
                Boolean randomControl = false;
                int playerToControlNumber = -1;
                if(this.randomizeControlCheckBox.Checked)
                {
                    randomControl = true;
                }
                else
                {
                    if(this.player1CheckBox.Checked)
                    {
                        playerToControlNumber = 1;
                    }
                    else if(this.player2CheckBox.Checked)
                    {
                        playerToControlNumber = 2;
                    }
                    else if(this.numPlayersPicker.Value == 3 && this.player3CheckBox.Checked)
                    {
                        playerToControlNumber = 3;
                    }
                }

                if(this.numPlayersPicker.Value == 3) // If it's a three player game, initialize a three player game.
                {
                    Core.currentGame = new Game(this.player1TextBox.Text, this.player2TextBox.Text, this.player3TextBox.Text, randomControl, playerToControlNumber);
                }
                else // Otherwise, it's a two player game, initialize a two player game.
                {
                    Core.currentGame = new Game(this.player1TextBox.Text, this.player2TextBox.Text, randomControl, playerToControlNumber);
                }

                Core.currentGame.GameBoardScreen = new GameBoardScreen();
                Core.currentGame.GameBoardScreen.Show();
                this.Close();
            }
        }

        private void randomizeControlCheckBox_CheckedChanged(object sender, EventArgs e) // Unchecks the player check boxes when the "randomize" check box is checked.
        {
            if(this.randomizeControlCheckBox.Checked)
            {
                this.player1CheckBox.Checked = false;
                this.player2CheckBox.Checked = false;
                this.player3CheckBox.Checked = false;
            }
        }

        private void playerCheckBoxChanged(object sender, EventArgs e) // Unchecks the "randomize" check box when one of the player check boxes is checked.
        {
            if((sender as CheckBox).Checked)
            {
                this.randomizeControlCheckBox.Checked = false;
            }
        }

        private int numPlayerCheckBoxesChecked() // Returns the number of player board control check boxes which are checked.
        {
            int totalToReturn = 0;
            if(this.player1CheckBox.Checked)
            {
                totalToReturn++;
            }
            if(this.player2CheckBox.Checked)
            {
                totalToReturn++;
            }
            if(this.player3CheckBox.Checked)
            {
                totalToReturn++;
            }
            return totalToReturn;
        }

        private void returnToHomeScreenButton_Click(object sender, EventArgs e) // RETURN TO HOME SCREEN BUTTON CLICKED
        {
            Core.currentGame = null;
            Core.allCategories = null;
            Core.homeScreen.Show();
            this.Close();
        }

        private void browseButton_Click(object sender, EventArgs e) // BROWSE BUTTON CLICKED
        {
            this.openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) // OK BUTTON CLICKED IN OPEN FILE DIALOG
        {
            this.filePathTextBox.Text = this.openFileDialog.FileName;
        }

        private void SettingsSelectScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if(!Core.currentGame.Equals(null))
                {
                    // Do nothing if the form was closed because of a button press.
                }
            }
            catch(Exception ex)
            {
                Core.homeScreen.Show();
                Console.WriteLine("Caught exception in settingSelectScreen_FormClosed!");
            }
        }

    }
}
