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
        public async Task<string> gpttestAsync(string code)
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
        
        ChatMessage.FromUser("##### Translate this function  from c# into Python\r\n###" + code +"### Python")
    },
                Model = Models.ChatGpt3_5Turbo,
                MaxTokens = 1500//optional
                ,
                Temperature = 0,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,
                Stop = "###"
            });
            if (completionResult.Successful)
            {
                foreach(var result in completionResult.Choices)
                {
                    str+= result.ToString();
                }
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }

                Console.WriteLine($"{completionResult.Error.Code}: {completionResult.Error.Message}");
            }
            return str;
        }
    }
}
