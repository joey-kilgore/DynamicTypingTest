using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingProgramUI
{
    class ErrorFinder
    {
        public char[] findErrors(char[] correctWord, char[] userWord, List<int> wrongChars, int curIndex)
        {
            if (curIndex >= correctWord.Length)
            {
                for (int i = curIndex; i < userWord.Length; i++)
                {
                    wrongChars.Add(i);
                }

                List<char> listOfWrongChars = new List<char>();

                foreach (int index in wrongChars)
                {
                    listOfWrongChars.Add(userWord[index]);
                }

                char[] wrongCharArr = listOfWrongChars.ToArray();
                return wrongCharArr;
            }
            else if (curIndex >= userWord.Length)
            {
                List<char> tempUserWord = userWord.ToList();
                for (int i = curIndex; i < correctWord.Length; i++)
                {
                    tempUserWord.Add(correctWord[i]);
                    wrongChars.Add(i);
                }
                userWord = tempUserWord.ToArray();

                List<char> listOfWrongChars = new List<char>();

                foreach (int index in wrongChars)
                {
                    listOfWrongChars.Add(userWord[index]);
                }

                char[] wrongCharArr = listOfWrongChars.ToArray();
                return wrongCharArr;
            }
            else if (userWord[curIndex] == correctWord[curIndex])
            {
                return findErrors(correctWord, userWord, wrongChars, (curIndex + 1));
            }
            else
            {
                //create char array if previous char was doubled
                if (curIndex > 0 && correctWord[curIndex - 1] == userWord[curIndex])
                {
                    List<char> tempChars = userWord.OfType<char>().ToList();
                    tempChars.RemoveAt(curIndex);

                    //int[] tempWrongCharsArr = wrongChars.ToArray();
                    //tempWrongCharsArr[wrongChars.IndexOf(curIndex)]--;
                    //List<int> tempWrongCharsList = tempWrongCharsArr.ToList<int>();
                    List<int> tempWrongCharsList = wrongChars;
                    tempWrongCharsList.Add(curIndex - 1);
                    char[] errorsDoubleLetter = findErrors(correctWord, tempChars.ToArray<char>(), tempWrongCharsList, curIndex);
                    try
                    {
                        if (curIndex < (correctWord.Length) && correctWord[curIndex + 1] == userWord[curIndex])
                        {
                            tempChars = userWord.OfType<char>().ToList();
                            tempChars.Insert(curIndex, correctWord[curIndex]);

                            tempWrongCharsList = wrongChars;
                            tempWrongCharsList.Add(curIndex);

                            char[] errorsMissedLetter = findErrors(correctWord, tempChars.ToArray(), tempWrongCharsList, curIndex);

                            if (errorsDoubleLetter.Length < errorsMissedLetter.Length)
                            {
                                return errorsDoubleLetter;
                            }
                            else
                            {
                                return errorsMissedLetter;
                            }
                        }
                    }
                    catch
                    {
                    }

                    return errorsDoubleLetter;
                }
                //create char array if previous char was missed
                else if (curIndex < (correctWord.Length) && correctWord[curIndex + 1] == userWord[curIndex])
                {
                    List<char> tempChars = userWord.OfType<char>().ToList();
                    tempChars.Insert(curIndex, correctWord[curIndex]);

                    List<int> tempWrongCharsList = wrongChars;
                    tempWrongCharsList.Add(curIndex);

                    char[] errorsMissedLetter = findErrors(correctWord, tempChars.ToArray(), tempWrongCharsList, curIndex);
                    return errorsMissedLetter;
                }
                else
                {
                    List<char> tempCharsFinal = userWord.OfType<char>().ToList();
                    tempCharsFinal.RemoveAt(curIndex);
                    tempCharsFinal.Insert(curIndex, correctWord[curIndex]);

                    List<int> tempWrongCharsListFinal = wrongChars;
                    tempWrongCharsListFinal.Add(curIndex);

                    return findErrors(correctWord, tempCharsFinal.ToArray(), tempWrongCharsListFinal, curIndex);
                }
            }
        }
    }
}
