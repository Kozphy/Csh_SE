using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlCmd_Ado.NET
{
    public partial class ExecuteNonQuery : Form
    {
        string connStr = Properties.Settings.Default.northwind;
        public ExecuteNonQuery()
        {
            InitializeComponent();
        }

        private void ExecuteNonQuery_Load(object sender, EventArgs e)
        {
            string queryString = "Update Categories set CategoryName='Beverages' where CategoryID=1";
            using (SqlConnection Conn = new SqlConnection(connStr)) {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, Conn);
                int RecordsAffected = cmd.ExecuteNonQuery();
                Debug.WriteLine($"recordsAffected: {RecordsAffected}");
                cmd.Cancel();
            }
        }
    }
}
