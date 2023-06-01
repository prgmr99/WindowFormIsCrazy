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

namespace ConvertGPT.HistoryScreen
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
            string sql = "SELECT * from history";

            SqlConnection conn = new SqlConnection(localConfig);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = ds.Tables["history"];
            da.Fill(ds, "temp1");
            dataGridView1.DataSource = ds.Tables["temp1"];
            conn.Close();
        }
    }
}
