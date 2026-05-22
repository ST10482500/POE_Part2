using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part2
{
    class SentimentAnalyzer
    {
   
        public static string DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried"))
            {
                return "worried";
            }
            if(input.Contains("frustrated"))
            {
                return "frustrated";
            }

           if(input.Contains("curious"))
            {
                return "curious'";
            }

            return "normal";
        
        
        }

        }
    }
