namespace TypingProgramUI
{
    partial class TypingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingWindow));
            this.FinalProgressBar = new System.Windows.Forms.ProgressBar();
            this.TargetWordLabel = new System.Windows.Forms.Label();
            this.UserWordTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinalProgressBar
            // 
            this.FinalProgressBar.BackColor = System.Drawing.Color.Maroon;
            this.FinalProgressBar.Location = new System.Drawing.Point(142, 265);
            this.FinalProgressBar.Margin = new System.Windows.Forms.Padding(1);
            this.FinalProgressBar.Name = "FinalProgressBar";
            this.FinalProgressBar.Size = new System.Drawing.Size(116, 20);
            this.FinalProgressBar.TabIndex = 0;
            // 
            // TargetWordLabel
            // 
            this.TargetWordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TargetWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetWordLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.TargetWordLabel.Location = new System.Drawing.Point(78, 23);
            this.TargetWordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TargetWordLabel.Name = "TargetWordLabel";
            this.TargetWordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TargetWordLabel.Size = new System.Drawing.Size(245, 48);
            this.TargetWordLabel.TabIndex = 4;
            this.TargetWordLabel.Text = "text";
            this.TargetWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserWordTextBox
            // 
            this.UserWordTextBox.Location = new System.Drawing.Point(142, 140);
            this.UserWordTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.UserWordTextBox.Name = "UserWordTextBox";
            this.UserWordTextBox.Size = new System.Drawing.Size(116, 20);
            this.UserWordTextBox.TabIndex = 5;
            this.UserWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.submitButton.Location = new System.Drawing.Point(299, 210);
            this.submitButton.Margin = new System.Windows.Forms.Padding(1);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(1, 1);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Enter";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // TypingWindow
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 347);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.UserWordTextBox);
            this.Controls.Add(this.TargetWordLabel);
            this.Controls.Add(this.FinalProgressBar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "TypingWindow";
            this.Text = "Dynamic Typing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar FinalProgressBar;
        private System.Windows.Forms.Label TargetWordLabel;
        private System.Windows.Forms.TextBox UserWordTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}