using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Stores a player's information and is capable of adding/subtracting points from its score.

namespace Jeopardy
{
    public class Player
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Player(String name)
        {
            this.name = name;
            this.score = 0;
        }

        public void addPoints(int points)
        {
            this.score += points;
        }

        public void subtractPoints(int points)
        {
            this.score -= points;
        }

    }
}
