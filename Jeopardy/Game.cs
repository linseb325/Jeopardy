using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Keeps track of game categories, players, the game board, the controlling player, and other miscellaneous game aspects.

namespace Jeopardy
{
    class Game
    {
        private Category[] categorySet;
        public Category[] CategorySet
        {
            get { return categorySet; }
            set { categorySet = value; }
        }

        private int numPlayers;
        public int NumPlayers
        {
            get { return numPlayers; }
            set { numPlayers = value; }
        }

        private Player player1;
        public Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }

        private Player player2;
        public Player Player2
        {
            get { return player2; }
            set { player2 = value; }
        }

        private Player player3;
        public Player Player3
        {
            get { return player3; }
            set { player3 = value; }
        }

        private Player controllingPlayer;
        public Player ControllingPlayer
        {
            get { return controllingPlayer; }
            set { controllingPlayer = value; }
        }

        private GameBoardScreen gameBoardScreen;
        public GameBoardScreen GameBoardScreen
        {
            get { return gameBoardScreen; }
            set { gameBoardScreen = value; }
        }

        public Game(String p1, String p2, String p3, Boolean randomInitialControl, int playerToControlNumber) // Constructor for a three-player game.
        {
            this.numPlayers = 3;
            this.player1 = new Player(p1);
            this.player2 = new Player(p2);
            this.player3 = new Player(p3);
            if(randomInitialControl)
            {
                Random r = new Random();
                this.controllingPlayer = this.getPlayerNumber(r.Next(1, 4));
            }
            else
            {
                this.controllingPlayer = this.getPlayerNumber(playerToControlNumber);
            }
            this.categorySet = Core.getFiveRandomCategories();
            this.setDailyDoubleRandomly();
        }

        public Game(String p1, String p2, Boolean randomInitialControl, int playerToControlNumber) // Constructor for a two-player game.
        {
            this.numPlayers = 2;
            this.player1 = new Player(p1);
            this.player2 = new Player(p2);
            if (randomInitialControl)
            {
                Random r = new Random();
                this.controllingPlayer = this.getPlayerNumber(r.Next(1, 3));
            }
            else
            {
                this.controllingPlayer = this.getPlayerNumber(playerToControlNumber);
            }
            this.categorySet = Core.getFiveRandomCategories();
            this.setDailyDoubleRandomly();
        }

        public void addToGameCategories(Category categoryToAdd) // Adds the given category to the set of categories which will be used for the game.
        {
            if (this.categorySet.Length < 5)
            {
                int prevCount = 0;
                if (this.categorySet != null)
                {
                    prevCount = this.categorySet.Length;
                }
                Category[] newArray = new Category[prevCount + 1];
                if (this.categorySet != null)
                {
                    for (int i = 0; i < prevCount; i++)
                    {
                        newArray[i] = this.categorySet[i];
                    }
                }
                newArray[prevCount] = categoryToAdd;
                this.categorySet = newArray;
            }
            else Console.WriteLine("Game already has five categories! Cannot add category: " + categoryToAdd.Name);
        }

        public void setDailyDoubleRandomly() // Picks a random question from the game and sets it as the daily double.
        {
            Random rand = new Random();
            int randomCategoryIndex = rand.Next(0, 5);
            int randomQuestionIndex = rand.Next(1, 6);
            Console.WriteLine("Daily Double is in " + this.categorySet[randomCategoryIndex].Name + " at question " + randomQuestionIndex); // For testing purposes.
            if (randomQuestionIndex == 1)
            {
                this.categorySet[randomCategoryIndex].Question100.IsDailyDouble = true;
            }
            else if (randomQuestionIndex == 2)
            {
                this.categorySet[randomCategoryIndex].Question200.IsDailyDouble = true;
            }
            else if (randomQuestionIndex == 3)
            {
                this.categorySet[randomCategoryIndex].Question300.IsDailyDouble = true;
            }
            else if (randomQuestionIndex == 4)
            {
                this.categorySet[randomCategoryIndex].Question400.IsDailyDouble = true;
            }
            else if (randomQuestionIndex == 5)
            {
                this.categorySet[randomCategoryIndex].Question500.IsDailyDouble = true;
            }
            else Console.WriteLine("setDailyDoubleRandomly method in Game class did not enter any blocks of code!");

        }

        public Player getPlayerNumber(int playerNumRequested) // Returns the player whose number is requested by the parameter integer.
        {
            if (playerNumRequested == 1)
            {
                return this.player1;
            }
            else if (playerNumRequested == 2)
            {
                return this.player2;
            }
            else if (playerNumRequested == 3)
            {
                return this.player3;
            }
            else Console.WriteLine("Invalid player number requested!");
            return null;
        }
    }
}
