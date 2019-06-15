using Dapper;
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

namespace SqlMapperLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(txt_connection.Text.Trim()))
                btn_connect.Enabled = false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (IsServerConnected(txt_connection.Text))
            {
                MessageBox.Show("Database connected successfully");
            }
            else
            {
                MessageBox.Show("Database not connected successfully");
            }

             
        }

        public bool IsServerConnected(string connectionstring)
        {
            using (var l_oConnection = new SqlConnection(connectionstring))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }


        public void getDBElements(string conn)
        {
            using(SqlConnection con=new SqlConnection(conn))
            {
                var result=con.QueryMultiple("SELECT table_name FROM INFORMATION_SCHEMA.TABLES");
                cmb_table.DataSource = result.Read<string>().ToList();
            }
        }
    }
}
