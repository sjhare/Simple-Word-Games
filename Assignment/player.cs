using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;



namespace Assignment
{
    class player
    {

        public static string name
        {
            //store player name
            get;
            set;

        }

        // store guesses and time for each difficulty
        public int guessesLeftHard()
        {
            return 3;
        }

        public int guessesLeftEasy()
        {
            return 5;
        }

        public string timeLeftHard()
        {
            return "30";
        }

        public string timeLeftEasy()
        {
            return "60";
        }
        
        
    }
}
