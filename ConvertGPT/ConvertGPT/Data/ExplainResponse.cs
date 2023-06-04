using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    public struct ExplainResponse
    {
        public string language;
        public string explain;

        public ExplainResponse(string language, string explain)
        {
            this.explain = explain;
            this.language = language;
        }
    }
}
