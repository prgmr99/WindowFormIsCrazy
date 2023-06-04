using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    struct ConvertRequest
    {
        public string code;
        public string fromLanguage;
        public string toLanguage;

        public ConvertRequest(string code, string fromLanguage, string toLanguage) {
            this.code = code;
            this.fromLanguage = fromLanguage;
            this.toLanguage = toLanguage;
        }
    }
}
