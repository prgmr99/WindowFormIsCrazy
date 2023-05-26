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

    public delegate void HomeEventSender(object sender, HomeEvent homeEvent);
    public delegate void ResultEventSender(object sender, ResultEvent resultEvent);

}
