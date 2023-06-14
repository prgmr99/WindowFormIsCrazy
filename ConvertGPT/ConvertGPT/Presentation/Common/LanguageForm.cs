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
    public partial class LanguageForm : MetroFramework.Forms.MetroForm
    {

        public event SelectLanguageEventSender selectLanguageEventSender;

        public LanguageForm()
        {
            InitializeComponent();
        }

        private void languageButton_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            selectLanguageEventSender(sender, SelectLanguageEvent.languageClicked, button.Text);
            this.Close();
        }
    }
}
