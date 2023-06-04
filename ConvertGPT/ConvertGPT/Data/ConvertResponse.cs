using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    public struct ConvertResponse
    {
        public string language;
        public string code;

        public ConvertResponse(string language, string code)
        {
            this.language = language;
            this.code = code;
        }


        ExplainRequest transform()
        {
            return new ExplainRequest(language, code);
        }
    }
}
