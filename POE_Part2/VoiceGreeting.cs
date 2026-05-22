using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part2
{//start of name space 
    class VoiceGreeting
    {//start of class
        public static void PlayGreeting()
        {
            try
            {//start of try
                SoundPlayer player = new SoundPlayer("C:\\Users\\unlin\\source\\repos\\POE_Part2\\POE_Part2\\greeting.wav");
                player.Play();
            
            }//end of try

            catch
            {//start of catch

            }//end of catch



        }
    }//end of class
}//end of name space 


