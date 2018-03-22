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
    public partial class OpeningWindow : Form
    {
        public OpeningWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypingWindow TypingWindow = new TypingWindow();
            TypingWindow.Show();
        }
    }
}
