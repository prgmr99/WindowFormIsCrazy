using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;

namespace ConvertGPT
{
    public partial class DragForm : MetroFramework.Forms.MetroForm {

        const int MAX_SLIDING_WIDTH = 200;
        const int MIN_SLIDING_WIDTH = 50;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 200;

        // Screen
        MainScene.HomeScreen homeScreen = new MainScene.HomeScreen();
        MainScene.ResultScreen resultScreen = new MainScene.ResultScreen();

        // Life Cycle
        public DragForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }


        private void DragForm_Load(object sender, EventArgs e)
        {
            //this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel.Controls.Add(homeScreen);
            setDelegate();
        }


        // Custom Method

        private void setDelegate() {
            homeScreen.homeEventSender += HomeEventSender;
            resultScreen.resultEventSender += ResultEventSender;
        }

        // Action Method

        private void HomeEventSender(object sender, HomeEvent homeEvent, Object data) {
            Console.WriteLine("nextButton 이벤트가 MainController에 전달 되었습니다");

            switch (homeEvent) {
                case HomeEvent.nextButtonClicked:
                    panel.Controls.Clear();



                    resultScreen.dataBind(data.ToString());

                    panel.Controls.Add(resultScreen);
                    

                    break;
                default: break;
            }
        }

        private void ResultEventSender(object sender, ResultEvent resultEvent,Object data)
        {
            Console.WriteLine("back 이벤트가 MainController에 전달 되었습니다");

            switch (resultEvent)
            {
                case ResultEvent.backButtonClicked:
                    panel.Controls.Clear();
                    panel.Controls.Add(homeScreen);
                    break;
                default: break;
            }
        }

        private void bottomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bottomCheckBox.Checked == true)
            {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                bottomCheckBox.Text = ">";
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                bottomCheckBox.Text = "<";
            }

            //타이머 시작
            timerSliding.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bottomCheckBox.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding.Stop();
            }

            this.splitContainer1.SplitterDistance = _posSliding;
        }
    }
}
