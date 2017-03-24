namespace Jeopardy
{
    partial class FormatRequirementsScreen
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
            this.formatReqsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exampleCategoryTitleLabel = new System.Windows.Forms.Label();
            this.exampleCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formatReqsLabel
            // 
            this.formatReqsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.formatReqsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.formatReqsLabel.Location = new System.Drawing.Point(10, 50);
            this.formatReqsLabel.Name = "formatReqsLabel";
            this.formatReqsLabel.Size = new System.Drawing.Size(1160, 410);
            this.formatReqsLabel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.titleLabel.Location = new System.Drawing.Point(7, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1160, 41);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "IMPORTANT INSTRUCTIONS REGARDING CUSTOM QUESTION FILES:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exampleCategoryTitleLabel
            // 
            this.exampleCategoryTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.exampleCategoryTitleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.exampleCategoryTitleLabel.Location = new System.Drawing.Point(10, 453);
            this.exampleCategoryTitleLabel.Name = "exampleCategoryTitleLabel";
            this.exampleCategoryTitleLabel.Size = new System.Drawing.Size(1160, 41);
            this.exampleCategoryTitleLabel.TabIndex = 2;
            this.exampleCategoryTitleLabel.Text = "EXAMPLE CATEGORY:";
            this.exampleCategoryTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exampleCategoryLabel
            // 
            this.exampleCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.exampleCategoryLabel.ForeColor = System.Drawing.Color.Yellow;
            this.exampleCategoryLabel.Location = new System.Drawing.Point(10, 494);
            this.exampleCategoryLabel.Name = "exampleCategoryLabel";
            this.exampleCategoryLabel.Size = new System.Drawing.Size(1160, 525);
            this.exampleCategoryLabel.TabIndex = 3;
            // 
            // FormatRequirementsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1184, 1061);
            this.Controls.Add(this.exampleCategoryLabel);
            this.Controls.Add(this.exampleCategoryTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.formatReqsLabel);
            this.Name = "FormatRequirementsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Requirements for Custom Question File";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormatRequirementsScreen_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formatReqsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label exampleCategoryTitleLabel;
        private System.Windows.Forms.Label exampleCategoryLabel;
    }
}