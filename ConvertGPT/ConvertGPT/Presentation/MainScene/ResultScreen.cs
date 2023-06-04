using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

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
            requestConvertAPI(this.data);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            resultEventSender(sender, ResultEvent.backButtonClicked, "");
        }

        public void dataBind(object obj)
        {
<<<<<<< HEAD
            inputText = text;
            setScreen();
        }

        private void setScreen() {
            var text = inputText;
            var toLanguageItem = "Swift";
            var fromLanguage = "Python";

            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;

            try
            {
                if (text == null || text == "")
                {
                    throw new ConvertGPTException(ErrorCode.EmptyInput);
                }
                if (toLanguageItem == null)
                {
                    throw new ConvertGPTException(ErrorCode.ToLanguageDeselected);
                }
                requestConvertAPI(fromLanguage, toLanguageItem.ToString(), text);
            }
            catch (ConvertGPTException ex)
            {
                Console.WriteLine($"Error: {ex.ErrorMessage}, ErrorCode: {ex.ErrorCode}");
            }
=======
            Console.WriteLine("dataBind");
            if (obj is ConvertRequest)
            {
                ConvertRequest data = (ConvertRequest)obj;
                this.data = data;
            }

            updateUI();
        }

        private void updateUI() {

            this.languageLabel.Text = data.toLanguage;
>>>>>>> main
        }
        private async void requestConvertAPI(ConvertRequest data)
        {
<<<<<<< HEAD
            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;

            GPTTest convertAPI = new GPTTest();
            Task<string> result = convertAPI.gpttestAsync(from_lang, to_lang, code);
            Console.WriteLine("서버통신을 시작합니다");
            await result;
            Console.WriteLine("서버 응답이 왔습니다.");

            using(MySqlConnection conn = new MySqlConnection(localConfig))
            {
                conn.Open();
                string sql = string.Format("INSERT INTO history (FromLang, ToLang, codeRecord, codeResult) VALUES ('{0}', {1}, {2}, {3});", "\"" + from_lang + "\"", "\"" + to_lang + "\"", code, result.Result);

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
=======
            Console.WriteLine("requestConvertAPI");
            PromptService ps = new PromptService();
            Task<string> result = ps.GetResponse(new ConvertType(data));

            Console.WriteLine("서버통신을 시작합니다");
            await result;
            Console.WriteLine($"서버 응답이 왔습니다. \n {result.Result}");
>>>>>>> main

            metroTextBox1.Text = result.Result;
            return;
        }


        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("새로고침 버튼이 눌렸습니다.");
            requestConvertAPI(this.data);
        }
    }
}
