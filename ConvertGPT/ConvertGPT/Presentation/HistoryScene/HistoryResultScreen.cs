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

namespace ConvertGPT
{
    public partial class HistoryResultScreen : UserControl
    {


        public event ResultEventSender resultEventSender;

        HistoryModel data;


        public HistoryResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScene_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load");
        }


        public void dataBind(HistoryModel data)
        {
            this.data = data;
            
            languageLabel.Text = data.toLanguage;
            convertResultTextBox.Text = data.outputCode;
            explainResultTextBox.Text = data.explain;
            updateCodeTextBoxUI();
        }

        private void updateCodeTextBoxUI() {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            resultEventSender(sender, ResultEvent.backButtonClicked, "");
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            // 텍스트 박스에서 텍스트 가져오기
            string copiedText = convertResultTextBox.Text;

            // 클립보드에 텍스트 복사
            Clipboard.SetText(copiedText);

            // 기본 백그라운드 이미지 저장

            btnCopy.BackgroundImage = Properties.Resources.icon_check;
            // 2초 기다린 후
            await Task.Delay(2000);

            btnCopy.BackgroundImage = Properties.Resources.icon_copy;

        }
    }


}
