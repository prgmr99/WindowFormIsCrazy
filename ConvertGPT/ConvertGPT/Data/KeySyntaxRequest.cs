using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class KeySyntaxRequest
    {
        public string code;

        public string code_lang;

        public KeySyntaxRequest(string code, string lang) {
            this.code = code;
            
            this.code_lang = lang;
            
        }
    }
}
