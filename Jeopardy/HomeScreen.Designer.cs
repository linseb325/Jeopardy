namespace Jeopardy
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.playButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.customQuestionsButton = new System.Windows.Forms.Button();
            this.thePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Yellow;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.playButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.playButton.Location = new System.Drawing.Point(240, 289);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 68);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructionsButton
            // 
            this.instructionsButton.BackColor = System.Drawing.Color.Yellow;
            this.instructionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.instructionsButton.Location = new System.Drawing.Point(231, 382);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(119, 38);
            this.instructionsButton.TabIndex = 2;
            this.instructionsButton.Text = "Game Instructions...";
            this.instructionsButton.UseVisualStyleBackColor = false;
            this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            // 
            // customQuestionsButton
            // 
            this.customQuestionsButton.BackColor = System.Drawing.Color.Yellow;
            this.customQuestionsButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.customQuestionsButton.Location = new System.Drawing.Point(231, 426);
            this.customQuestionsButton.Name = "customQuestionsButton";
            this.customQuestionsButton.Size = new System.Drawing.Size(119, 38);
            this.customQuestionsButton.TabIndex = 3;
            this.customQuestionsButton.Text = "Custom Question File Format...";
            this.customQuestionsButton.UseVisualStyleBackColor = false;
            this.customQuestionsButton.Click += new System.EventHandler(this.customQuestionsButton_Click);
            // 
            // thePictureBox
            // 
            this.thePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("thePictureBox.Image")));
            this.thePictureBox.Location = new System.Drawing.Point(12, 40);
            this.thePictureBox.Name = "thePictureBox";
            this.thePictureBox.Size = new System.Drawing.Size(560, 204);
            this.thePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thePictureBox.TabIndex = 4;
            this.thePictureBox.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.thePictureBox);
            this.Controls.Add(this.customQuestionsButton);
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.playButton);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.VisibleChanged += new System.EventHandler(this.HomeScreen_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.thePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.Button customQuestionsButton;
        private System.Windows.Forms.PictureBox thePictureBox;
    }
}