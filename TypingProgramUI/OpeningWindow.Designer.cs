namespace TypingProgramUI
{
    partial class OpeningWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningWindow));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WelcomeLabel.Location = new System.Drawing.Point(85, 23);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(230, 15);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Dynamic Typing Trainer! ";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.startButton.Location = new System.Drawing.Point(155, 192);
            this.startButton.Margin = new System.Windows.Forms.Padding(1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(91, 52);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.AutoSize = true;
            this.ExplanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ExplanationLabel.Location = new System.Drawing.Point(52, 53);
            this.ExplanationLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(297, 75);
            this.ExplanationLabel.TabIndex = 2;
            this.ExplanationLabel.Text = resources.GetString("ExplanationLabel.Text");
            this.ExplanationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpeningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(400, 347);
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.WelcomeLabel);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "OpeningWindow";
            this.Text = "Dynamic Typing Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label ExplanationLabel;
    }
}

