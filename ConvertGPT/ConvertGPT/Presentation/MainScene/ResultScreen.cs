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

        string inputText;

        public ResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScene_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            resultEventSender(sender, ResultEvent.backButtonClicked, "");
        }

        public void dataBind(String text)
        {
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
        }
        private async void requestConvertAPI(string from_lang, string to_lang, string code)
        {
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

            metroTextBox1.Text = result.Result;
            return;
        }


        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
