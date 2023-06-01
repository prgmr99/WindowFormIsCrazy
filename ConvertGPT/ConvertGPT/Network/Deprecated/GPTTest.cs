using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class GPTTest
    {
        public async Task<string> gpttestAsync(string from_lang,string to_lang,string code)
        {
            string str = "";
            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = "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"
            });

            var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage>
                
                {
                    ChatMessage.FromUser("##### Translate this function  from "+from_lang+" into "+to_lang+"\n###"+  from_lang+"\n" + code +"\n###"+to_lang)
                },
                Model = Models.ChatGpt3_5Turbo,
                MaxTokens = 1500//optional
                ,
                Temperature = 0,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,
                Stop = "###"
            }) ;
            if (completionResult.Successful)
            {
                foreach(var result in completionResult.Choices)
                {
                    str += result.Message.Content;
                }
                return str;
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }

                Console.WriteLine($"{completionResult.Error.Code}: {completionResult.Error.Message}");
            }
            return string.Empty;
        }
    }
}
