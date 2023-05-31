using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertGPT.MainScene
{
    public partial class HomeScreen : UserControl
    {
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
            homeEventSender(sender, HomeEvent.nextButtonClicked, metroTextBox1.Text);
        }



     
    }
}
