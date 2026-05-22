using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part2
{
    class ResponseManager
    {

        Random random = new Random();

        Dictionary<string, List<string>> responses =
            new Dictionary<string, List<string>>()

            {
                {
                    "password",
                    new List<string>()
                    {
                        "Use Strong passwords with symbols and numbers.",
                        "Avoid using personal information in passwords.",
                        "Change your passwords regularly."
                    }
                },
                {

                    "phishing",
                    new List<string>()
                    {
                        "Never click suspicious e-mail links.",
                        "Scammers often pretend to be trusted companies.",
                        "Always verify e-mail senders carefully."
                    }
                },
                {

                    "privacy",
                    new List<string>()
                    {
                        "Review your privacy settings regularly.",
                        "Avoid oversharing personal information online.",
                        "Enable two-factor authentication for added security."
                    }


                },
                {
                    "scam",
                    new List<string>()
                    {
                        "if something sounds too good to be true, it probably is.",
                        "Never send money to unknown people online.",
                        "Always verify suspicious offers."
                    }
                }
            };

        public string GetKeywordResponse(string input)
        {

            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    int index = random.Next(responses[keyword].Count);

                    return responses[keyword][index];
                }
            }
            return "";
           }
    
    }

}






