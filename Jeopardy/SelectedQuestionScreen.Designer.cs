namespace Jeopardy
{
    partial class SelectedQuestionScreen
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerInputTextBox = new System.Windows.Forms.TextBox();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.playerIdentifierLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.player1KeyLabel = new System.Windows.Forms.Label();
            this.player2KeyLabel = new System.Windows.Forms.Label();
            this.player3KeyLabel = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player3NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 297);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 52);
            this.progressBar.Step = 2;
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 8;
            this.progressBar.Visible = false;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(12, 38);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(560, 91);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "questionLabel";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Visible = false;
            // 
            // answerInputTextBox
            // 
            this.answerInputTextBox.Location = new System.Drawing.Point(12, 204);
            this.answerInputTextBox.Name = "answerInputTextBox";
            this.answerInputTextBox.Size = new System.Drawing.Size(560, 20);
            this.answerInputTextBox.TabIndex = 2;
            this.answerInputTextBox.Visible = false;
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.Location = new System.Drawing.Point(243, 238);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(97, 46);
            this.submitAnswerButton.TabIndex = 3;
            this.submitAnswerButton.Text = "Submit Answer!";
            this.submitAnswerButton.UseVisualStyleBackColor = true;
            this.submitAnswerButton.Visible = false;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // playerIdentifierLabel
            // 
            this.playerIdentifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playerIdentifierLabel.ForeColor = System.Drawing.Color.White;
            this.playerIdentifierLabel.Location = new System.Drawing.Point(15, 141);
            this.playerIdentifierLabel.Name = "playerIdentifierLabel";
            this.playerIdentifierLabel.Size = new System.Drawing.Size(557, 20);
            this.playerIdentifierLabel.TabIndex = 4;
            this.playerIdentifierLabel.Text = "playerIdentifierLabel";
            this.playerIdentifierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerIdentifierLabel.Visible = false;
            // 
            // formatLabel
            // 
            this.formatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.formatLabel.ForeColor = System.Drawing.Color.White;
            this.formatLabel.Location = new System.Drawing.Point(12, 186);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(560, 15);
            this.formatLabel.TabIndex = 5;
            this.formatLabel.Text = "formatLabel";
            this.formatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formatLabel.Visible = false;
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressBarLabel.Location = new System.Drawing.Point(261, 312);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(59, 20);
            this.progressBarLabel.TabIndex = 6;
            this.progressBarLabel.Text = "TIMER";
            this.progressBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressBarLabel.Visible = false;
            // 
            // player1KeyLabel
            // 
            this.player1KeyLabel.BackColor = System.Drawing.SystemColors.Info;
            this.player1KeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1KeyLabel.Location = new System.Drawing.Point(66, 182);
            this.player1KeyLabel.Name = "player1KeyLabel";
            this.player1KeyLabel.Size = new System.Drawing.Size(100, 100);
            this.player1KeyLabel.TabIndex = 7;
            this.player1KeyLabel.Text = "A";
            this.player1KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player1KeyLabel.Visible = false;
            // 
            // player2KeyLabel
            // 
            this.player2KeyLabel.BackColor = System.Drawing.SystemColors.Info;
            this.player2KeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2KeyLabel.Location = new System.Drawing.Point(240, 182);
            this.player2KeyLabel.Name = "player2KeyLabel";
            this.player2KeyLabel.Size = new System.Drawing.Size(100, 100);
            this.player2KeyLabel.TabIndex = 8;
            this.player2KeyLabel.Text = "B";
            this.player2KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player2KeyLabel.Visible = false;
            // 
            // player3KeyLabel
            // 
            this.player3KeyLabel.BackColor = System.Drawing.SystemColors.Info;
            this.player3KeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player3KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3KeyLabel.Location = new System.Drawing.Point(414, 182);
            this.player3KeyLabel.Name = "player3KeyLabel";
            this.player3KeyLabel.Size = new System.Drawing.Size(100, 100);
            this.player3KeyLabel.TabIndex = 9;
            this.player3KeyLabel.Text = ";";
            this.player3KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player3KeyLabel.Visible = false;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameLabel.ForeColor = System.Drawing.Color.White;
            this.player1NameLabel.Location = new System.Drawing.Point(40, 292);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(153, 30);
            this.player1NameLabel.TabIndex = 10;
            this.player1NameLabel.Text = "OOOOOOOOOOOOOOOOOO";
            this.player1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player1NameLabel.Visible = false;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLabel.ForeColor = System.Drawing.Color.White;
            this.player2NameLabel.Location = new System.Drawing.Point(214, 292);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(153, 30);
            this.player2NameLabel.TabIndex = 11;
            this.player2NameLabel.Text = "OOOOOOOOOOOOOOOOOO";
            this.player2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player2NameLabel.Visible = false;
            // 
            // player3NameLabel
            // 
            this.player3NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player3NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3NameLabel.ForeColor = System.Drawing.Color.White;
            this.player3NameLabel.Location = new System.Drawing.Point(388, 292);
            this.player3NameLabel.Name = "player3NameLabel";
            this.player3NameLabel.Size = new System.Drawing.Size(153, 30);
            this.player3NameLabel.TabIndex = 12;
            this.player3NameLabel.Text = "OOOOOOOOOOOOOOOOOO";
            this.player3NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player3NameLabel.Visible = false;
            // 
            // SelectedQuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.player3NameLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.player3KeyLabel);
            this.Controls.Add(this.player2KeyLabel);
            this.Controls.Add(this.player1KeyLabel);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.playerIdentifierLabel);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.answerInputTextBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.progressBar);
            this.KeyPreview = true;
            this.Name = "SelectedQuestionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyWasPressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerInputTextBox;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Label playerIdentifierLabel;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label progressBarLabel;
        private System.Windows.Forms.Label player1KeyLabel;
        private System.Windows.Forms.Label player2KeyLabel;
        private System.Windows.Forms.Label player3KeyLabel;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player3NameLabel;
    }
}