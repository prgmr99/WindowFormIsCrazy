using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertGPT
{
    public partial class HistoryScreen : UserControl
    {

        List<HistoryModel> data = new List<HistoryModel>();


        public HistoryScreen()
        {
            InitializeComponent();
        }


        private void HistoryScreen_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestHistoryData();
        }


        public void requestHistoryData()
        {
            this.data.Clear();
            historyFlowLayoutPanel.Controls.Clear();
            DataSet ds = new DataSet();

            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;
            string sql = "SELECT curTime, fromLang, toLang, codeRecord, codeResult, explainCode FROM history ORDER BY curTime DESC ";

            MySqlConnection conDataBase = new MySqlConnection(exConfig);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                int count = dataTable.Rows.Count;
                Console.WriteLine($"서버에서 읽은 데이터 개수: {count}");

                for (int r = 0; r < count; r ++) {

                    DataRow row = dataTable.Rows[r];
                    object[] values = row.ItemArray;

                    HistoryModel data = new HistoryModel(r, values);

                    this.data.Add(data);
                    addHistoryCell(data);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addHistoryCell(HistoryModel data) {
            HistoryCell cell = new HistoryCell();
            cell.dataBind(data);
            cell.historyCellSelectEventSender += HistoryCellSelectEventSender;
            historyFlowLayoutPanel.Controls.Add(cell);
        }

        private void HistoryCellSelectEventSender(int id) {
            HistoryResultScreen resultScreen = new HistoryResultScreen();
            Console.Write(this.data);
            resultScreen.dataBind(this.data[id]);
            resultScreen.resultEventSender += ResultEventSender;
            panel1.Controls.Add(resultScreen);
            resultScreen.Dock = DockStyle.Fill;
            resultScreen.BringToFront();
        }

        private void ResultEventSender(object sender, ResultEvent resultEvent, Object data)
        {
            Console.WriteLine("back 이벤트가 HistoryScreen 전달 되었습니다");

            switch (resultEvent)
            {
                case ResultEvent.backButtonClicked:
                    Control topControl = this.panel1.Controls[0]; // 최상단 컨트롤 가져오기
                    this.panel1.Controls.Remove(topControl);
                    break;
                default: break;
            }
        }


    }
}
