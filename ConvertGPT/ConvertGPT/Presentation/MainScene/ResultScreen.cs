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
            var fromLanguage = "CSharp";

            String Name = "SeungJun"; // if 로그인 구현 X -> no need
            String Lang = "\"C++\"";
            String dbText = "\"" + text + "\"";

            try
            {
                //MySqlCommand command = new MySqlCommand(sql, conn);
                //command.ExecuteNonQuery();

                //if (text == null || text == "")
                //{
                //    throw new ConvertGPTException(ErrorCode.EmptyInput);
                //}
                //if (toLanguageItem == null)
                //{
                //    throw new ConvertGPTException(ErrorCode.ToLanguageDeselected);
                //}

                requestConvertAPI(fromLanguage, toLanguageItem.ToString(), text);

            }
            catch (ConvertGPTException ex)
            {
                Console.WriteLine($"Error: {ex.ErrorMessage}, ErrorCode: {ex.ErrorCode}");
            }
        }
        private async void requestConvertAPI(string from_lang, string to_lang, string code)
        {
            GPTTest convertAPI = new GPTTest();
            Task<string> result = convertAPI.gpttestAsync(from_lang, to_lang, code);
            Console.WriteLine("서버통신을 시작합니다");
            await result;
            Console.WriteLine("서버 응답이 왔습니다.");
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
