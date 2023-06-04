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
using ScintillaNET;
using MySql.Data.MySqlClient;
//using System.Configuration;

namespace ConvertGPT
{
    public partial class MainForm : MetroFramework.Forms.MetroForm //상속 클래스 변경
    {

        // ------- 생명주기 함수 ------- 

        // Database 객체 생성
        DataTable table = new DataTable();
        
        // string localConfig = ConfigurationManager.AppSettings["LocalHost"];
        // string exConfig = ConfigurationManager.AppSettings["ExConnect"];
        public MainForm()
        {
            
            InitializeComponent();
            this.MinimumSize = new Size(900, 700); // 창크기 최소 폭 900, 높이 700 제한
            outputTextBox.Styles[ScintillaNET.Style.Default].Size = 12; // 기본 폰트 사이즈 설정

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

            Console.WriteLine(toLanguageItem);
            // Database에 정보 저장
            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;

            using (MySqlConnection conn = new MySqlConnection(exConfig))
            {
                conn.Open();
                string sql = string.Format("INSERT INTO history(FromLang, ToLang, codeRecord) VALUES ('{0}', {1}, {2});", "\"" + fromLanguage + "\"", "\"" + toLanguageItem.ToString() + "\"", "\"" + text + "\"");

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
        //
        // ----- ComboBox 프로그래밍 언어 선택시 언어별 코드 색상 변경 -----
        //
        private void selectLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectLanguage = selectLanguageComboBox.SelectedItem.ToString();
            switch (selectLanguage)
            {
                case "C#":
                    customizeSyntaxHighlighting_CSharp();
                    break;
                case "Java":
                    customizeSyntaxHighlighting_Java();
                    break;
                case "Javascript":
                    customizeSyntaxHighlighting_JS();
                    break;
                case "Python":
                    customizeSyntaxHighlighting_Python();
                    break;
            }
        }

        private void customizeSyntaxHighlighting_CSharp()
        {
            outputTextBox.StyleResetDefault();
            outputTextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            outputTextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            outputTextBox.StyleClearAll();

            // C# Lexer Style 설정
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.Silver;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0);
            outputTextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0);
            outputTextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128);
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.Olive;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.Blue;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.OrangeRed;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21);
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21);
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21);
            outputTextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.Pink;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            outputTextBox.Lexer = Lexer.Cpp;

            // C# keywords 설정
            outputTextBox.SetKeywords(0, "abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using virtual while");
            outputTextBox.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void");
        }

        private void customizeSyntaxHighlighting_Java()
        {
            outputTextBox.StyleResetDefault();
            outputTextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            outputTextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            outputTextBox.StyleClearAll();

            // Java Lexer Style 설정
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.FromArgb(64, 64, 64);  // 전체 기본 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.DarkGreen;  // 주석 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.Green;  // 한 줄 주석 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.Gray;  // 문서 주석 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.DarkOliveGreen;  // 숫자 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.DarkBlue;  // 키워드 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.DarkRed;  // 키워드2 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.FromArgb(128, 0, 0);  // 문자열 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.FromArgb(128, 0, 0);  // 문자 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.FromArgb(128, 0, 0);  // 리터럴 문자열 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.LightPink;  // 문자열 끝 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;  // 연산자 색상
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;  // 전처리기 지시문 색상
            outputTextBox.Lexer = Lexer.Cpp;

            // Java 키워드 설정
            outputTextBox.SetKeywords(0, "abstract assert break case catch class const continue default do else enum extends final finally for if implements import instanceof interface native new null package private protected public return static strictfp super switch synchronized this throw throws transient true try void volatile while void");
            outputTextBox.SetKeywords(1, "boolean byte char double float int long short");

        }

        private void customizeSyntaxHighlighting_JS()
        {
            outputTextBox.StyleResetDefault();
            outputTextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            outputTextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            outputTextBox.StyleClearAll();

            // Lexer Style 설정
            outputTextBox.Styles[ScintillaNET.Style.Default].ForeColor = Color.Black;
            outputTextBox.Styles[ScintillaNET.Style.Default].BackColor = Color.White;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.Black;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Default].BackColor = Color.White;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.Green;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.Green;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.Gray;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.DarkOliveGreen;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.DarkBlue;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.DodgerBlue;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.DarkRed;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.DarkRed;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.DarkRed;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.LightPink;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;
            outputTextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            outputTextBox.Lexer = Lexer.Cpp;


            // JS keywords 설정
            outputTextBox.SetKeywords(0, "enum implements interface let package private protected public static yield await break case catch class const continue debugger default delete do else export extends false finally for function if import in instanceof new null return super switch this throw true try typeof var void while with");
            outputTextBox.SetKeywords(1, "int");
        }

        private void customizeSyntaxHighlighting_Python()
        {
            outputTextBox.StyleResetDefault();
            outputTextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            outputTextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            outputTextBox.StyleClearAll();

            // Set the styles
            outputTextBox.Styles[ScintillaNET.Style.Python.Default].ForeColor = Color.FromArgb(0x80, 0x80, 0x80); // 기본 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.CommentLine].ForeColor = Color.FromArgb(0x00, 0x7F, 0x00); // 한 줄 주석 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.CommentLine].Italic = true; // 한 줄 주석 스타일을 이탤릭체로 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.Number].ForeColor = Color.Olive;
            outputTextBox.Styles[ScintillaNET.Style.Python.Word].ForeColor = Color.FromArgb(0x00, 0x00, 0x7F); // 키워드 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.Word].Bold = true; // 키워드 스타일을 굵게 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.Word2].ForeColor = Color.Green;
            outputTextBox.Styles[ScintillaNET.Style.Python.String].ForeColor = Color.FromArgb(163, 21, 21);
            outputTextBox.Styles[ScintillaNET.Style.Python.Character].ForeColor = Color.FromArgb(163, 21, 21);
            outputTextBox.Styles[ScintillaNET.Style.Python.StringEol].ForeColor = Color.FromArgb(0x00, 0x00, 0x00);
            outputTextBox.Styles[ScintillaNET.Style.Python.StringEol].BackColor = Color.FromArgb(0xE0, 0xC0, 0xE0);
            outputTextBox.Styles[ScintillaNET.Style.Python.Operator].ForeColor = Color.Purple;
            outputTextBox.Styles[ScintillaNET.Style.Python.Operator].Bold = true;
            outputTextBox.Styles[ScintillaNET.Style.Python.Triple].ForeColor = Color.FromArgb(0x7F, 0x00, 0x00); // 삼중 따옴표 문자열 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.TripleDouble].ForeColor = Color.FromArgb(0x7F, 0x00, 0x00); // 쌍삼중 따옴표 문자열 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.ClassName].ForeColor = Color.FromArgb(0x00, 0x00, 0xFF); // 클래스 이름 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.ClassName].Bold = true; // 클래스 이름 스타일을 굵게 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.DefName].ForeColor = Color.FromArgb(0x00, 0x7F, 0x7F);  // 함수 정의 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.DefName].Bold = true; // 함수 정의 스타일을 굵게 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.CommentBlock].ForeColor = Color.FromArgb(0x7F, 0x7F, 0x7F); // 블록 주석 스타일의 전경색 설정
            outputTextBox.Styles[ScintillaNET.Style.Python.CommentBlock].Italic = true; // 블록 주석 스타일을 이탤릭체로 설정

            // Python Lexer Style 설정
            outputTextBox.Lexer = Lexer.Python;

            // Python keywords 설정
            outputTextBox.SetKeywords(0, "and as assert break class continue def del elif else except exec finally for from global if import in is lambda not or pass print raise return try while with yield" +
                "False None True and as assert break class continue def del elif else except finally for from global if import in is lambda nonlocal not or pass raise return try while with yield" +
                "cdef cimport cpdef" +
                "");
            outputTextBox.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void" +
                "append extend insert pop remove count index sort reverse copy abs all any bin bool chr divmod float hex int len max min oct ord pow range round sorted str type keys" +
                "");

            // Important for Python
            outputTextBox.ViewWhitespace = WhitespaceMode.VisibleAlways; // 공백 문자 항상 표시하기
        }
        //
        // ----- 복사 이벤트 함수 -----
        //
        private async void CopyBtn_Click(object sender, EventArgs e)
        {
            // 텍스트 박스에서 텍스트 가져오기
            string copiedText = outputTextBox.Text;

            // 클립보드에 텍스트 복사
            Clipboard.SetText(copiedText);

            // 복사 반응(2초 딜레이)
            CopyBtn.Text = "Copied!";
            await Task.Delay(2000);
            CopyBtn.Text = "Copy";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;
            MySqlConnection connection = new MySqlConnection(exConfig);
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
