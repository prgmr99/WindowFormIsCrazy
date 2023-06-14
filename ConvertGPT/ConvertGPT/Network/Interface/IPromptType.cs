using OpenAI.GPT3.ObjectModels.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{

    internal interface IPromptType
    {
        string Prompt_Template { get; }
        string Prompt { get; }
        ChatCompletionCreateRequest Options { get; }
        object parse_output(string output);
    }
}
