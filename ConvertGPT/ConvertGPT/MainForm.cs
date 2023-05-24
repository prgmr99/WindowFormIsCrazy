using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvertGPT.Error;
using MySql.Data.MySqlClient;

namespace ConvertGPT
{
    public partial class MainForm : MetroFramework.Forms.MetroForm //상속 클래스 변경
    {

        // ------- 생명주기 함수 ------- 

        // Database 객체 생성
        DataTable table = new DataTable();

        public MainForm()
        {
            
            InitializeComponent();
            
            //windowSize_Limit(900, 680); // 창크기 제한
            table.Columns.Add("Name", typeof(string)); // 이름 Column(보류 -> 로그인 기능 구현)
            table.Columns.Add("Code", typeof(string)); // 코드 Column
            table.Columns.Add("Conversion", typeof(string)); // 변환 정보 Column
        }

        //
        // ------- 폼 사이즈 변경시 관련요소 위치 및 크기 설정 -------
        //
        private void MainForm_Resize(object sender, EventArgs e)
        {
            outputTextBox.Location = new Point(this.Width / 2 + 10, inputTextBox.Location.Y);
            CopyBtn.Location = new Point(this.Width / 2 + 10, convertBtn.Location.Y);

            inputTextBox.Width = this.Width / 2 - 10;
            outputTextBox.Width = this.Width / 2 - 20;

            convertBtn.Width = this.Width / 2 - 10;
            CopyBtn.Width = this.Width / 2 - 20;
            

            windowSize_Limit(900, 680); // 창크기 제한
        }
        //
        // ------- 창크기 제한 -------
        //

        private void windowSize_Limit(int width,int height)
        {
            // 코드 내용은 각 메서드를 커서로 놓으면 세부 내용이 나옴
            this.MinimizeBox = true; // 폼의 최소화 버튼을 활성화

            this.MaximizeBox = false; // 폼의 최대화 버튼을 비활성화
            this.AutoSize = false; // 폼의 자동 크기 조정을 비활성화
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; // 폼의 자동 크기 조정 방법을 설정
            this.MinimumSize = new Size(width, height); // 최소 폭 900, 높이 680 
            this.MaximumSize = new Size(width, height); // 최대 폭 900, 높이 680
        }
        //
        // ------- 커스텀 함수 ------- 
        //
        private async void requestConvertAPI(string from_lang, string to_lang, string code) {
            GPTTest convertAPI = new GPTTest();
            Task<string> result = convertAPI.gpttestAsync(from_lang, to_lang, code);
            Console.WriteLine("서버통신을 시작합니다");
            await result;
            Console.WriteLine("서버 응답이 왔습니다.");
            outputTextBox.Text = result.Result;
            return;
        }
        //
        //
        // ------- 동작이벤트 관련 함수 ------- 
        //
        //
        private void convertBtn_Click(object sender, EventArgs e)
        {
            var text = inputTextBox.Text;
            var toLanguageItem = selectLanguageComboBox.SelectedItem;
            var fromLanguage = "Javascript";

            String Name = "SeungJun"; // if 로그인 구현 X -> no need
            String Lang = "\"C++\"";
            String dbText = "\"" + text + "\"";
            
            // Database에 정보 저장
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=modeldb;Uid=root;Pwd=sjyeom2105"))
            {
                conn.Open();
                string sql = string.Format("INSERT INTO usertbl(userName, usageRecord, convertRecord) VALUES ('{0}', {1}, {2});", Name, dbText, Lang);
                try
                {
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();

                    if (text == null || text == "")
                    {
                        throw new ConvertGPTException(ErrorCode.EmptyInput);
                    }
                    if (toLanguageItem == null)
                    {
                        throw new ConvertGPTException(ErrorCode.ToLanguageDeselected);
                    }

                    //requestConvertAPI(fromLanguage, toLanguageItem.ToString(), text);

                }
                catch (ConvertGPTException ex)
                {
                    Console.WriteLine($"Error: {ex.ErrorMessage}, ErrorCode: {ex.ErrorCode}");
                }
            }
        }

        private void convertBtn_MouseEnter(object sender, EventArgs e)
        {
            // 버튼에 마우스가 들어올 때 배경색 변경
            // ! 왜 적용이 안되지?

        }
        private void convertBtn_MouseLeave(object sender, EventArgs e)
        {;
            // 버튼에서 마우스가 벗어날 때 배경색 원래대로 변경
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost;" +
                "port=3306;" +
                "username=root;" +
                "password=sjyeom2105;");
            connection.Open();
            if(connection.State == System.Data.ConnectionState.Open)
            {
                lblDB.Text = "Connected";
                lblDB.ForeColor = Color.Blue;
            }
            else
            {
                lblDB.Text = "DisConnected";
                lblDB.ForeColor = Color.Red;
            }
        }
    }
}
