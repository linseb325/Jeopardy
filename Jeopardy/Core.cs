using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// Author: Brennan Linse
// Date: 5/11/2016
// Purpose: Singleton class stores the current game information as well as the set of all categories loaded from a plain text file. Also responsible for storing/showing/hiding the home screen because the application closes if the home screen closes.

namespace Jeopardy
{
    class Core
    {
        public static Game currentGame;
        public static Category[] allCategories;
        public static HomeScreen homeScreen;

        public static void addToAllCategories(Category categoryToAdd) // Adds the given category to the collection of all categories retrieved from the file.
        {
            int prevCount = 0;
            if(Core.allCategories != null && Core.allCategories.Length != 0)
            {
                prevCount = Core.allCategories.Length;
            }
            Category[] newArray = new Category[prevCount + 1];
            if(Core.allCategories != null)
            {
                for(int i = 0; i < prevCount; i++)
                {
                    newArray[i] = Core.allCategories[i];
                }
            }
            newArray[prevCount] = categoryToAdd;
            Core.allCategories = newArray;
        }

        public static Category[] getFiveRandomCategories() // Returns an array of five randomly selected categories retrieved from the array of all categories loaded in from the text file.
        {
            int addToIndex = 0;
            Category[] arrayToReturn = new Category[5];
            Random randomNumGenerator = new Random();
            int randomIndex = randomNumGenerator.Next(0, Core.allCategories.Length);
            ArrayList alreadySelected = new ArrayList();
            while(arrayToReturn[4] == null) // Repeat the following until arrayToReturn contains five categories.
            {
                randomIndex = randomNumGenerator.Next(0, Core.allCategories.Length);
                if(alreadySelected.Contains(randomIndex)) // The category has already been added.
                {
                    Console.WriteLine("This category is already in the array of game categories: " + Core.allCategories[randomIndex].Name);
                }
                else // Otherwise, the category can be added.
                {
                    arrayToReturn[addToIndex] = Core.allCategories[randomIndex];
                    alreadySelected.Add(randomIndex);
                    addToIndex++;
                }
            }
            return arrayToReturn;
        }
    }
}
