using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Stores the questions within a single category.

namespace Jeopardy
{
    class Category
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private Question question100;
        public Question Question100
        {
            get { return question100; }
            set { question100 = value; }
        }

        private Question question200;
        public Question Question200
        {
            get { return question200; }
            set { question200 = value; }
        }

        private Question question300;
        public Question Question300
        {
            get { return question300; }
            set { question300 = value; }
        }

        private Question question400;
        public Question Question400
        {
            get { return question400; }
            set { question400 = value; }
        }

        private Question question500;
        public Question Question500
        {
            get { return question500; }
            set { question500 = value; }
        }

        public Category()
        {
            this.name = null;
            this.question100 = null;
            this.question200 = null;
            this.question300 = null;
            this.question400 = null;
            this.question500 = null;
        }

        public void addQuestion(Question questionToAdd) // Adds a question to the right field within the category based on the question's point value.
        {
            if(questionToAdd.PointValue == 100)
            {
                this.question100 = questionToAdd;
            }
            else if (questionToAdd.PointValue == 200)
            {
                this.question200 = questionToAdd;
            }
            else if (questionToAdd.PointValue == 300)
            {
                this.question300 = questionToAdd;
            }
            else if (questionToAdd.PointValue == 400)
            {
                this.question400 = questionToAdd;
            }
            else if (questionToAdd.PointValue == 500)
            {
                this.question500 = questionToAdd;
            }
            else Console.WriteLine("Point value invalid! Cannot add to category \"" + this.name + "\".");
        }

        public Question getQuestionWithPointValue(int requestedValue) // Gets the question within this category which has the parameter point value.
        {
            if(requestedValue == 100)
            {
                return this.question100;
            }
            else if(requestedValue == 200)
            {
                return this.question200;
            }
            else if(requestedValue == 300)
            {
                return this.question300;
            }
            else if(requestedValue == 400)
            {
                return this.question400;
            }
            else if(requestedValue == 500)
            {
                return this.question500;
            }
            else
            {
                Console.WriteLine("Point value invalid! Could not get question with point value: " + requestedValue + " from category: " + this.name + ". Returning null.");
                return null;
            }
        }

    }
}
