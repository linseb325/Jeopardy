using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Displays a question selected from the game board and allows users to "buzz in" and answer the question.

namespace Jeopardy
{
    public partial class SelectedQuestionScreen : Form
    {
        private Question theQuestion;
        private Boolean keyPressesEnabled;
        private Player playerToAnswer;
        private Player playerWhoAnsweredIncorrectly;
        private Player secondPlayerWhoAnsweredIncorrectly;
        private System.Timers.Timer timerShowQuestion;
        private System.Timers.Timer timerPlayerToAnswer;
        private System.Timers.Timer timerAllPlayersToAnswer;
        private System.Timers.Timer timerProgressBarStep;
        private Player nullPlaceholderPlayer;
        private Boolean shouldKillThread;

        public SelectedQuestionScreen(Question selectedQuestion)
        {
            InitializeComponent();

            this.keyPressesEnabled = false;

            this.shouldKillThread = false;

            this.nullPlaceholderPlayer = new Player("null");
            this.playerWhoAnsweredIncorrectly = this.nullPlaceholderPlayer;
            this.secondPlayerWhoAnsweredIncorrectly = this.nullPlaceholderPlayer;

            this.timerShowQuestion = new System.Timers.Timer(2000);                 // Two second delay between the form loading and the question being shown.
            this.timerShowQuestion.AutoReset = false;
            this.timerShowQuestion.Elapsed += timerShowQuestion_Elapsed;
            this.timerPlayerToAnswer = new System.Timers.Timer(15000);              // 15 seconds for a player to submit an answer.
            this.timerPlayerToAnswer.AutoReset = false;
            this.timerPlayerToAnswer.Elapsed += timerPlayerToAnswer_Elapsed;
            this.timerAllPlayersToAnswer = new System.Timers.Timer(7000);           // Seven seconds for all players to buzz in.
            this.timerAllPlayersToAnswer.AutoReset = false;
            this.timerAllPlayersToAnswer.Elapsed += timerAllPlayersToAnswer_Elapsed;
            this.timerProgressBarStep = new System.Timers.Timer(300);               // Each time this timer expires, the progress bar will move two percent.
            this.timerProgressBarStep.Elapsed += timerProgressBarStep_Elapsed;

            this.theQuestion = selectedQuestion;
            this.Text = "For " + this.theQuestion.PointValue + " points...";
            this.questionLabel.Text = selectedQuestion.TheQuestion;
            this.formatLabel.Text = selectedQuestion.TheFormat + "...";

            this.initializeKeyStuff();
            this.timerShowQuestion.Start();
        }

        public void showQuestion() // Shows the question and enables key presses.
        {
            this.questionLabel.Visible = true;
            this.keyPressesEnabled = true;
            this.showKeyStuff();

            this.timerAllPlayersToAnswer.Start();
        }

        public void initializeKeyStuff() // Sets up the UI elements which specify user buzzers.
        {
            this.player1NameLabel.Text = Core.currentGame.Player1.Name;
            this.player1KeyLabel.Text = "A";
            this.player2NameLabel.Text = Core.currentGame.Player2.Name;
            if(Core.currentGame.NumPlayers == 2)
            {
                this.player2KeyLabel.Text = ";";
                this.player2NameLabel.Location = this.player3NameLabel.Location;
                this.player2KeyLabel.Location = this.player3KeyLabel.Location;
            }
            else
            {
                this.player2KeyLabel.Text = "B";
                this.player3NameLabel.Text = Core.currentGame.Player3.Name;
                this.player3KeyLabel.Text = ";";
            }
        }

        public void showKeyStuff() // Shows the keys corresponding to the players who can still answer the question.
        {
            if(!this.playerAlreadyAnswered(Core.currentGame.Player1))
            {
                this.player1NameLabel.Visible = true;
                this.player1KeyLabel.Visible = true;
            }
            if(!this.playerAlreadyAnswered(Core.currentGame.Player2))
            {
                this.player2NameLabel.Visible = true;
                this.player2KeyLabel.Visible = true;
            }
            if(Core.currentGame.NumPlayers == 3 && !this.playerAlreadyAnswered(Core.currentGame.Player3))
            {
                this.player3NameLabel.Visible = true;
                this.player3KeyLabel.Visible = true;
            }
        }

        public void hideKeyStuff() // Hides the keys.
        {
            this.player1NameLabel.Visible = false;
            this.player1KeyLabel.Visible = false;
            this.player2NameLabel.Visible = false;
            this.player2KeyLabel.Visible = false;
            this.player3NameLabel.Visible = false;
            this.player3KeyLabel.Visible = false;
        }

        public void showAnswerControls(Player playerSelected) // Shows the controls used to answer the question, enabling the given player to answer. Starts the timer and progress bar as well.
        {
            this.keyPressesEnabled = false;
            this.playerToAnswer = playerSelected;
            this.playerIdentifierLabel.Text = "Question for: " + playerSelected.Name;
            this.playerIdentifierLabel.Visible = true;
            this.formatLabel.Visible = true;
            this.answerInputTextBox.Visible = true;
            this.submitAnswerButton.Visible = true;
            this.progressBar.Visible = true;
            this.progressBarLabel.Visible = true;
            this.answerInputTextBox.Focus();
            this.hideKeyStuff();
            // START ANSWER TIMER
            this.timerPlayerToAnswer.Start();
            this.progressBar.Value = 8;
            this.timerProgressBarStep.Start();
        }

        private void hideAnswerControls() // Hides the answer controls and re-enables key presses.
        {
            this.keyPressesEnabled = true;
            this.playerIdentifierLabel.Visible = false;
            this.formatLabel.Visible = false;
            this.answerInputTextBox.Text = "";
            this.answerInputTextBox.Visible = false;
            this.submitAnswerButton.Visible = false;
            this.progressBar.Visible = false;
            this.progressBarLabel.Visible = false;
            this.showKeyStuff();
            this.timerAllPlayersToAnswer.Start();
        }

        void timerPlayerToAnswer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) // THE PLAYER RAN OUT OF TIME TO ANSWER!
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.timerProgressBarStep.Stop();
                    this.progressBar.Value = 0;
                    this.playerToAnswer.subtractPoints(this.theQuestion.PointValue);

                    if (this.playerWhoAnsweredIncorrectly.Equals(this.nullPlaceholderPlayer)) // This would indicate that the player is the first to attempt to answer.
                    {
                        this.playerWhoAnsweredIncorrectly = this.playerToAnswer;
                        this.hideAnswerControls();
                    }
                    else if (this.secondPlayerWhoAnsweredIncorrectly.Equals(this.nullPlaceholderPlayer)) // This would indicate that the player is the second to attempt to answer.
                    {
                        if(Core.currentGame.NumPlayers == 2) // In a two-player game, the second player to answer is the last player to answer.
                        {
                            this.shouldKillThread = true;
                            MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheAnswer, "Showing Correct Answer");
                            Core.currentGame.GameBoardScreen.Show();
                            this.Close();
                        }
                        else
                        {
                            this.secondPlayerWhoAnsweredIncorrectly = this.playerToAnswer;
                            this.hideAnswerControls();
                        }
                    }
                    else // Otherwise, the player is the third and final player to attempt to answer. Reaching this block would also imply that it is a three player game.
                    {
                        this.shouldKillThread = true;
                        MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheAnswer, "Showing Correct Answer");
                        Core.currentGame.GameBoardScreen.Show();
                        this.Close();
                    }
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine("Caught a NotImplementedException when the timer for the player to answer elapsed!");
                Console.WriteLine(ex.Message);
            }
        }

        void timerProgressBarStep_Elapsed(object sender, System.Timers.ElapsedEventArgs e) // Increments the progress bar by 2 percent every .3 seconds.
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.progressBar.Increment(2);
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught notImplementedException when progress bar timer elapsed!");
                Console.WriteLine(ex.Message);
            }
        }

        void timerShowQuestion_Elapsed(object sender, System.Timers.ElapsedEventArgs e) // Displays the current question to the screen after a short interval.
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.showQuestion();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught a NotImplementedException when showing the question!");
                Console.WriteLine(ex.Message);
            }
        }

        void timerAllPlayersToAnswer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) // NOBODY HIT HIS BUZZER!
        {
            if(this.shouldKillThread) // Added on 5.9.16 to ensure the answer isn't displayed again in a message box after returning to the game board screen. This was an issue at the time.
            {
                return;
            }
            else
            {
                try
                {
                    if(!this.IsHandleCreated) // Was catching an InvalidOperationException because the window handle wasn't created. Added this block on 5.9.16.
                    {
                        this.CreateHandle();
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        this.keyPressesEnabled = false;
                        MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheAnswer, "Showing Correct Answer");
                        Core.currentGame.GameBoardScreen.Show();
                        this.Close();
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Caught a NotImplementedException when timerAllPlayersToAnswer elapsed!");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void keyWasPressed(object sender, KeyEventArgs e) // ANY KEY WAS PRESSED
        {
            if (this.keyPressesEnabled.Equals(true))
            {
                if (e.KeyCode == Keys.A || (e.KeyCode == Keys.B && Core.currentGame.NumPlayers == 3) || e.KeyCode == Keys.OemSemicolon) // Checks first to see if it's a valid key press for the current game.
                {
                    this.keyPressesEnabled = false;
                    if (e.KeyCode == Keys.A)
                    {
                        if (!this.playerAlreadyAnswered(Core.currentGame.Player1))
                        {
                            this.timerAllPlayersToAnswer.Stop();
                            this.playerToAnswer = Core.currentGame.Player1;
                            this.showAnswerControls(Core.currentGame.Player1);
                        }
                        else this.keyPressesEnabled = true;
                    }
                    else if (e.KeyCode == Keys.OemSemicolon)
                    {
                        if (Core.currentGame.NumPlayers == 2 && !this.playerAlreadyAnswered(Core.currentGame.Player2))
                        {
                            this.timerAllPlayersToAnswer.Stop();
                            this.playerToAnswer = Core.currentGame.Player2;
                            this.showAnswerControls(Core.currentGame.Player2);
                        }
                        else if (Core.currentGame.NumPlayers == 3 && !this.playerAlreadyAnswered(Core.currentGame.Player3))
                        {
                            this.timerAllPlayersToAnswer.Stop();
                            this.playerToAnswer = Core.currentGame.Player3;
                            this.showAnswerControls(Core.currentGame.Player3);
                        }
                        else this.keyPressesEnabled = true; // If the player already answered, re-enables key presses.
                    }
                    else if (!this.playerAlreadyAnswered(Core.currentGame.Player2)) // At this point, we know that the "B" key was pressed.
                    {
                        this.timerAllPlayersToAnswer.Stop();
                        this.playerToAnswer = Core.currentGame.Player2;
                        this.showAnswerControls(Core.currentGame.Player2);
                    }
                    else
                    {
                        this.keyPressesEnabled = true;
                    }
                }
                else // If it's not a valid key press, keeps key presses enabled and listens for another key press.
                {
                    this.keyPressesEnabled = true;
                }
            }
        }

        private void submitAnswerButton_Click(object sender, EventArgs e) // PLAYER SUBMITTED AN ANSWER
        {

            this.timerAllPlayersToAnswer.Stop();
            this.timerPlayerToAnswer.Stop();
            this.timerProgressBarStep.Stop();
            this.progressBar.Value = 0;
            if(!this.answerInputTextBox.Text.Equals("") && this.answerInputTextBox.Text.ToLowerInvariant().Equals(this.theQuestion.TheAnswer.ToLowerInvariant())) // The player answered correctly.
            {
                this.playerToAnswer.addPoints(this.theQuestion.PointValue);
                Core.currentGame.ControllingPlayer = this.playerToAnswer;
                this.shouldKillThread = true;
                MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheFormat + " " + this.theQuestion.TheAnswer + "?", "CORRECT!");
                Core.currentGame.GameBoardScreen.Show();
                this.Close();
            }
            else // The player answered incorrectly.
            {
                this.playerToAnswer.subtractPoints(this.theQuestion.PointValue);

                if(Core.currentGame.NumPlayers == 3) // For three player games...
                {
                    if(this.playerWhoAnsweredIncorrectly.Equals(this.nullPlaceholderPlayer))
                    {
                        this.playerWhoAnsweredIncorrectly = this.playerToAnswer;
                        this.hideAnswerControls();
                    }
                    else if(this.secondPlayerWhoAnsweredIncorrectly.Equals(this.nullPlaceholderPlayer))
                    {
                        this.secondPlayerWhoAnsweredIncorrectly = this.playerToAnswer;
                        this.hideAnswerControls();
                    }
                    else // The last player to answer answered incorrectly.
                    {
                        this.shouldKillThread = true;
                        MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheAnswer, "Showing Correct Answer");
                        Core.currentGame.GameBoardScreen.Show();
                        this.Close();
                    }
                }
                else // For two player games...
                {
                    if (this.playerWhoAnsweredIncorrectly.Equals(this.nullPlaceholderPlayer))
                    {
                        this.playerWhoAnsweredIncorrectly = this.playerToAnswer;
                        this.hideAnswerControls();
                    }
                    else // The last player to answer answered incorrectly.
                    {
                        this.shouldKillThread = true;
                        MessageBox.Show("The correct answer is:\n\n" + this.theQuestion.TheAnswer, "Showing Correct Answer");
                        Core.currentGame.GameBoardScreen.Show();
                        this.Close();
                    }
                }
            }

        }

        private Player getLastPlayerToAnswer() // Returns the only player who hasn't attempted to answer the current question yete.
        {
            if (!this.playerWhoAnsweredIncorrectly.Equals(Core.currentGame.Player1) && !this.secondPlayerWhoAnsweredIncorrectly.Equals(Core.currentGame.Player1))
            {
                return Core.currentGame.Player1;
            }
            else if (!this.playerWhoAnsweredIncorrectly.Equals(Core.currentGame.Player2) && !this.secondPlayerWhoAnsweredIncorrectly.Equals(Core.currentGame.Player2))
            {
                return Core.currentGame.Player2;
            }
            else if (Core.currentGame.NumPlayers == 3 && !this.playerWhoAnsweredIncorrectly.Equals(Core.currentGame.Player3) && !this.secondPlayerWhoAnsweredIncorrectly.Equals(Core.currentGame.Player3))
            {
                return Core.currentGame.Player3;
            }
            else
            {
                Console.WriteLine("getLastPlayerToAnswer method was called at an improper time!");
                return null;
            }
        }

        private Boolean playerAlreadyAnswered(Player p) // Returns true if the parameter player already attempted to answer the question.
        {
            if (p.Equals(this.playerWhoAnsweredIncorrectly) || p.Equals(this.secondPlayerWhoAnsweredIncorrectly))
            {
                return true;
            }
            else return false;
        }
    }
}
