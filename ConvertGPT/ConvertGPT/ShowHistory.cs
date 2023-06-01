using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvertGPT.Error;
using ScintillaNET;
using MySql.Data.MySqlClient;

// History 항목 클릭시
namespace ConvertGPT
{
    internal class ShowHistory
    {
        public void showHistory() {
             using (MySqlConnection conn1 = new MySqlConnection("Server=localhost;Port=3306;Database=;Uid=root;Pwd=sjyeom2105"))
             {
                SqlConnection conn1 = new SqlConnection();
                conn1.ConnectionString = connectionString;
                conn1.Open();

                string sql1 = "SELECT * FROM history";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql1;
                cmd.Connection = conn1;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                DataSet ds = new DataSet();
                da.Fill(ds, "std");

                dataGridView1.DataSource = ds.Tables["std"];
            }
        }

    }
}