using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class Convert : IPromptType
    {
        const string PROMPT_Template =
@"##### Translate this code from {0} into {1} 
### {0}
{2}
### {1}";
        public string Prompt { get; set; }

        public string Prompt_Template => PROMPT_Template;
        public ChatCompletionCreateRequest Options { get; }

        public Convert(string from_lang, string to_lang, string code)
        {
            
            Prompt = string.Format(PROMPT_Template, from_lang, to_lang,code);
            
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
                Stop = "###"
            };
        }
    }
}
