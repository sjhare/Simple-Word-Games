using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;



namespace Assignment
{
    
    public partial class MainMenu : Form
    {
        //create word difficulty object
        word difficulty = new word();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //store player name
            player.name = textBox1.Text;
            GuessTheWordForm guessTheWord = new GuessTheWordForm();
            guessTheWord.ShowDialog();//Shows guess the word game
            

            
           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            noNameAlert.Text = "";
            //stops players proceding if nothing is inserted into text box
            if (textBox1.TextLength == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;

                noNameAlert.Text = "You have to insert a name before you can continue";
                
            }

        
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)    // Allowing only any letter
                    || e.KeyChar == '\b' || e.KeyChar == ' ')              // Allowing BackSpace character
            {
                e.Handled = false; //Only allowing a space after a character is inserted first
                if (e.KeyChar == ' ' & textBox1.Text == "")
                {
                    e.Handled = true;
                }
            }
            
            else
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.name = textBox1.Text;
            
            Conundrum openConundrum = new Conundrum();
            openConundrum.ShowDialog();//open conundrum game
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //loads difficulty - easy
            button1.Enabled = true;
            button2.Enabled = true;
            difficulty.loadEasyWords();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //loads difficulty - hard
            button1.Enabled = true;
            button2.Enabled = true;
            difficulty.loadHardWords();
        }

        


    }
}
