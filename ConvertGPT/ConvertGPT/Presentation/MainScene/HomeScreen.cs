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

        // Properties

        ConvertRequest model = new ConvertRequest("","","");

        MainScene.GuideScreen guideScreen = new MainScene.GuideScreen();

        public event HomeEventSender homeEventSender;

        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            model.code = inputTextBox.Text;
            model.fromLanguage = "...";

            LanguageForm languageForm = new MainScene.LanguageForm();
            languageForm.selectLanguageEventSender += SelectLanguageEventSender;
            languageForm.ShowDialog();
        }

        private void SelectLanguageEventSender(object sender, SelectLanguageEvent selectLanguageEvent, Object data)
        {
            model.toLanguage = data.ToString();
            homeEventSender(sender, HomeEvent.nextButtonClicked, model);

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
            guideScreen.Dock = System.Windows.Forms.DockStyle.Fill;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
