using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class ConvertGPTGlobal
    {


    }

    public enum HomeEvent { 
        nextButtonClicked
    }

    public enum ResultEvent { 
        backButtonClicked
    }

    public enum SelectLanguageEvent { 
        languageClicked
    }

    public delegate void HomeEventSender(object sender, HomeEvent homeEvent, Object data);
    public delegate void ResultEventSender(object sender, ResultEvent resultEvent, Object data);
    public delegate void SelectLanguageEventSender(object sender, SelectLanguageEvent selectLanguageEvent, Object data);
    public delegate void HistoryCellSelectEventSender(int id);

}
