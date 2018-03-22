using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TypingProgramUI
{
    public partial class TypingWindow : Form
    {
        public static int numberCorrect { get; set; }
        WordGenerator wordGenerator = new WordGenerator(new User());
        public static double time { get; set; }
        Stopwatch watch = new Stopwatch();

        public TypingWindow()
        {
            InitializeComponent();
            TargetWordLabel.Text = wordGenerator.generateWord();
            FinalProgressBar.Maximum = 35;
            FinalProgressBar.Step = 1;
            watch.Start();
        }

        public void submitButton_Click(object sender, EventArgs e)
        {
           
            char[] targetWordArray = TargetWordLabel.Text.ToCharArray();
            char[] userWordArray = UserWordTextBox.Text.ToCharArray();

            TargetWordLabel.Text = wordGenerator.generateWord();
            FinalProgressBar.PerformStep();

            ErrorFinder errorFinder = new ErrorFinder();
            char[] wrongChars = errorFinder.findErrors(targetWordArray, userWordArray, new List<int>(), 0);
            if (wrongChars.Length > 0)
            {
                foreach(char ch in wrongChars)
                {
                    wordGenerator.missedChar(Convert.ToInt32(ch));
                }
            }
            else
            {
                numberCorrect++;
            }


            if (FinalProgressBar.Value == 35)
            {
                watch.Stop();
                time = (watch.Elapsed.TotalMinutes);
                this.Hide();
                FinalWindow FinalWindow = new FinalWindow();
                FinalWindow.Show();
            }
            UserWordTextBox.Clear();
            
        }
    }
}
