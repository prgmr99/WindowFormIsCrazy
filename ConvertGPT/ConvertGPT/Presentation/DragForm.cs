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


        const Single MAX_SLIDING_RATIO = 20F;
        const Single MIN_SLIDING_RATIO = 8F;

        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        //최초 슬라이딩 메뉴 크기
        Single Step_Sliding = 1F;
        Single currentRatio = 20F;


        // Screen
        MainScene.HomeScreen homeScreen = new MainScene.HomeScreen();
        MainScene.ResultScreen resultScreen = new MainScene.ResultScreen();

        FavoriteScreen favoriteScreen = new FavoriteScreen();
        HistoryScreen historyScreen = new HistoryScreen();
        DatabaseScreen databaseScreen = new DatabaseScreen();

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
            this.Padding = new Padding(0, 0, 0, 0);
            homeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
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


                    resultScreen.dataBind(data);

                    panel.Controls.Add(resultScreen);
                    resultScreen.Dock = System.Windows.Forms.DockStyle.Fill;

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
                    homeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
                    break;
                default: break;
            }
        }

        private void bottomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bottomCheckBox.Checked == true)
            {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                bottomCheckBox.Image = global::ConvertGPT.Properties.Resources.icon_right;
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                bottomCheckBox.Image = global::ConvertGPT.Properties.Resources.icon_left;
            }

            //타이머 시작
            timerSliding.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bottomCheckBox.Checked == true)
            {
                ////슬라이딩 메뉴를 숨기는 동작
                currentRatio -= Step_Sliding;
                if (currentRatio <= MIN_SLIDING_RATIO)
                {

                    timerSliding.Stop();
                    convertCodeButton.Text = "";
                    convertDBButton.Text = "";
                    historyButton.Text = "";
                    favoriteButton.Text = "";

                    convertCodeButton.Image = global::ConvertGPT.Properties.Resources.icon_home;
                    convertDBButton.Image = global::ConvertGPT.Properties.Resources.icon_database;
                    historyButton.Image = global::ConvertGPT.Properties.Resources.icon_history;
                    favoriteButton.Image = global::ConvertGPT.Properties.Resources.icon_star;
                }


            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                currentRatio += Step_Sliding;
                if (currentRatio >= MAX_SLIDING_RATIO)
                {
                    convertCodeButton.Text = "코드 변환";
                    convertDBButton.Text = "DB 변환";
                    historyButton.Text = "기록";
                    favoriteButton.Text = "즐겨찾기";

                    convertCodeButton.Image = null ;
                    convertDBButton.Image = null;
                    historyButton.Image = null;
                    favoriteButton.Image = null;
                    timerSliding.Stop();
                    
                }
            }


            this.tableLayoutPanel1.ColumnStyles[0].Width = currentRatio;
            this.tableLayoutPanel1.ColumnStyles[1].Width = 100F - currentRatio;
        }

        private void convertCodeButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(homeScreen);
            homeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void convertDBButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(databaseScreen);
            databaseScreen.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(favoriteScreen);
            favoriteScreen.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(historyScreen);
            historyScreen.Dock = System.Windows.Forms.DockStyle.Fill;
        }

    }
}
