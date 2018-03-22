using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingProgramUI
{
    public partial class FinalWindow : Form
    {
        
        public FinalWindow()
        {
            InitializeComponent();

            int numberCorrect = TypingWindow.numberCorrect;
            wordsCorrect.Text = "You got " + numberCorrect + " words correct out of a possible 35!";
            Double time = TypingWindow.time;
            timeLabel.Text = "Your time was approximately " + Math.Round(time, 1) + " minutes!";
            userWordsPerMinute.Text = "That means your typing speed is " + Math.Round((35/time), 1) + " words per minute!";
            double accur = (100 * numberCorrect / 35);
            accuracy.Text = "Your total accuracy was " + Math.Round(accur, 2) + "%!";
        }


        private void againButton_Click(object sender, EventArgs e)
        {
            this.Close();
            OpeningWindow OpeningWindow = new OpeningWindow();
            OpeningWindow.Show();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
