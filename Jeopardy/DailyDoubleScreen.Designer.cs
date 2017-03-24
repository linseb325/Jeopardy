namespace Jeopardy
{
    partial class DailyDoubleScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputWagerLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.wagerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.answerInputTextBox = new System.Windows.Forms.TextBox();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.playerIdentifierLabel = new System.Windows.Forms.Label();
            this.wagerButton = new System.Windows.Forms.Button();
            this.maxWagerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputWagerLabel
            // 
            this.inputWagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputWagerLabel.ForeColor = System.Drawing.Color.White;
            this.inputWagerLabel.Location = new System.Drawing.Point(161, 117);
            this.inputWagerLabel.Name = "inputWagerLabel";
            this.inputWagerLabel.Size = new System.Drawing.Size(117, 43);
            this.inputWagerLabel.TabIndex = 0;
            this.inputWagerLabel.Text = "Input Wager:";
            this.inputWagerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 297);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 52);
            this.progressBar.Step = 2;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // wagerTextBox
            // 
            this.wagerTextBox.Location = new System.Drawing.Point(308, 130);
            this.wagerTextBox.Name = "wagerTextBox";
            this.wagerTextBox.Size = new System.Drawing.Size(100, 20);
            this.wagerTextBox.TabIndex = 2;
            this.wagerTextBox.Enter += new System.EventHandler(this.wagerTextBox_Enter);
            this.wagerTextBox.Leave += new System.EventHandler(this.wagerTextBox_Leave);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(12, 54);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(560, 126);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "questionLabel";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Visible = false;
            // 
            // formatLabel
            // 
            this.formatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.formatLabel.ForeColor = System.Drawing.Color.White;
            this.formatLabel.Location = new System.Drawing.Point(12, 199);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(560, 20);
            this.formatLabel.TabIndex = 4;
            this.formatLabel.Text = "formatLabel";
            this.formatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formatLabel.Visible = false;
            // 
            // answerInputTextBox
            // 
            this.answerInputTextBox.Location = new System.Drawing.Point(12, 222);
            this.answerInputTextBox.Name = "answerInputTextBox";
            this.answerInputTextBox.Size = new System.Drawing.Size(560, 20);
            this.answerInputTextBox.TabIndex = 5;
            this.answerInputTextBox.Visible = false;
            this.answerInputTextBox.Enter += new System.EventHandler(this.answerInputTextBox_Enter);
            this.answerInputTextBox.Leave += new System.EventHandler(this.answerInputTextBox_Leave);
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.Location = new System.Drawing.Point(242, 245);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(97, 46);
            this.submitAnswerButton.TabIndex = 6;
            this.submitAnswerButton.Text = "Submit Answer!";
            this.submitAnswerButton.UseVisualStyleBackColor = true;
            this.submitAnswerButton.Visible = false;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // playerIdentifierLabel
            // 
            this.playerIdentifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playerIdentifierLabel.ForeColor = System.Drawing.Color.White;
            this.playerIdentifierLabel.Location = new System.Drawing.Point(12, 20);
            this.playerIdentifierLabel.Name = "playerIdentifierLabel";
            this.playerIdentifierLabel.Size = new System.Drawing.Size(560, 34);
            this.playerIdentifierLabel.TabIndex = 7;
            this.playerIdentifierLabel.Text = "playerIdentifierLabel";
            this.playerIdentifierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wagerButton
            // 
            this.wagerButton.Location = new System.Drawing.Point(415, 128);
            this.wagerButton.Name = "wagerButton";
            this.wagerButton.Size = new System.Drawing.Size(75, 23);
            this.wagerButton.TabIndex = 8;
            this.wagerButton.Text = "Ready!";
            this.wagerButton.UseVisualStyleBackColor = true;
            this.wagerButton.Click += new System.EventHandler(this.wagerButton_Click);
            // 
            // maxWagerLabel
            // 
            this.maxWagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxWagerLabel.ForeColor = System.Drawing.Color.White;
            this.maxWagerLabel.Location = new System.Drawing.Point(12, 159);
            this.maxWagerLabel.Name = "maxWagerLabel";
            this.maxWagerLabel.Size = new System.Drawing.Size(560, 34);
            this.maxWagerLabel.TabIndex = 9;
            this.maxWagerLabel.Text = "maxWagerLabel";
            this.maxWagerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DailyDoubleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.maxWagerLabel);
            this.Controls.Add(this.wagerButton);
            this.Controls.Add(this.playerIdentifierLabel);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.answerInputTextBox);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.wagerTextBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.inputWagerLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "DailyDoubleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Double!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputWagerLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox wagerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.TextBox answerInputTextBox;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Label playerIdentifierLabel;
        private System.Windows.Forms.Button wagerButton;
        private System.Windows.Forms.Label maxWagerLabel;
    }
}