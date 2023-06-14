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

        HistoryModel[] data;

        public HistoryScreen()
        {
            InitializeComponent();
        }


        private void HistoryScreen_Load(object sender, EventArgs e)
        {
            requestHistoryData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestHistoryData();
        }


        private void requestHistoryData()
        {
            DataSet ds = new DataSet();

            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;
            string sql = "SELECT FromLang, ToLang, codeRecord, codeResult from history";

            MySqlConnection conDataBase = new MySqlConnection(exConfig);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                int count = dataTable.Rows.Count;

                for (int r = 0; r < count; r ++) {

                    DataRow row = dataTable.Rows[r];
                    object[] values = row.ItemArray;

                    HistoryModel data = new HistoryModel(r, values);

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
            historyFlowLayoutPanel.Controls.Add(cell);
        }



        //private void requestHistoryData()
        //{
        //    DataSet ds = new DataSet();

        //    string localConfig = Secret.LocalHost;
        //    string exConfig = Secret.ExConnect;
        //    string sql = "SELECT ToLang, codeRecord, codeResult from history";

        //    MySqlConnection conDataBase = new MySqlConnection(exConfig);
        //    MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);

        //    try
        //    {
        //        MySqlDataAdapter sda = new MySqlDataAdapter();
        //        sda.SelectCommand = cmdDataBase;
        //        DataTable dbdataset = new DataTable();
        //        sda.Fill(dbdataset);
        //        BindingSource bSouce = new BindingSource();

        //        bSouce.DataSource = dbdataset;
        //        dataGridView1.DataSource = bSouce;
        //        sda.Update(dbdataset);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
