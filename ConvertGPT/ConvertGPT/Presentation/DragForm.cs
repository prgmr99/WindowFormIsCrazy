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
    }
}
