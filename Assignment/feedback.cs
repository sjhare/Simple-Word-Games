using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    class feedback
    {
        public string returnPositiveFeedback() //postive
        {
            return "Correct well done!";
        }

        public string returnNegativeFeedback() //neagtive
        {
            return "You lost, the word was ";
        }

        public string outOfTimeFeedback() //out of time
        {
            return "Out of time! The word was ";
        }
    }
}
