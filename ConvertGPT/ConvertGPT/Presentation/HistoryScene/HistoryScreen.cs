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
        public HistoryScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;
            string sql = "SELECT ToLang, codeRecord, codeResult from history";

            MySqlConnection conDataBase = new MySqlConnection(localConfig);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset;
                dataGridView1.DataSource = bSouce;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HistoryScreen_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string localConfig = Secret.LocalHost;
            string exConfig = Secret.ExConnect;
            string sql = "SELECT ToLang, codeRecord, codeResult from history";

            MySqlConnection conDataBase = new MySqlConnection(localConfig);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset;
                dataGridView1.DataSource = bSouce;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
