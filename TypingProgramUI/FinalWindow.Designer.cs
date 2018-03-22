namespace TypingProgramUI
{
    partial class FinalWindow
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
            this.againButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.finalLabel = new System.Windows.Forms.Label();
            this.userWordsPerMinute = new System.Windows.Forms.Label();
            this.wordsCorrect = new System.Windows.Forms.Label();
            this.accuracy = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // againButton
            // 
            this.againButton.BackColor = System.Drawing.Color.Black;
            this.againButton.Location = new System.Drawing.Point(80, 225);
            this.againButton.Margin = new System.Windows.Forms.Padding(1);
            this.againButton.Name = "againButton";
            this.againButton.Size = new System.Drawing.Size(70, 30);
            this.againButton.TabIndex = 0;
            this.againButton.Text = "Again";
            this.againButton.UseVisualStyleBackColor = false;
            this.againButton.Click += new System.EventHandler(this.againButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Black;
            this.doneButton.Location = new System.Drawing.Point(253, 225);
            this.doneButton.Margin = new System.Windows.Forms.Padding(1);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(70, 30);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.finalLabel.Location = new System.Drawing.Point(114, 40);
            this.finalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(172, 17);
            this.finalLabel.TabIndex = 2;
            this.finalLabel.Text = "Thanks for typing with us! \r\n";
            // 
            // userWordsPerMinute
            // 
            this.userWordsPerMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userWordsPerMinute.Location = new System.Drawing.Point(1, 168);
            this.userWordsPerMinute.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.userWordsPerMinute.Name = "userWordsPerMinute";
            this.userWordsPerMinute.Size = new System.Drawing.Size(398, 23);
            this.userWordsPerMinute.TabIndex = 3;
            this.userWordsPerMinute.Text = "label1";
            this.userWordsPerMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordsCorrect
            // 
            this.wordsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.wordsCorrect.Location = new System.Drawing.Point(12, 90);
            this.wordsCorrect.Name = "wordsCorrect";
            this.wordsCorrect.Size = new System.Drawing.Size(376, 23);
            this.wordsCorrect.TabIndex = 4;
            this.wordsCorrect.Text = "label1";
            this.wordsCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accuracy
            // 
            this.accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracy.Location = new System.Drawing.Point(1, 201);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(398, 23);
            this.accuracy.TabIndex = 5;
            this.accuracy.Text = "label1";
            this.accuracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timeLabel.Location = new System.Drawing.Point(11, 126);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(378, 23);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "label1";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(400, 347);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.wordsCorrect);
            this.Controls.Add(this.userWordsPerMinute);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.againButton);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FinalWindow";
            this.Text = "Thanks for typing with us!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button againButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label userWordsPerMinute;
        private System.Windows.Forms.Label wordsCorrect;
        private System.Windows.Forms.Label accuracy;
        private System.Windows.Forms.Label timeLabel;
    }
}