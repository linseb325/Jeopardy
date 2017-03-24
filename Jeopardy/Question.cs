using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Stores the details of a Jeopardy question as well as some flags needed for game mechanics.

namespace Jeopardy
{
    public class Question
    {
        private String theQuestion;
        public String TheQuestion
        {
            get { return theQuestion; }
            set { theQuestion = value; }
        }

        private String theFormat;
        public String TheFormat
        {
            get { return theFormat; }
            set { theFormat = value; }
        }

        private String theAnswer;
        public String TheAnswer
        {
            get { return theAnswer; }
            set { theAnswer = value; }
        }

        private int pointValue;
        public int PointValue
        {
            get { return pointValue; }
            set { pointValue = value; }
        }

        private Boolean isDailyDouble;
        public Boolean IsDailyDouble
        {
            get { return isDailyDouble; }
            set { isDailyDouble = value; }
        }

        private Boolean wasAnswered;
        public Boolean WasAnswered
        {
            get { return wasAnswered; }
            set { wasAnswered = value; }
        }


        public Question(int points)
        {
            this.theQuestion = "Default question string";
            this.theFormat = "Default format string";
            this.theAnswer = "Default answer string";
            this.pointValue = points;
            this.isDailyDouble = false;
            this.wasAnswered = false;
        }


    }
}
