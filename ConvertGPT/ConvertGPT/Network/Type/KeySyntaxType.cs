
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class KeySyntaxType : IPromptType
    {
        const string PROMPT_Template =
@"
```{0}
{1}
```
List important grammer elements used above {0} code to korean
";
        public string Prompt_Template => PROMPT_Template;

        public string Prompt { get; set; }

        public ChatCompletionCreateRequest Options { get; }
        public KeySyntaxType(KeySyntaxRequest kr)
        {
            Prompt = string.Format(Prompt_Template, kr.code_lang, kr.code);
            Options = new ChatCompletionCreateRequest()
            {
                Messages = new List<ChatMessage>
                {
                    ChatMessage.FromSystem(@"your task is to answer in a consistent style.
you should answer like below.
#####
1.Import statement: `import sys` is used to import the `sys` module which provides access to some variables used or maintained by the interpreter and to functions that interact strongly with the interpreter.
2.Function definition: `def dfs_queen(x, y, v):` and `def dfs_knight(x, y):` are used to define two functions that take in parameters and perform certain operations.

#####
"),
                    ChatMessage.FromUser(@"```python
def hello():
    print('hello')
hello()
```
List important grammer elements used above python code to korean"),
                    ChatMessage.FromAssistant(@"1.함수 정의: hello 함수를 def 키워드를 사용하여 정의합니다.
2.print 함수 : 괄호 안에 전달된 값을 표준 출력으로 보내어 화면에 출력합니다."),
          
                    ChatMessage.FromUser(Prompt)
                },
                Model = Models.ChatGpt3_5Turbo,
                MaxTokens = 3000,
                Temperature = 0,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,
                Stop = "###"
            }; ;
        }
        public object parse_output(string output)
        {
            List<string> result = new List<string>();
            string[] syntax_list = output.Split('\n');
            for (int i = 0; i < syntax_list.Length; i++)
            {
                
                result.Add(syntax_list[i].Substring((int)((i + 1) / 10) + 2));
            }
            return result;
        }
    }
}
