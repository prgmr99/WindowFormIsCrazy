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
        public string timeAgo;
        public string fromLanguage;
        public string toLanguage;
        public string inputCode;
        public string outputCode;
        public string explain;

        public HistoryModel(int id, string time, string fromLanguage, string toLanguage, string inputCode, string outputCode, string explain)
        {
            this.id = id;
            this.timeAgo = GetTimeAgo(time, DateTime.Now);
            this.fromLanguage = fromLanguage;
            this.toLanguage = toLanguage;
            this.inputCode = inputCode;
            this.outputCode = outputCode;
            this.explain = explain;
        }

        public HistoryModel(int i, object[] data)
        {
            this.id = i;
            this.timeAgo = GetTimeAgo(data[0].ToString(), DateTime.Now);
            this.fromLanguage = data[1].ToString();
            this.toLanguage = data[2].ToString();
            this.inputCode = data[3].ToString();
            this.outputCode = data[4].ToString();
            this.explain = data[5].ToString();

            
        }

        static private string GetTimeAgo(string startString, DateTime end)
        {
            DateTime start = DateTime.Parse(startString);

            TimeSpan timeSpan = end - start;

            if (timeSpan.TotalSeconds < 1)
            {
                return "just now";
            }
            else if (timeSpan.TotalMinutes < 1)
            {
                int seconds = (int)timeSpan.TotalSeconds;
                return $"{seconds} second{(seconds != 1 ? "s" : "")} ago";
            }
            else if (timeSpan.TotalHours < 1)
            {
                int minutes = (int)timeSpan.TotalMinutes;
                return $"{minutes} minute{(minutes != 1 ? "s" : "")} ago";
            }
            else if (timeSpan.TotalDays < 1)
            {
                int hours = (int)timeSpan.TotalHours;
                return $"{hours} hour{(hours != 1 ? "s" : "")} ago";
            }
            else
            {
                int days = (int)timeSpan.TotalDays;
                return $"{days} day{(days != 1 ? "s" : "")} ago";
            }
        }

    }
}
