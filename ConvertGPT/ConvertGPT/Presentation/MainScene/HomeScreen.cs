using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ConvertGPT.MainScene
{


    public partial class HomeScreen : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int radiusX, int radiusY);


        MainScene.GuideScreen guideScreen = new MainScene.GuideScreen();
        MainScene.LanguageForm languageForm = new MainScene.LanguageForm();

        public event HomeEventSender homeEventSender;

        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            nextButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nextButton.Width, nextButton.Height, 50, 50));
            languageForm.selectLanguageEventSender += SelectLanguageEventSender;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            languageForm = new MainScene.LanguageForm();
            languageForm.Show();
        }

        private void SelectLanguageEventSender(object sender, SelectLanguageEvent selectLanguageEvent, Object data)
        {
            switch (selectLanguageEvent)
            {
                case SelectLanguageEvent.languageClicked:
                    languageForm.Close();
                    homeEventSender(sender, HomeEvent.nextButtonClicked, inputTextBox.Text);
                    break;
            }
      
        }


        private void HomeScreen_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragForm_DragDrop");
            Controls.Remove(guideScreen);
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string filePath in filePaths)
            {
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    inputTextBox.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        private void HomeScreen_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragForm_DragEnter");
            Controls.Add(guideScreen);
            guideScreen.BringToFront();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void HomeScreen_DragLeave(object sender, EventArgs e)
        {
            Console.WriteLine("DragForm_DragLeave");
            Controls.Remove(guideScreen);

        }

        private void HomeScreen_DragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragForm_DragOver");
        }

        private void HomeScreen_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            Console.WriteLine("DragForm_GiveFeedback");
        }

        private void HomeScreen_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Console.WriteLine("DragForm_QueryContinueDrag");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
