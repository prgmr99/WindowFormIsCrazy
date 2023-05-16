using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class ExplainCode
    {
        public async Task<string> explainCode(string code)
        {
            string str = "";
            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = "계현's API key"
            });
            var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest()
            {
                Messages = new List<ChatMessage>
                {
                    ChatMessage.FromUser(code)
                },// code로 변경해야 함.
                Model = Models.ChatGpt3_5Turbo,
                MaxTokens = 1500,
                Temperature = 0,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,
                // Stop = Not necessary
            });

            if (completionResult.Successful)
            {
                foreach (var result in completionResult.Choices)
                {
                    str += result.Message.Content;
                    //Console.WriteLine(result.Message.Content); 확인
                }
                return str;
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }
                //Console.WriteLine($"{completionResult.Error.Code}: {completionResult.Error.Message}");
                return $"{completionResult.Error.Code}: {completionResult.Error.Message}";
            }
        }
    }
}
