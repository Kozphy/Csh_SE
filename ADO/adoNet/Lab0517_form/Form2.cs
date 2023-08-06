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

namespace Lab0517_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cn = "Data Source=DESKTOP-BO1NJFV;Initial Catalog=northwind;User ID=zixsa;Password=0270453";

            SqlConnection sqlConn = new SqlConnection(cn);
            sqlConn.Open();

            string query = "select * from Products";

            SqlDataAdapter adapter = new SqlDataAdapter(query,cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            sqlConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cn = "Data Source=DESKTOP-BO1NJFV;Initial Catalog=advantureWorksDW2022;User ID=zixsa;Password=0270453";

            SqlConnection sqlConn = new SqlConnection(cn);
            sqlConn.Open();
            string query = "select TOP 1000 * from DimCustomer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            sqlConn.Close();

            dataGridView1.Columns[0].HeaderText = "pika";
            dataGridView1.Columns[1].HeaderText = "pondin";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
