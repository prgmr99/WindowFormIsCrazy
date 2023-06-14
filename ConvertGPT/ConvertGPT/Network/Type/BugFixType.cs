using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class BugFixType :IPromptType
    {
        const string PROMPT_Template =
@"##### Fix bugs in the below code
 
### Buggy {0}
{1}
### Fixed {0}";
        public string Prompt { get; set; }

        public string Prompt_Template => PROMPT_Template;
        public ChatCompletionCreateRequest Options { get; }

        public BugFixType(BugFixRequest request)
        {
            string lang = request.language;
            string code = request.code;

            Prompt = string.Format(PROMPT_Template, lang, code);

            Options = new ChatCompletionCreateRequest()
            {
                Messages = new List<ChatMessage>

                {
                    ChatMessage.FromUser(Prompt)
                },
                Model = Models.ChatGpt3_5Turbo,
                MaxTokens = 500,
                Temperature = 0,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,

            };
        }
    }
}
