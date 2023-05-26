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

        MainScene.HomeScreen homeScreen = new MainScene.HomeScreen();
        MainScene.ResultScreen resultScreen = new MainScene.ResultScreen();

        public DragForm()
        {

            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += DragForm_DragEnter;
            this.DragDrop += DragForm_DragDrop;
        }


        private void DragForm_Load(object sender, EventArgs e)
        {
            metroPanel1.Controls.Add(homeScreen);
            setDelegate();
        }


        private void setDelegate() {
            homeScreen.homeEventSender += HomeEventSender;
            resultScreen.resultEventSender += ResultEventSender;
        }

        private void HomeEventSender(object sender, HomeEvent homeEvent) {
            Console.WriteLine("nextButton 이벤트가 MainController에 전달 되었습니다");

            switch (homeEvent) {
                case HomeEvent.nextButtonClicked:
                    metroPanel1.Controls.Clear();
                    metroPanel1.Controls.Add(resultScreen);
                    break;
                default: break;
            }
        }

        private void ResultEventSender(object sender, ResultEvent resultEvent)
        {
            Console.WriteLine("back 이벤트가 MainController에 전달 되었습니다");

            switch (resultEvent)
            {
                case ResultEvent.backButtonClicked:
                    metroPanel1.Controls.Clear();
                    metroPanel1.Controls.Add(homeScreen);
                    break;
                default: break;
            }
        }





        private void DragForm_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragForm_DragEnter");

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DragForm_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragForm_DragDrop");
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            //foreach (string path in filePaths)
            //{
            //    label1.Text = path;
            //}
        }



        private void DragForm_DragLeave(object sender, EventArgs e)
        {
            Console.WriteLine("DragForm_DragLeave");
        }

        private void DragForm_DragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragForm_DragOver");
        }

        private void DragForm_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            Console.WriteLine("DragForm_GiveFeedback");
        }

        private void DragForm_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Console.WriteLine("DragForm_QueryContinueDrag");
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("label1_MouseDown");
           // label1.AllowDrop = true;
            //label1.DoDragDrop(label1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
