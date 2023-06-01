using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    struct ConvertRequestModel
    {
        public string code;
        public string fromLanguage;
        public string toLanguage;

        public ConvertRequestModel(string code, string fromLanguage, string toLanguage) {
            this.code = code;
            this.fromLanguage = fromLanguage;
            this.toLanguage = toLanguage;
        }
    }
}
