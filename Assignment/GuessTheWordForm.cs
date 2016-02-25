using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Assignment
{
    public partial class GuessTheWordForm : Form
    {
        player getPlayerinfo = new player(); // player info object
        feedback returnFeedback = new feedback(); //feedback object
        
        public GuessTheWordForm()
        {
            InitializeComponent();
            
        }


        private string textBoxWord;
        string newWord;
        word getNewWord = new word();//new word object
        
        

        private void GuessTheWordForm_Load(object sender, EventArgs e)
        {
            //Loads difficulty of words
            if (word.difficulty == "easy")
            {
                guessLeft.Text = getPlayerinfo.guessesLeftEasy().ToString();
                getNewWord.loadEasyWords();
                wordBox.Text = "?????";
            }
            if (word.difficulty == "hard")
            {
                guessLeft.Text = getPlayerinfo.guessesLeftHard().ToString();
                getNewWord.loadHardWords();
                wordBox.Text = "????????";
            }

            newWord = getNewWord.returnWord();

            

            enableLetters();
            newWordButton.Enabled = false;
            
            
            label1.Text = "Hello " + player.name + "!";
            
            
        }

        

        private void newWordButton_Click(object sender, EventArgs e)
        {
            //restart button, loads new word
            if (word.difficulty == "easy")
            {
                guessLeft.Text = getPlayerinfo.guessesLeftEasy().ToString();
                getNewWord.loadEasyWords();
                wordBox.Text = "?????";
            }
            if (word.difficulty == "hard")
            {
                guessLeft.Text = getPlayerinfo.guessesLeftHard().ToString();
                getNewWord.loadHardWords();
                wordBox.Text = "????????";
            }

            newWord = getNewWord.returnWord();

            

            enableLetters();
            newWordButton.Enabled = false;
            
            
            
            
            
            

            
            
            
        }

        
        // when a letter button is clicked, it is sent to the 'checkguessedletter' method
        private void letterA_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterA.Text, letterA);
        }

        private void letterB_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterB.Text, letterB);
        }

        private void letterC_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterC.Text, letterC);
        }

        private void letterD_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterD.Text, letterD);
        }

        private void letterE_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterE.Text, letterE);
        }

        private void letterF_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterF.Text, letterF);
        }

        private void letterG_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterG.Text, letterG);
        }

        private void letterH_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterH.Text, letterH);
        }

        private void letterI_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterI.Text, letterI);
        }

        private void letterJ_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterJ.Text, letterJ);
        }

        private void letterK_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterK.Text, letterK);
        }

        private void letterL_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterL.Text, letterL);
        }

        private void letterM_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterM.Text, letterM);
        }

        private void letterN_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterN.Text, letterN);
        }

        private void letterO_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterO.Text, letterO);
        }

        private void letterP_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterP.Text, letterP);
        }

        private void letterQ_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterQ.Text, letterQ);
        }

        private void letterR_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterR.Text, letterR);
        }

        private void letterS_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterS.Text, letterS);
        }

        private void letterT_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterT.Text, letterT);
        }

        private void letterU_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterU.Text, letterU);
        }

        private void letterV_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterV.Text, letterV);
        }

        private void letterW_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterW.Text, letterW);
        }

        private void letterX_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterX.Text, letterX);
        }

        private void letterY_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterY.Text, letterY);
        }

        private void letterZ_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterZ.Text, letterZ);
        }

        
        //Method to check if letter guessed is correct

        private void checkGuessedLetter(string wordToGuess, string guessedLetter, Button buttonName)
        {
            textBoxWord = wordBox.Text;           
     
            //length of string
            int stringLength = wordToGuess.Length;

            int guessesLeft = int.Parse(guessLeft.Text);

            int result = 0;
            int counter = 0;
            int foundLength = 0;
            string newChar = "";
            int guessedCorrectlyCounter = 0;

            
            //loop to check wether letter clicked is in the word
            for (int i = 0; i < stringLength; i++)
            {
                
                result = wordToGuess.IndexOf(guessedLetter, foundLength, stringLength - foundLength);//indexof returns -1 if character is not found

                if (result != -1) // if a letter is found
                {
                    
                    foundLength = result + 1;
                    counter++;

                    newChar = wordToGuess.Substring((result), 1);   //grab the letter to be replaced

                    textBoxWord = textBoxWord.Remove(result, 1);              //Remove the ?

                    textBoxWord = textBoxWord.Insert(result, newChar);        //insert the new character
                    guessedCorrectlyCounter++; //increment the correctly gussesed counter
                }
            }

            //check number of guesses left
            if (guessedCorrectlyCounter == 0)
            {
                
                
                guessesLeft = guessesLeft - 1;
                guessLeft.Text = guessesLeft.ToString();
            }

            //if guesses left is 0, game over
            if (guessesLeft == 0)
            {
                MessageBox.Show(returnFeedback.returnNegativeFeedback() + wordToGuess.ToLower());
                disableLetters();
                newWordButton.Enabled = true;
            }
            else
            {
                //new word in text box
                wordBox.Text = textBoxWord;

                if (textBoxWord == wordToGuess)      
                {
                    MessageBox.Show(returnFeedback.returnPositiveFeedback());
                    disableLetters();
                    newWordButton.Enabled = true;
                }

            }

            //switch button off when clicked
            buttonName.Enabled = false;
        }

        //Disable all buttons method
        void disableLetters()
        {
            letterA.Enabled = false;
            letterB.Enabled = false;
            letterC.Enabled = false;
            letterD.Enabled = false;
            letterE.Enabled = false;
            letterF.Enabled = false;
            letterG.Enabled = false;
            letterH.Enabled = false;
            letterI.Enabled = false;
            letterJ.Enabled = false;
            letterK.Enabled = false;
            letterL.Enabled = false;
            letterM.Enabled = false;
            letterN.Enabled = false;
            letterO.Enabled = false;
            letterP.Enabled = false;
            letterQ.Enabled = false;
            letterR.Enabled = false;
            letterS.Enabled = false;
            letterT.Enabled = false;
            letterU.Enabled = false;
            letterV.Enabled = false;
            letterW.Enabled = false;
            letterX.Enabled = false;
            letterY.Enabled = false;
            letterZ.Enabled = false;


        }

        //enable all buttons method
        void enableLetters()
        {
            letterA.Enabled = true;
            letterB.Enabled = true;
            letterC.Enabled = true;
            letterD.Enabled = true;
            letterE.Enabled = true;
            letterF.Enabled = true;
            letterG.Enabled = true;
            letterH.Enabled = true;
            letterI.Enabled = true;
            letterJ.Enabled = true;
            letterK.Enabled = true;
            letterL.Enabled = true;
            letterM.Enabled = true;
            letterN.Enabled = true;
            letterO.Enabled = true;
            letterP.Enabled = true;
            letterQ.Enabled = true;
            letterR.Enabled = true;
            letterS.Enabled = true;
            letterT.Enabled = true;
            letterU.Enabled = true;
            letterV.Enabled = true;
            letterW.Enabled = true;
            letterX.Enabled = true;
            letterY.Enabled = true;
            letterZ.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
