using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertGPT
{
    public partial class Form1 : MetroFramework.Forms.MetroForm //상속 클래스 변경
    {
        // 창크기 설정
        int width = 900;
        int height = 680;

        public Form1()
        {
            InitializeComponent();
            // 창크기 제한
            windowSize_Limit(width,height);
        }

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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputText_Click(object sender, EventArgs e)
        {

        }

        private void outputText_Click(object sender, EventArgs e)
        {

        }

        private void convertBtn_Click(object sender, EventArgs e)
        {

        }

        private void outputCopy_Click(object sender, EventArgs e)
        {

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
    }
}
