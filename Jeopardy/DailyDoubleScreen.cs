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
// Purpose: Appears when the daily double is selected. Allows the player to wager an amount of points before displaying the question to the screen and allowing the player to answer.

namespace Jeopardy
{
    public partial class DailyDoubleScreen : Form
    {

        private Question theQuestion;
        private System.Timers.Timer timerProgressBar;
        private int wageredPoints;

        private int countProgressBar;

        public DailyDoubleScreen(Question currQuestion)
        {
            InitializeComponent();

            this.countProgressBar = 0;
            this.Text = "Daily Double for " + Core.currentGame.ControllingPlayer.Name + "!";

            this.theQuestion = currQuestion;
            this.playerIdentifierLabel.Text = "Question for: " + Core.currentGame.ControllingPlayer.Name;
            this.questionLabel.Text = this.theQuestion.TheQuestion;
            this.formatLabel.Text = this.theQuestion.TheFormat;

            this.timerProgressBar = new System.Timers.Timer(400);           // Each time this timer elapses, the progress bar increments by two percent, giving the player 20 seconds to read the question and submit an answer.
            this.timerProgressBar.Elapsed += timerProgressBar_Elapsed;

            if (Core.currentGame.ControllingPlayer.Score <= 5) // The minimum wager is five points, so players whose current score is less than or equal to five are forced to wager five points.
            {
                this.maxWagerLabel.Text = "Max Wager: 5";
                this.wagerTextBox.Text = "5";
                this.wagerTextBox.Enabled = false;
            }
            else
            {
                this.maxWagerLabel.Text = "Max Wager: " + Core.currentGame.ControllingPlayer.Score;
            }
        }

        void timerProgressBar_Elapsed(object sender, System.Timers.ElapsedEventArgs e) // Increment the progress bar by two percent.
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.countProgressBar++;
                    this.progressBar.Increment(2);
                    if(this.countProgressBar == 52) // This means the progress bar is full, so the player is out of time to answer. This event must fire 52 times rather than 50 before time expires because of the slight lag in updating the UI.
                    {
                        this.timerProgressBar.Stop();
                        MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheFormat + " " + this.theQuestion.TheAnswer + "?", "Showing Correct Answer");
                        Core.currentGame.GameBoardScreen.Show();
                        this.Close();
                    }
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine("Caught a NotImplementedException when the timer for the player to answer elapsed!");
            }
        }

        private void wagerButton_Click(object sender, EventArgs e) // User clicked the ready button, so make sure the input and wager are valid, show the question, and start the timer.
        {
            if (this.wagerTextBox.Text.Equals("")) // The user didn't type anything in the wager text box!
            {
                MessageBox.Show("Input number of points to wager!", "Error");
            }
            else if (!this.wagerTextBox.Text.All(Char.IsDigit)) // The user typed a character which is not a digit.
            {
                MessageBox.Show("The wager must be a positive whole number!", "Error");
            }
            else // Otherwise, it's time to check to make sure the wager is valid.
            {
                try
                {
                    if(!this.wagerTextBox.Enabled) // The user doesn't have enough points to make a wager other than 5 points.
                    {
                        this.wageredPoints = 5;
                    }
                    else // Otherwise, get the number of points wagered.
                    {
                        this.wageredPoints = Convert.ToInt32(this.wagerTextBox.Text);
                    }

                    if(this.wageredPoints < 5 || (this.wageredPoints > Core.currentGame.ControllingPlayer.Score && Core.currentGame.ControllingPlayer.Score > 5)) // The wager is invalid for the player's current score.
                    {
                        MessageBox.Show("Invalid wager! The wager may range between five points and the player's current score!", "Error");
                    }
                    else // Initially subtract the wager and allow the player to answer.
                    {
                        Core.currentGame.ControllingPlayer.subtractPoints(this.wageredPoints);
                        this.showAnswerControls();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Wager must be a positive whole number between five and the player's current score!", "Error");
                }
            }
        }

        private void submitAnswerButton_Click(object sender, EventArgs e) // PLAYER SUBMITTED AN ANSWER
        {
            this.timerProgressBar.Stop();
            this.progressBar.Hide();
            if(!this.answerInputTextBox.Text.Equals("") && this.answerInputTextBox.Text.ToLowerInvariant().Equals(this.theQuestion.TheAnswer.ToLowerInvariant())) // The answer is correct, so double the wagered points and add to the player's score.
            {
                Core.currentGame.ControllingPlayer.addPoints(2 * this.wageredPoints);
                MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheFormat + " " + this.theQuestion.TheAnswer + "?", "CORRECT!");
                Core.currentGame.GameBoardScreen.Show();
                this.Close();
            }
            else // Otherwise, the player's answer is incorrect, so show the correct answer and return to the board. Points were already subtracted from the player's score when wagered.
            {
                MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheFormat + " " + this.theQuestion.TheAnswer + "?", "INCORRECT!");
                Core.currentGame.GameBoardScreen.Show();
                this.Close();
            }
        }

        private void showAnswerControls() // Hides the wagering controls and shows the answer controls, starting the timer as well.
        {
            this.inputWagerLabel.Hide();
            this.wagerTextBox.Hide();
            this.wagerButton.Hide();
            this.maxWagerLabel.Hide();

            this.questionLabel.Show();
            this.formatLabel.Show();
            this.answerInputTextBox.Show();
            this.submitAnswerButton.Show();
            this.progressBar.Show();
            this.timerProgressBar.Start();
        }

        private void wagerTextBox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = this.wagerButton;
        }

        private void wagerTextBox_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
        }

        private void answerInputTextBox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = this.submitAnswerButton;
        }

        private void answerInputTextBox_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
        }
    }
}
