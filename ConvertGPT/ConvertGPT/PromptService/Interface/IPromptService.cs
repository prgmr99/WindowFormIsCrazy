using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenAI.GPT3.ObjectModels.Models;

namespace ConvertGPT
{
    internal interface IPromptService
    {
        string APIkey { get; set; }
        OpenAIService OpenAIService { get; }
        string Output { get; set; }
        Task<string> GetResponse(IPromptType pit);


    }
}
