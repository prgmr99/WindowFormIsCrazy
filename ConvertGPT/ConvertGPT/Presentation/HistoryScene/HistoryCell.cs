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
    public partial class HistoryCell : UserControl
    {

        HistoryModel data = new HistoryModel();

        public event HistoryCellSelectEventSender historyCellSelectEventSender;

        public HistoryCell()
        {
            InitializeComponent();
        }


        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            historyCellSelectEventSender(data.id);
        }

        public void dataBind(HistoryModel data) { 
            this.data = data;
            updateUI();
        }

        private void updateUI() {
            timeAgoLabel.Text = data.timeAgo.ToString();
            languageLabel.Text = $"{data.toLanguage}";
            explainLabel.Text = data.explain.ToString();
        }

        
    }
}
