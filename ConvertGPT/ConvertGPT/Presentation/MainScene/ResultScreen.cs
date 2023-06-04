using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertGPT.MainScene
{
    public partial class ResultScreen : UserControl
    {

        public event ResultEventSender resultEventSender;

        ConvertRequest data = new ConvertRequest("","","");

        public ResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScene_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            resultEventSender(sender, ResultEvent.backButtonClicked, "");
        }

        public void dataBind(object obj)
        {
            Console.WriteLine("dataBind");
            if (obj is ConvertRequest)
            {
                ConvertRequest data = (ConvertRequest)obj;
                this.data = data;
            }

            updateUI();
            requestConvertAPI(this.data);
        }

        private void updateUI() {

            this.languageLabel.Text = data.toLanguage;
        }
        private async void requestConvertAPI(ConvertRequest data)
        {
            Console.WriteLine("requestConvertAPI");
            PromptService ps = new PromptService();
            Task<string> result = ps.GetResponse(new ConvertType(data));

            Console.WriteLine("서버통신을 시작합니다");
            await result;
            Console.WriteLine($"서버 응답이 왔습니다. \n {result.Result}");

            metroTextBox1.Text = result.Result;
            return;
        }


        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

            Console.WriteLine("새로고침 버튼이 눌렸습니다.");
            LanguageForm languageForm = new MainScene.LanguageForm();
            languageForm.selectLanguageEventSender += SelectLanguageEventSender;
            languageForm.ShowDialog();

            metroTextBox1.Text = "로딩 중..";
        }

        private void SelectLanguageEventSender(object sender, SelectLanguageEvent selectLanguageEvent, Object data)
        {

            this.data.toLanguage = data.ToString();
            languageLabel.Text= data.ToString();
            requestConvertAPI(this.data);
        }
    }


}
