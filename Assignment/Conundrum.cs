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

namespace Assignment
{
    public partial class Conundrum : Form
    {
        word getNewWord = new word(); //new word object
        feedback returnFeedback = new feedback(); //feedback object
        player playerTime = new player(); //player timer object
        public int countDown;

        public Conundrum()
        {
            InitializeComponent();
        }

        private void Conundrum_Load(object sender, EventArgs e)
        {
            //loads word difficulty
            if (word.difficulty == "easy")
            {
                label5.Text = playerTime.timeLeftEasy();
                progressBar1.Maximum = 60;
                getNewWord.loadEasyWords();
            }
            if (word.difficulty == "hard")
            {
                label5.Text = playerTime.timeLeftHard();
                progressBar1.Maximum = 30;
                getNewWord.loadHardWords();

            }

            label2.Text = "Hello "  + player.name + "!";
            label1.Text = getNewWord.conundrumWordReturn();
            timer1.Enabled = true;
            timer1.Start();

            progressBar1.Enabled = true;
            
            timer1.Interval = 1000;
            
            
            
            
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)    // Allowing only any letter
                    || e.KeyChar == '\b')              // Allowing BackSpace character
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check button method
            timer1.Stop();
            progressBar1.Enabled = false;
            textBox1.Text = textBox1.Text.ToLower();
            //check if the word guessed is correct
            if (textBox1.Text == word.randomWord)
            {
                MessageBox.Show(returnFeedback.returnPositiveFeedback());
                if (word.difficulty == "easy")
                {
                    getNewWord.loadEasyWords();
                    label5.Text = playerTime.timeLeftEasy();
                }
                if (word.difficulty == "hard")
                {
                    getNewWord.loadHardWords();
                    label5.Text = playerTime.timeLeftHard();
                }

                label1.Text = getNewWord.conundrumWordReturn();
                progressBar1.Value = 0;
                textBox1.ResetText();
                timer1.Start();
            }
            //if word guessed is wrong, the game fetches a new word
            else
            {
                MessageBox.Show(returnFeedback.returnNegativeFeedback() + word.randomWord);
                if (word.difficulty == "easy")
                {
                    getNewWord.loadEasyWords();
                    label5.Text = playerTime.timeLeftEasy();
                }
                if (word.difficulty == "hard")
                {
                    getNewWord.loadHardWords();
                    label5.Text = playerTime.timeLeftHard();
                }
                label1.Text = getNewWord.conundrumWordReturn();
                progressBar1.Value = 0;
                textBox1.ResetText();
                timer1.Start();
                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer and progress bar
            progressBar1.Increment(1);
            pluralSeconds();
            countDown = Convert.ToInt32(label5.Text);
            countDown = countDown - 1;
            string countDownCon = Convert.ToString(countDown);
            label5.Text = countDownCon;
            // if out of time, show feedback
            if (countDown == 0)
            {
                timer1.Stop();
                MessageBox.Show(returnFeedback.outOfTimeFeedback() + word.randomWord);

                if (word.difficulty == "easy")
                {
                    getNewWord.loadEasyWords();
                    label5.Text = playerTime.timeLeftEasy();
                }
                if (word.difficulty == "hard")
                {
                    getNewWord.loadHardWords();
                    label5.Text = playerTime.timeLeftHard();
                }
                label1.Text = getNewWord.conundrumWordReturn();
                progressBar1.Value = 0;
                textBox1.ResetText();
                timer1.Start();
            }
            
            

                   

        }

        

        private void pluralSeconds()
        {
            //Make the word second plural
            if (countDown == 2)
                label6.Text = "Second";
            else
                label6.Text = "Seconds";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//close game
            timer1.Stop();
        }

        private void Conundrum_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
        

        
    }
}
