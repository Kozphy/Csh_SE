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
using System.Diagnostics;



namespace SqlCmd_Ado.NET
{
    public partial class drCommandBehavior : Form
    {
        string connStr = Properties.Settings.Default.northwind;
        public drCommandBehavior()
        {
            InitializeComponent();
        }

        private void drCommandBehavior_Load(object sender, EventArgs e)
        {
            string queryString = "select * from Categories";
            using (SqlConnection Conn = new SqlConnection(connStr)) {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(queryString,Conn);
                // when add cmdBehavior, Conn will close before end of using block.
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //while (dr.Read())
                //{
                //    Console.WriteLine(dr[0]);
                //}
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                Debug.WriteLine($"Conn Status: {Conn.State}");
            }
        }
    }
}
