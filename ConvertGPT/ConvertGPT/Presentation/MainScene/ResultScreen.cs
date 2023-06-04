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
        }
        private async void requestConvertAPI(ConvertRequest data)
        {
            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;

            Console.WriteLine("requestConvertAPI");
            PromptService ps = new PromptService();
            Task<string> result = ps.GetResponse(new ConvertType(data));

            Console.WriteLine("서버통신을 시작합니다");
            await result;
            Console.WriteLine($"서버 응답이 왔습니다. \n {result.Result}");
            using (MySqlConnection conn = new MySqlConnection(localConfig))
            {
                conn.Open();
                string sql = string.Format("INSERT INTO history(FromLang, ToLang, codeRecord, codeResult) VALUES ({0}, {1}, {2}, {3});", "\'" + data.fromLanguage + "\'", "\'" + data.toLanguage + "\'", "\'" + data.code + "\'", "\'" + result.Result + "\'");

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
