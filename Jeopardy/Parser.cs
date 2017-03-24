using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Parses through a plain text file line-by-line and stores the information needed for Jeopardy questions.

namespace Jeopardy
{
    class Parser
    {
        private StreamReader reader;

        public Parser(String filename)
        {
            this.reader = new StreamReader(filename);
        }

        public Boolean parse() // Parses the text file at the path. Returns true if parsing was successful and false if there was an exception.
        {
            String line = this.reader.ReadLine();
            Category currCategory = null;
            Question currQuestion = null;
            try
            {
                while (line != "-END-") // Read lines until the line indicating the end of the file.
                {
                    //Console.WriteLine("READING LINE: " + line);

                    if (String.IsNullOrWhiteSpace(line))
                    {
                        // Do nothing and skip over the line because it is whitespace.
                    }
                    else if (line == "{") // Beginning of a category
                    {
                        currCategory = new Category();
                        //Console.WriteLine("Created a new instance of Category.");
                    }
                    else if (line == "}") // End of a category
                    {
                        //Console.WriteLine("Found closing curly brace, denoting the end of category: " + currCategory.Name);
                        Core.addToAllCategories(currCategory);
                        //Console.WriteLine("Added category to set of all categories: " + currCategory.Name);
                        currCategory = null;
                    }
                    else if (line == "[") // Beginning of questions
                    {
                        //Console.WriteLine("Found opening square bracket. Beginning of questions for category: " + currCategory.Name);
                    }
                    else if (line == "]") // End of questions for a category
                    {
                        currCategory.addQuestion(currQuestion);
                        //Console.WriteLine("Added the last question in the category to category named: " + currCategory.Name);
                        currQuestion = null;
                        //Console.WriteLine("Found closing square bracket. End of questions for category: " + currCategory.Name);
                    }
                    else if (line.Length >= 3) // Included because of substring exceptions during debugging on 4.18.2016
                    {
                        if (line.Substring(1, 2) == ": ") // Question, format, or answer line
                        {
                            if (line.Substring(0, 3) == "Q: ") // Question line
                            {
                                if (currQuestion != null)
                                {
                                    String theQuestion = line.Substring(3, line.Length - 3);
                                    currQuestion.TheQuestion = theQuestion;
                                }
                            }
                            else if (line.Substring(0, 3) == "F: ") // Format line
                            {
                                if (currQuestion != null)
                                {
                                    String theFormat = line.Substring(3, line.Length - 3);
                                    currQuestion.TheFormat = theFormat;
                                }
                            }
                            else if (line.Substring(0, 3) == "A: ") // Answer line
                            {
                                if (currQuestion != null)
                                {
                                    String theAnswer = line.Substring(3, line.Length - 3);
                                    currQuestion.TheAnswer = theAnswer;
                                }
                            }
                        }
                        else if (line.Substring(1, 3) == "00:") // Indicates a point value line and that a question's details are about to be given in subsequent lines.
                        {
                            if (currQuestion != null) // If currQuestion is not set to null, it means that this question is NOT the first of the category, so add the previous question to the current category.
                            {
                                currCategory.addQuestion(currQuestion);
                                //Console.WriteLine("Added question to category named: " + currCategory.Name);
                            }
                            int numPoints = Convert.ToInt32(line.Substring(0, 3));
                            currQuestion = new Question(numPoints);
                            //Console.WriteLine("currQuestion's number of points set to: " + numPoints);
                        }
                        else if (line.Substring(0, 10) == "Category: ") // Indicates that a category name will be given.
                        {
                            if (currCategory != null) // If currCategory is set to a new category, read in the category name and add it to the category.
                            {
                                currCategory.Name = line.Substring(11, line.Length - 12);
                                //Console.WriteLine("Set category's name to " + line.Substring(11, line.Length - 12));
                            }
                            else // If currCategory is equal to null (which should not be the case), create the category and set its name.
                            {
                                currCategory = new Category();
                                currCategory.Name = line.Substring(11, line.Length - 12);
                            }
                        }
                        else // Otherwise, the current line is not compatible with the parser!
                        {
                            Console.WriteLine("The line which reads:\n" + line + "\n" + "is not compatible with the parser! Check the text file!");
                            Core.currentGame = null;
                            Core.allCategories = null;
                            return false;
                        }
                    }
                    else // Otherwise, the formatting of the current line is not compatible with the parser. Print the text of the guilty line to the console.
                    {
                        Console.WriteLine("The line which reads:\n" + line + "\n" + "is not compatible with the parser! Check the text file!");
                        Core.currentGame = null;
                        Core.allCategories = null;
                        return false;
                    }

                    line = this.reader.ReadLine(); // After processing the line, read the next line in the text file.
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Core.currentGame = null;
                Core.allCategories = null;
                return false;
            }
        }
    }
}
