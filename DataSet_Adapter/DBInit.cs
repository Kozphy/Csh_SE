using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace DataSet_Adapter
{
    public partial class DBInit : Form
    {
        string connStr = Properties.Settings.Default.northwind;
        public DBInit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbInit();
            string queryString = "select * from Categories";
            string dataSetName = "Categories";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, dataSetName);
                    dataGridView1.DataSource = ds.Tables[dataSetName];
                    cmd.Cancel();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        protected void DbInit()
        {
            string queryString = "select * from Categories";
            SqlConnection Conn = new SqlConnection(connStr);
            SqlDataAdapter adapter = null;
            try
            {
                Conn.Open();
                adapter = new SqlDataAdapter(queryString, Conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "test");
                DataTable dt = ds.Tables["test"];
                StringBuilder sb = new StringBuilder();

                int columnCount = dt.Columns.Count;
                int rowCount = dt.Rows.Count;

                for (int i = 0; i < columnCount; i++)
                {
                    sb.Append(dt.Columns[i]);
                }

                sb.Append("\r\n");

                for (int i = 0; i < columnCount * rowCount; i++)
                {
                    int rowIndex = i / columnCount;
                    int columnIndex = i % columnCount;
                    if (dt.Rows[rowIndex][dt.Columns[columnIndex]] != DBNull.Value)
                    {
                        sb.Append(dt.Rows[rowIndex][dt.Columns[columnIndex]] + "\t");
                    }
                    else
                    {
                        sb.Append("Null");
                    }
                    if (columnIndex == columnCount - 1)
                    {
                        sb.Append("\r\n");
                    }
                }
                Debug.WriteLine(sb);
                label1.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}