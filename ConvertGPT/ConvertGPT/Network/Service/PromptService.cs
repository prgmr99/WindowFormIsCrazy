using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{

    internal class PromptService : IPromptService
    {
        public string APIkey { get; set; }

        public string Output { get; set; }

        private OpenAIService openAIService;
        public OpenAIService OpenAIService => openAIService;

        public virtual async Task<string> GetResponse(IPromptType pit)
        {
            var completionResult = await openAIService.ChatCompletion.CreateCompletion(pit.Options);
            if (completionResult.Successful)
            {
                foreach (var result in completionResult.Choices)
                {
                    Output += result.Message.Content;
                }
                //Console.Out.WriteLine(Output);
                return Output;
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

        public PromptService()
        {
            APIkey = Secret.APIKEYS;
            openAIService = new OpenAIService(new OpenAiOptions { ApiKey = APIkey });
        }
    }
}
