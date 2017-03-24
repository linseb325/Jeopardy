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
// Purpose: Displays the format requirements for custom question text files.

namespace Jeopardy
{
    public partial class FormatRequirementsScreen : Form
    {
        public FormatRequirementsScreen()
        {
            InitializeComponent();

            this.formatReqsLabel.Text = "  - The file must be a text file with a .txt extension.\n  - The application will check contestants' answers based on how the answers appear in the text file, so spelling counts!\n  - For the sake of human legibility, this application's parser was designed to read a text file line-by-line. The drawback, however, is that the rules for the formatting of custom text files must be followed very strictly; even a missing punctuation mark or an extra space could cause problems for the parser, so carefully follow the formatting requirements listed below while typing up custom questions.\n  - Do not put a title/header in the text of the document. The only text which should not be enclosed by curly braces is the end line, which is detailed below.\n  - An opening curly brace (\"{\") on its own line indicates the beginning of a category. A closing curly brace (\"}\") on its own line indicates the end of a category.\n  - An opening square bracket (\"[\") on its own line indicates the beginning of questions for a category. A closing square bracket (\"]\") on its own line indicates the end of questions for a category.\n  - The name of the category must be specified in the line following the opening curly brace (note that the name of the category must be between double quotation marks). The line must follow this format: Category: \"Insert Category Name Here\"\n  - There must be five questions in each category, and each question is assigned a distinct point value between 100 and 500 in increments of 100. The point value, followed by a colon, gets its own line.\n  - For each question, three lines follow the point value line. The first line begins with a capital \"Q\" followed by a colon, a space, and the text of the question. The next line begins with a capital \"F\" followed by a colon, a space, and the format (i.e. \"What is\") used to phrase the answer in the form of a question. The next line begins with a capital \"A\" followed by a colon, a space, and the answer to the question. The next line is either the point value line for the next question or a closing square bracket to indicate the end of questions for the category.\n  - The parser will simply skip over any lines which are empty (NOT whitespace created by hitting the spacebar), so it is permissible to put an empty line or two between the closing curly brace of one category and the opening curly brace of the next in order to make the document easier to read.\n  - The line which reads: \"-END-\" must be included at the end of the document in order for the parser to stop parsing. Do not omit this line.";
            this.exampleCategoryLabel.Text = "{\nCategory: \"Colors\"\n[\n100:\nQ: This color is the color of grass.\nF: What is\nA: Green\n200:\nQ: This is the color of copy paper.\nF: What is\nA: White\n300:\nQ: This color shares its name with a citrus fruit.\nF: What is\nA: Orange\n400:\nQ: This is the color which results when blue is mixed with red.\nF: What is\nA: Purple\n500:\nQ: This is the color which results when every color is mixed together.\nF: What is\nA: Black\n]\n}\n-END-";
            
        }

        private void FormatRequirementsScreen_FormClosed(object sender, FormClosedEventArgs e) // FORM CLOSED
        {
            Core.homeScreen.Show();
        }
    }
}
