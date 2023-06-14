using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvertGPT.Global.Component;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace ConvertGPT.MainScene
{
    public partial class ResultScreen : UserControl
    {

        public event ResultEventSender resultEventSender;

        ConvertRequest convertRequest = new ConvertRequest();
        ConvertResponse convertResponse = new ConvertResponse();
        ExplainRequest explainRequest = new ExplainRequest();
        ExplainResponse explainResponse = new ExplainResponse();


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
            if (obj is ConvertRequest)
            {
                ConvertRequest data = (ConvertRequest)obj;

                this.convertRequest = data;
                this.convertResponse.language = data.toLanguage;
                this.explainRequest.language = data.toLanguage;
                this.explainResponse.language = data.toLanguage;

                requestConvertAPI(this.convertRequest);
            }
        }

        private void updateCodeTextBoxUI() {
            this.languageLabel.Text = convertResponse.language;


            CodeTextBox.customizeSyntaxHighlighting(this.languageLabel.Text, this.metroTextBox1);

            this.metroTextBox1.Text = convertResponse.code;
        }

        private void updateExplainBoxUI()
        {
            this.metroTextBox2.Text = explainResponse.explain;
        }

        private void saveConvertResultDataBase(ConvertRequest request, ConvertResponse response) {

            using (MySqlConnection conn = new MySqlConnection(Secret.ExConnect))
            {
                conn.Open();
                string sql = string.Format("insert into history(fromlang, tolang, coderecord, coderesult) values ({0}, {1}, {2}, {3});", "\'" + request.fromLanguage + "\'", "\'" + response.language + "\'", "\'" + request.code + "\'", "\'" + response.code + "\'");

                try
                {
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private async void requestConvertAPI(ConvertRequest request)
        {
            PromptService ps = new PromptService();
            Task<string> result = ps.GetResponse(new ConvertType(request));

            Console.WriteLine("requestConvertAPI 서버통신을 시작합니다");
            await result;
            Console.WriteLine($"서버 응답이 왔습니다. \n {result.Result}");

            this.convertResponse.code = result.Result;
            this.explainRequest.code = result.Result;

            //saveConvertResultDataBase(this.convertRequest, this.convertResponse);

            updateCodeTextBoxUI();
            requestExplainAPI(this.explainRequest);
            return;
        }

        private async void requestExplainAPI(ExplainRequest request)
        {

            Console.WriteLine("requestConvertAPI");
            PromptService ps = new PromptService();
            Task<string> result = ps.GetResponse(new ExplainType(request));

            Console.WriteLine("requestExplainAPI 서버통신을 시작합니다");
            await result;
            Console.WriteLine($"서버 응답이 왔습니다. \n {result.Result}");
            
            this.explainResponse.explain = result.Result;
            updateExplainBoxUI();
            return;
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("새로고침 버튼이 눌렸습니다.");
            LanguageForm languageForm = new MainScene.LanguageForm();
            languageForm.selectLanguageEventSender += SelectLanguageEventSender;
            languageForm.ShowDialog();

            metroTextBox1.Text = "로딩 중..";
            metroTextBox2.Text = "로딩 중..";
        }

        private void SelectLanguageEventSender(object sender, SelectLanguageEvent selectLanguageEvent, Object data)
        {
            convertRequest.toLanguage = data.ToString();
            convertResponse.language = data.ToString();
            explainRequest.language = data.ToString();
            explainResponse.language = data.ToString();

            languageLabel.Text = data.ToString();
            requestConvertAPI(this.convertRequest);
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {

        }
    }


}
