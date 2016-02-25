using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Assignment
{
    class word
    {
        
        int counter;
        
        static string[] wordListFileHard = File.ReadAllLines(@"..\..\wordListHard.txt");//Hard file list
        static string[] wordListFileEasy = File.ReadAllLines(@"..\..\wordListEasy.txt");//Easy file list
        public static string randomWord; //stores the random word
        string shuffled; //Stores shuffled random word
        public static string  difficulty = "";
        

        public string returnWord()
        {
            //return word to 'guess the word'
            return randomWord;
            
        }

        

        public void loadEasyWords() //gets a random easy word from the list
        {
            shuffleWordList();
            randomWord = wordListFileEasy[counter];
            difficulty = "easy";
        }

        public void loadHardWords() //gets a random hard word from the list
        {
            shuffleWordList();
            randomWord = wordListFileHard[counter];
            difficulty = "hard";
        }

        public void shuffleWordList() //generates a radom number
        {
            Random rnd = new Random();
            
            if (difficulty == "easy")
                counter = rnd.Next(0, wordListFileEasy.Length - 1);
            if (difficulty == "hard")
                counter = rnd.Next(0, wordListFileHard.Length - 1);
        }

        public string conundrumWordReturn() //returns word to conundrum game
        {
                      
            shuffleLetters();
            return shuffled;

        }

        public void shuffleLetters() //shuffles letters for conundrum game
        {
            Random shuffle = new Random();
            shuffled = new string(randomWord.OrderBy(s => shuffle.Next()).ToArray());
        }
    }
}
