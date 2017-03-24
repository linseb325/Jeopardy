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
// Purpose: Displays the Jeopardy game board (grid) and allows users to select questions or access the manual score adjustment screen.

namespace Jeopardy
{
    public partial class GameBoardScreen : Form
    {

        private Dictionary<Button, Question> pairs;

        public GameBoardScreen()
        {
            InitializeComponent();

            this.pairs = this.generatePairs();

            Core.currentGame.GameBoardScreen = this;

            this.controlOfBoardLabel.Text = Core.currentGame.ControllingPlayer.Name + " has control of the board.";
            this.initializeScoreBoard();
            this.initializeCategoryLabels();
        }

        public Dictionary<Button, Question> generatePairs() // Returns a dictionary which associates each button on the screen with its corresponding question.
        {
            Dictionary<Button, Question> dictionaryToReturn = new Dictionary<Button, Question>();

            dictionaryToReturn.Add(this.button11, Core.currentGame.CategorySet[0].Question100);
            dictionaryToReturn.Add(this.button12, Core.currentGame.CategorySet[0].Question200);
            dictionaryToReturn.Add(this.button13, Core.currentGame.CategorySet[0].Question300);
            dictionaryToReturn.Add(this.button14, Core.currentGame.CategorySet[0].Question400);
            dictionaryToReturn.Add(this.button15, Core.currentGame.CategorySet[0].Question500);

            dictionaryToReturn.Add(this.button21, Core.currentGame.CategorySet[1].Question100);
            dictionaryToReturn.Add(this.button22, Core.currentGame.CategorySet[1].Question200);
            dictionaryToReturn.Add(this.button23, Core.currentGame.CategorySet[1].Question300);
            dictionaryToReturn.Add(this.button24, Core.currentGame.CategorySet[1].Question400);
            dictionaryToReturn.Add(this.button25, Core.currentGame.CategorySet[1].Question500);

            dictionaryToReturn.Add(this.button31, Core.currentGame.CategorySet[2].Question100);
            dictionaryToReturn.Add(this.button32, Core.currentGame.CategorySet[2].Question200);
            dictionaryToReturn.Add(this.button33, Core.currentGame.CategorySet[2].Question300);
            dictionaryToReturn.Add(this.button34, Core.currentGame.CategorySet[2].Question400);
            dictionaryToReturn.Add(this.button35, Core.currentGame.CategorySet[2].Question500);

            dictionaryToReturn.Add(this.button41, Core.currentGame.CategorySet[3].Question100);
            dictionaryToReturn.Add(this.button42, Core.currentGame.CategorySet[3].Question200);
            dictionaryToReturn.Add(this.button43, Core.currentGame.CategorySet[3].Question300);
            dictionaryToReturn.Add(this.button44, Core.currentGame.CategorySet[3].Question400);
            dictionaryToReturn.Add(this.button45, Core.currentGame.CategorySet[3].Question500);

            dictionaryToReturn.Add(this.button51, Core.currentGame.CategorySet[4].Question100);
            dictionaryToReturn.Add(this.button52, Core.currentGame.CategorySet[4].Question200);
            dictionaryToReturn.Add(this.button53, Core.currentGame.CategorySet[4].Question300);
            dictionaryToReturn.Add(this.button54, Core.currentGame.CategorySet[4].Question400);
            dictionaryToReturn.Add(this.button55, Core.currentGame.CategorySet[4].Question500);

            return dictionaryToReturn;

        }

        private void questionButtonClicked(object sender, EventArgs e) // A GAME BOARD BUTTON WAS CLICKED
        {
            Button clickedButton = sender as Button;
            if (this.pairs.ContainsKey(clickedButton))
            {
                Question correspondingQuestion = this.pairs[clickedButton];
                if(!correspondingQuestion.WasAnswered) // Enter this block if the question was not already answered.
                {
                    this.Hide();
                    clickedButton.BackColor = Color.Red;
                    correspondingQuestion.WasAnswered = true;
                    if(correspondingQuestion.IsDailyDouble) // If the selected question is the daily double, show the DailyDoubleScreen.
                    {
                        DailyDoubleScreen dds = new DailyDoubleScreen(correspondingQuestion);
                        dds.Show();
                    }
                    else // Otherwise, it's just a regular question, so show the normal SelectedQuestionScreen.
                    {
                        SelectedQuestionScreen sqs = new SelectedQuestionScreen(correspondingQuestion);
                        sqs.Show();
                    }
                }
                else // Otherwise, the question has already been answered.
                {
                    MessageBox.Show("The selected question has already been answered! Please select another question!", "Error");
                }
            }
        }

        private Boolean boardIsCleared() // Returns true if all questions have been answered. Otherwise, returns false.
        {
            foreach (KeyValuePair<Button, Question> aPair in this.pairs)
            {
                if(!aPair.Value.WasAnswered)
                {
                    return false;
                }
            }
            return true;
        }

        private void initializeScoreBoard() // Sets initial values for scores and names. Determines whether there are two or three players, adjusting/spacing the scoreboard accordingly.
        {
            this.player1NameLabel.Text = Core.currentGame.Player1.Name;
            this.player1ScoreLabel.Text = "0";
            this.player2NameLabel.Text = Core.currentGame.Player2.Name;
            this.player2ScoreLabel.Text = "0";
            if (Core.currentGame.NumPlayers == 2) // If there are two players, hides the third player's score from view and pushes player 2's score/name out so things remain centered.
            {
                this.player3NameLabel.Visible = false;
                this.player3ScoreLabel.Visible = false;
                this.player2NameLabel.Location = this.player3NameLabel.Location;
                this.player2ScoreLabel.Location = this.player3ScoreLabel.Location;
            }
            else // Otherwise, it is a three player game.
            {
                this.player3NameLabel.Text = Core.currentGame.Player3.Name;
                this.player3ScoreLabel.Text = "0";
            }
        }

        private void initializeCategoryLabels() // Sets category labels.
        {
            this.category1Label.Text = Core.currentGame.CategorySet[0].Name;
            this.category2Label.Text = Core.currentGame.CategorySet[1].Name;
            this.category3Label.Text = Core.currentGame.CategorySet[2].Name;
            this.category4Label.Text = Core.currentGame.CategorySet[3].Name;
            this.category5Label.Text = Core.currentGame.CategorySet[4].Name;
        }

        private void GameBoardScreen_VisibleChanged(object sender, EventArgs e) // This event occurs whenever the game board is shown or hidden.
        {
            if(!this.boardIsCleared())
            {
                this.controlOfBoardLabel.Text = Core.currentGame.ControllingPlayer.Name + " has control of the board.";
                this.updateScoreBoard();
            }

            if(this.boardIsCleared() && this.Visible) // Would indicate that the game is over, so it is time to display the final scores to the screen.
            {
                GameOverScreen gos = new GameOverScreen();
                gos.Show();
                this.Close();
            }
        }

        public void updateScoreBoard() // Pull the most current scores from the Singleton, and update the scoreboard.
        {
            this.player1ScoreLabel.Text = Convert.ToString(Core.currentGame.Player1.Score);
            this.player2ScoreLabel.Text = Convert.ToString(Core.currentGame.Player2.Score);
            if(Core.currentGame.NumPlayers == 3)
            {
                this.player3ScoreLabel.Text = Convert.ToString(Core.currentGame.Player3.Score);
            }
        }

        private void GameBoardScreen_FormClosing(object sender, FormClosingEventArgs e) // Show the home screen if the user closes the game board.
        {
            if(!this.boardIsCleared()) // Entering this would mean that the user closed the game board before the game was over by clicking the "X" button.
            {
                Core.homeScreen.Show();
            }
        }

        private void manualAdjustButton_Click(object sender, EventArgs e) // MANUAL SCORE ADJUSTMENT BUTTON CLICKED
        {
            AdjustScoreScreen adjustScreen = new AdjustScoreScreen();
            adjustScreen.Show();
        }
    }
}
