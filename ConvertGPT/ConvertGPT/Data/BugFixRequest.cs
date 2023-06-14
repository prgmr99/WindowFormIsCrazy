using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class BugFixRequest
    {
        public string language;
        public string code;

        public BugFixRequest(string language, string code)
        {
            this.code = code;
            this.language = language;
        }
    }
}
