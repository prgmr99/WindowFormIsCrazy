using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    public struct  HistoryModel
    {
        public int id;
        public string fromLanguage;
        public string toLanguage;
        public string inputCode;
        public string outputCode;
        public string explain;

        public HistoryModel(int id, string fromLanguage, string toLanguage, string inputCode, string outputCode, string explain)
        {
            this.id = id;
            this.fromLanguage = fromLanguage;
            this.toLanguage = toLanguage;
            this.inputCode = inputCode;
            this.outputCode = outputCode;
            this.explain = explain;
        }

        public HistoryModel(int i, object[] data)
        {
            this.id = i;
            this.fromLanguage = data[0].ToString();
            this.toLanguage = data[1].ToString();
            this.inputCode = data[2].ToString();
            this.outputCode = data[3].ToString();
            this.explain = data[3].ToString();
        }
    }
}
