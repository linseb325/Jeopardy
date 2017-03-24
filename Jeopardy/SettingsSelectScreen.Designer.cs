namespace Jeopardy
{
    partial class SettingsSelectScreen
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
            this.numPlayersPicker = new System.Windows.Forms.NumericUpDown();
            this.numPlayersLabel = new System.Windows.Forms.Label();
            this.nameSelectLabel = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player3NameLabel = new System.Windows.Forms.Label();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.player3TextBox = new System.Windows.Forms.TextBox();
            this.playGameButton = new System.Windows.Forms.Button();
            this.returnToHomeScreenButton = new System.Windows.Forms.Button();
            this.player1CheckBox = new System.Windows.Forms.CheckBox();
            this.player2CheckBox = new System.Windows.Forms.CheckBox();
            this.player3CheckBox = new System.Windows.Forms.CheckBox();
            this.randomizeControlCheckBox = new System.Windows.Forms.CheckBox();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayersPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // numPlayersPicker
            // 
            this.numPlayersPicker.BackColor = System.Drawing.SystemColors.Control;
            this.numPlayersPicker.ForeColor = System.Drawing.Color.Black;
            this.numPlayersPicker.Location = new System.Drawing.Point(354, 73);
            this.numPlayersPicker.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numPlayersPicker.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPlayersPicker.Name = "numPlayersPicker";
            this.numPlayersPicker.Size = new System.Drawing.Size(60, 20);
            this.numPlayersPicker.TabIndex = 0;
            this.numPlayersPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPlayersPicker.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPlayersPicker.ValueChanged += new System.EventHandler(this.numPlayersPicker_ValueChanged);
            // 
            // numPlayersLabel
            // 
            this.numPlayersLabel.AutoSize = true;
            this.numPlayersLabel.BackColor = System.Drawing.Color.Blue;
            this.numPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numPlayersLabel.ForeColor = System.Drawing.Color.Yellow;
            this.numPlayersLabel.Location = new System.Drawing.Point(76, 70);
            this.numPlayersLabel.Name = "numPlayersLabel";
            this.numPlayersLabel.Size = new System.Drawing.Size(266, 26);
            this.numPlayersLabel.TabIndex = 1;
            this.numPlayersLabel.Text = "Select Number of Players:";
            this.numPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameSelectLabel
            // 
            this.nameSelectLabel.AutoSize = true;
            this.nameSelectLabel.BackColor = System.Drawing.Color.Blue;
            this.nameSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameSelectLabel.ForeColor = System.Drawing.Color.Yellow;
            this.nameSelectLabel.Location = new System.Drawing.Point(76, 140);
            this.nameSelectLabel.Name = "nameSelectLabel";
            this.nameSelectLabel.Size = new System.Drawing.Size(234, 26);
            this.nameSelectLabel.TabIndex = 2;
            this.nameSelectLabel.Text = "Specify Player Names:";
            this.nameSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.BackColor = System.Drawing.Color.Blue;
            this.player1NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player1NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player1NameLabel.Location = new System.Drawing.Point(110, 182);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(69, 20);
            this.player1NameLabel.TabIndex = 3;
            this.player1NameLabel.Text = "Player 1:";
            this.player1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.BackColor = System.Drawing.Color.Blue;
            this.player2NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player2NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player2NameLabel.Location = new System.Drawing.Point(110, 208);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(69, 20);
            this.player2NameLabel.TabIndex = 4;
            this.player2NameLabel.Text = "Player 2:";
            this.player2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player3NameLabel
            // 
            this.player3NameLabel.AutoSize = true;
            this.player3NameLabel.BackColor = System.Drawing.Color.Blue;
            this.player3NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player3NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.player3NameLabel.Location = new System.Drawing.Point(110, 234);
            this.player3NameLabel.Name = "player3NameLabel";
            this.player3NameLabel.Size = new System.Drawing.Size(69, 20);
            this.player3NameLabel.TabIndex = 5;
            this.player3NameLabel.Text = "Player 3:";
            this.player3NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player3NameLabel.Visible = false;
            // 
            // player1TextBox
            // 
            this.player1TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.player1TextBox.ForeColor = System.Drawing.Color.Black;
            this.player1TextBox.Location = new System.Drawing.Point(185, 184);
            this.player1TextBox.MaxLength = 18;
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(150, 20);
            this.player1TextBox.TabIndex = 6;
            // 
            // player2TextBox
            // 
            this.player2TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.player2TextBox.ForeColor = System.Drawing.Color.Black;
            this.player2TextBox.Location = new System.Drawing.Point(185, 210);
            this.player2TextBox.MaxLength = 18;
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(150, 20);
            this.player2TextBox.TabIndex = 7;
            // 
            // player3TextBox
            // 
            this.player3TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.player3TextBox.ForeColor = System.Drawing.Color.Black;
            this.player3TextBox.Location = new System.Drawing.Point(185, 236);
            this.player3TextBox.MaxLength = 18;
            this.player3TextBox.Name = "player3TextBox";
            this.player3TextBox.Size = new System.Drawing.Size(150, 20);
            this.player3TextBox.TabIndex = 8;
            this.player3TextBox.Visible = false;
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.Yellow;
            this.playGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.ForeColor = System.Drawing.Color.Blue;
            this.playGameButton.Location = new System.Drawing.Point(374, 464);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(150, 57);
            this.playGameButton.TabIndex = 9;
            this.playGameButton.Text = "Play Game!";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // returnToHomeScreenButton
            // 
            this.returnToHomeScreenButton.BackColor = System.Drawing.Color.Yellow;
            this.returnToHomeScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToHomeScreenButton.ForeColor = System.Drawing.Color.Blue;
            this.returnToHomeScreenButton.Location = new System.Drawing.Point(57, 464);
            this.returnToHomeScreenButton.Name = "returnToHomeScreenButton";
            this.returnToHomeScreenButton.Size = new System.Drawing.Size(150, 57);
            this.returnToHomeScreenButton.TabIndex = 10;
            this.returnToHomeScreenButton.Text = "Return to Home Screen";
            this.returnToHomeScreenButton.UseVisualStyleBackColor = false;
            this.returnToHomeScreenButton.Click += new System.EventHandler(this.returnToHomeScreenButton_Click);
            // 
            // player1CheckBox
            // 
            this.player1CheckBox.AutoSize = true;
            this.player1CheckBox.BackColor = System.Drawing.Color.Blue;
            this.player1CheckBox.ForeColor = System.Drawing.Color.Yellow;
            this.player1CheckBox.Location = new System.Drawing.Point(341, 186);
            this.player1CheckBox.Name = "player1CheckBox";
            this.player1CheckBox.Size = new System.Drawing.Size(178, 17);
            this.player1CheckBox.TabIndex = 11;
            this.player1CheckBox.Text = "Begins with control of the board.";
            this.player1CheckBox.UseVisualStyleBackColor = false;
            this.player1CheckBox.CheckedChanged += new System.EventHandler(this.playerCheckBoxChanged);
            // 
            // player2CheckBox
            // 
            this.player2CheckBox.AutoSize = true;
            this.player2CheckBox.BackColor = System.Drawing.Color.Blue;
            this.player2CheckBox.ForeColor = System.Drawing.Color.Yellow;
            this.player2CheckBox.Location = new System.Drawing.Point(341, 212);
            this.player2CheckBox.Name = "player2CheckBox";
            this.player2CheckBox.Size = new System.Drawing.Size(178, 17);
            this.player2CheckBox.TabIndex = 12;
            this.player2CheckBox.Text = "Begins with control of the board.";
            this.player2CheckBox.UseVisualStyleBackColor = false;
            this.player2CheckBox.CheckedChanged += new System.EventHandler(this.playerCheckBoxChanged);
            // 
            // player3CheckBox
            // 
            this.player3CheckBox.AutoSize = true;
            this.player3CheckBox.BackColor = System.Drawing.Color.Blue;
            this.player3CheckBox.ForeColor = System.Drawing.Color.Yellow;
            this.player3CheckBox.Location = new System.Drawing.Point(341, 238);
            this.player3CheckBox.Name = "player3CheckBox";
            this.player3CheckBox.Size = new System.Drawing.Size(178, 17);
            this.player3CheckBox.TabIndex = 13;
            this.player3CheckBox.Text = "Begins with control of the board.";
            this.player3CheckBox.UseVisualStyleBackColor = false;
            this.player3CheckBox.Visible = false;
            this.player3CheckBox.CheckedChanged += new System.EventHandler(this.playerCheckBoxChanged);
            // 
            // randomizeControlCheckBox
            // 
            this.randomizeControlCheckBox.AutoSize = true;
            this.randomizeControlCheckBox.BackColor = System.Drawing.Color.Blue;
            this.randomizeControlCheckBox.ForeColor = System.Drawing.Color.Yellow;
            this.randomizeControlCheckBox.Location = new System.Drawing.Point(316, 273);
            this.randomizeControlCheckBox.Name = "randomizeControlCheckBox";
            this.randomizeControlCheckBox.Size = new System.Drawing.Size(203, 17);
            this.randomizeControlCheckBox.TabIndex = 14;
            this.randomizeControlCheckBox.Text = "Randomize initial control of the board.";
            this.randomizeControlCheckBox.UseVisualStyleBackColor = false;
            this.randomizeControlCheckBox.CheckedChanged += new System.EventHandler(this.randomizeControlCheckBox_CheckedChanged);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.filePathTextBox.ForeColor = System.Drawing.Color.Black;
            this.filePathTextBox.Location = new System.Drawing.Point(81, 386);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(334, 20);
            this.filePathTextBox.TabIndex = 16;
            this.filePathTextBox.Text = "Use default pre-loaded categories.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(76, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "File Path for Custom Question File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.Control;
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(421, 384);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 18;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // SettingsSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.randomizeControlCheckBox);
            this.Controls.Add(this.player3CheckBox);
            this.Controls.Add(this.player2CheckBox);
            this.Controls.Add(this.player1CheckBox);
            this.Controls.Add(this.returnToHomeScreenButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.player3TextBox);
            this.Controls.Add(this.player2TextBox);
            this.Controls.Add(this.player1TextBox);
            this.Controls.Add(this.player3NameLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.nameSelectLabel);
            this.Controls.Add(this.numPlayersLabel);
            this.Controls.Add(this.numPlayersPicker);
            this.Name = "SettingsSelectScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsSelectScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numPlayersPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPlayersPicker;
        private System.Windows.Forms.Label numPlayersLabel;
        private System.Windows.Forms.Label nameSelectLabel;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player3NameLabel;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.TextBox player3TextBox;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button returnToHomeScreenButton;
        private System.Windows.Forms.CheckBox player1CheckBox;
        private System.Windows.Forms.CheckBox player2CheckBox;
        private System.Windows.Forms.CheckBox player3CheckBox;
        private System.Windows.Forms.CheckBox randomizeControlCheckBox;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}