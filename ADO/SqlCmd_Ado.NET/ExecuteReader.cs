using System.Data;
using System.Data.SqlClient;

namespace SqlCmd_Ado.NET
{
    public partial class ExecuteReader : Form
    {
        string connStr = Properties.Settings.Default.northwind;
        public ExecuteReader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string queryString = "select * from Categories";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            try
            {
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    cmd.Cancel();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}