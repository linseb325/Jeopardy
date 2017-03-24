namespace Jeopardy
{
    partial class AdjustScoreScreen
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
            this.numPointsTextBox = new System.Windows.Forms.TextBox();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player3NameLabel = new System.Windows.Forms.Label();
            this.player3ScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSelectPlayer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numPointsTextBox
            // 
            this.numPointsTextBox.Location = new System.Drawing.Point(269, 121);
            this.numPointsTextBox.MaxLength = 4;
            this.numPointsTextBox.Name = "numPointsTextBox";
            this.numPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numPointsTextBox.TabIndex = 0;
            this.numPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player1NameLabel.Location = new System.Drawing.Point(12, 328);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(150, 60);
            this.player1NameLabel.TabIndex = 1;
            this.player1NameLabel.Text = "label1";
            this.player1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player1ScoreLabel.Location = new System.Drawing.Point(12, 388);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(150, 60);
            this.player1ScoreLabel.TabIndex = 2;
            this.player1ScoreLabel.Text = "label2";
            this.player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player2NameLabel.Location = new System.Drawing.Point(167, 328);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(150, 60);
            this.player2NameLabel.TabIndex = 3;
            this.player2NameLabel.Text = "label3";
            this.player2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player2ScoreLabel.Location = new System.Drawing.Point(167, 388);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(150, 60);
            this.player2ScoreLabel.TabIndex = 4;
            this.player2ScoreLabel.Text = "label4";
            this.player2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player3NameLabel
            // 
            this.player3NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player3NameLabel.Location = new System.Drawing.Point(322, 328);
            this.player3NameLabel.Name = "player3NameLabel";
            this.player3NameLabel.Size = new System.Drawing.Size(150, 60);
            this.player3NameLabel.TabIndex = 5;
            this.player3NameLabel.Text = "label5";
            this.player3NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player3ScoreLabel
            // 
            this.player3ScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player3ScoreLabel.Location = new System.Drawing.Point(322, 388);
            this.player3ScoreLabel.Name = "player3ScoreLabel";
            this.player3ScoreLabel.Size = new System.Drawing.Size(150, 60);
            this.player3ScoreLabel.TabIndex = 6;
            this.player3ScoreLabel.Text = "label6";
            this.player3ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(101, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Point value to add or subtract:";
            // 
            // listBoxSelectPlayer
            // 
            this.listBoxSelectPlayer.FormattingEnabled = true;
            this.listBoxSelectPlayer.Location = new System.Drawing.Point(257, 186);
            this.listBoxSelectPlayer.Name = "listBoxSelectPlayer";
            this.listBoxSelectPlayer.Size = new System.Drawing.Size(120, 43);
            this.listBoxSelectPlayer.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(101, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Edit whose score?";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Yellow;
            this.addButton.ForeColor = System.Drawing.Color.Blue;
            this.addButton.Location = new System.Drawing.Point(111, 286);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add to Score";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.Yellow;
            this.subtractButton.ForeColor = System.Drawing.Color.Blue;
            this.subtractButton.Location = new System.Drawing.Point(257, 286);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(110, 23);
            this.subtractButton.TabIndex = 11;
            this.subtractButton.Text = "Subtract from Score";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // AdjustScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxSelectPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player3ScoreLabel);
            this.Controls.Add(this.player3NameLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.numPointsTextBox);
            this.Name = "AdjustScoreScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdjustScoreScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numPointsTextBox;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label player3NameLabel;
        private System.Windows.Forms.Label player3ScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSelectPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
    }
}