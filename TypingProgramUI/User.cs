using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingProgramUI
{
    public class User
    {
        public double[] percentages = new double[26];

        public User()
        {
            percentages[0] = .08167;
            percentages[1] = percentages[0] + .01492;
            percentages[2] = percentages[1] + .02782;
            percentages[3] = percentages[2] + .04253;
            percentages[4] = percentages[3] + .12703;
            percentages[5] = percentages[4] + .02228;
            percentages[6] = percentages[5] + .02015;
            percentages[7] = percentages[6] + .06094;
            percentages[8] = percentages[7] + .06966;
            percentages[9] = percentages[8] + .00153;
            percentages[10] = percentages[9] + .00772;

            percentages[11] = percentages[10] + .04025;
            percentages[12] = percentages[11] + .02406;
            percentages[13] = percentages[12] + .06749;
            percentages[14] = percentages[13] + .07507;
            percentages[15] = percentages[14] + .01929;
            percentages[16] = percentages[15] + .00095;
            percentages[17] = percentages[16] + .05987;
            percentages[18] = percentages[17] + .06327;
            percentages[19] = percentages[18] + .09056;
            percentages[20] = percentages[19] + .02758;

            percentages[21] = percentages[20] + .00978;
            percentages[22] = percentages[21] + .02360;
            percentages[23] = percentages[22] + .00150;
            percentages[24] = percentages[23] + .01974;
            percentages[25] = percentages[24] + .00074;
        }

        public User(double[] percentages)
        {
            for (int i = 0; i < 26; i++)
            {
                this.percentages[i] = percentages[i];
            }
        }

        public void changePercentages(int charMissed)
        {
            charMissed -= 97; //sets a to 0 and z to 25
            double percentageIncrease = .5 * (1 + this.percentages[charMissed]) / this.percentages[charMissed];
            double[] curDiff = new double[26];

            curDiff[0] = this.percentages[0];

            for (int i = 1; i < 26; i++)
            {
                curDiff[i] = this.percentages[i] - this.percentages[i - 1];
            }

            double percentageDecrease = (1 - (percentageIncrease * curDiff[charMissed])) / (1 - curDiff[charMissed]);
            for (int i = 0; i < 26; i++)
            {
                if (i == charMissed)
                {
                    curDiff[i] = curDiff[i] * percentageIncrease;
                }
                else
                {
                    curDiff[i] = curDiff[i] * percentageDecrease;
                }
            }

            this.percentages[0] = curDiff[0];
            for (int i = 1; i < 26; i++)
            {
                this.percentages[i] = this.percentages[i - 1] + curDiff[i];
            }
        }

        public char chooseChar()
        {
            char selectedChar = 'e';
            Random rnd = new Random();
            double charSpectrumNum = rnd.NextDouble();
            for (int i = 0; i < 26; i++)
            {
                if (charSpectrumNum <= percentages[i])
                {
                    selectedChar = (char)(i + 97);
                    break;
                }
            }

            return selectedChar;
        }
    }
}
