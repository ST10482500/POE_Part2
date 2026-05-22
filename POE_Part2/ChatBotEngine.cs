using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part2
{
     class ChatBotEngine
    {

        ResponseManager responseManager = new ResponseManager();


        public string GetResponse(string input)
        {

            input = input.ToLower();

            string sentiment =
                SentimentAnalyzer.DetectSentiment(input);

            if(sentiment == "worried")
            {

                return "It is understandable to feel worried. Cybersecurity threats can be stressful. Here is a helpful tip: Never click suspicious links.";

            }

            if(sentiment == "frustrated")
            {
                return "I understand your frustration. Cybersecurity can be confusing sometimes, but staying informed helps keep you safe.";
            }

            if (input.Contains("My name is"))
            {
                string[] parts = input.Split(' ');

                MemoryManager.UserName = parts[parts.Length - 1];

                return "Nice to meet you" + MemoryManager.UserName;
            }
            if (input.Contains("I like "))
            {
                string[] parts = input.Split(' ');

                MemoryManager.FavouriteTopic = parts[parts.Length - 1];
                return "Great! I will remember that you like " + MemoryManager.FavouriteTopic;

             }

            if (input.Contains("Remember"))
            {
                return"Your name is " + MemoryManager.UserName +
                    " and your favourite topic is " + MemoryManager.FavouriteTopic;
            }
            if(input.Contains("tell me more"))
            {
                return "Always update your software and avoid suspicious websites.";
            }

            string keywordResponse = responseManager.GetKeywordResponse(input);

            if(keywordResponse != "")
            {
                return keywordResponse;

             }

            return "I am not sure I understand. Please try rephasing.";
        
        }
    
    
    
    }
}
