using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    public struct ExplainRequest
    {
        public string language;
        public string code;

        public ExplainRequest(string language, string code)
        {
            this.code = code;
            this.language = language;
        }
    }
}
